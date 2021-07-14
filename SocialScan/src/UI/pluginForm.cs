using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using PluginsAPI;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace FocaPlugin
{
    public partial class PluginForm : Form
    {
        DBAccess dba;
        WebExtractor webex;
        RRSSController rsc;
        HistoryController hc;

        string defaultConnString= @"Data Source=(localdb)\focadb;Initial Catalog=Foca;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=3";
        
        bool scanning = false;
        bool headless = false;
        bool defaultDb = false;
        
        public PluginForm()
        {
            InitializeComponent();


            //get foca db conn string from config files
            try
            {
                XmlDocument focacfg = new XmlDocument();
                focacfg.Load("FOCA.exe.Config");
                XmlNodeList nodes = focacfg.SelectNodes("/configuration/connectionStrings");
                if (nodes.Count > 0)
                {
                    XmlNode target = nodes[0];
                    this.defaultConnString = target.ChildNodes[1].Attributes["connectionString"].Value;
                    this.defaultDb = true;
                }

               
            }
            
            catch (Exception e) {
               
                MessageBox.Show(e.ToString()); 
            }
            //bg worker
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            //foca conn params
            
            textBoxConnectionString.Text = this.defaultConnString;
            textBoxTable.Text = "EmailsItems";
            textBoxColumn.Text = "Mail";

            //init controllers
            this.rsc = new RRSSController();
            this.hc = new HistoryController();

        }

        


        //ONCLICK HANDLERS

        private void buttonScan_Click(object sender, EventArgs e)
        {


            //field check
            if (scanning) { return; }
            if (String.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("No E-Mail provided!");
                return;
            }

            //regex parse email
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",RegexOptions.CultureInvariant | RegexOptions.Singleline);
            if (!this.rsc.checkValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Invalid E-Mail");
                return;
            }

            //get parameters
            string email = textBoxEmail.Text;
            this.headless = checkBoxHeadless.Checked;

            //prepare ui for scan
            this.scanning = true;
            buttonScan.Enabled = false;
            labelScanning.ForeColor = System.Drawing.Color.ForestGreen;
            labelScanning.Text = "Ongoing...";
            progressBarScan.Value = 0;
            lblStep.Text = "Loading Web drivers...";

            //start bg task
            backgroundWorker1.RunWorkerAsync(email);
            
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                //sacar params
                string connString = textBoxConnectionString.Text;
                string table = textBoxTable.Text;
                string column = textBoxColumn.Text;

                if (String.IsNullOrWhiteSpace(connString))
                {
                    MessageBox.Show("No Connection String provided!");
                    return;
                }

                if (String.IsNullOrWhiteSpace(table))
                {
                    textBoxTable.Text = "EmailsItems";
                    table = "EmailsItems";
                }

                if (String.IsNullOrWhiteSpace(column))
                {
                    textBoxColumn.Text = "Mail";
                    column = "Mail";
                }

                //query emails

                this.dba = new DBAccess(connString, table, column);
                List<String> mails = this.dba.getMails();
                

                listBoxEmails.DataSource = mails;

                
                
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }


        private void listBoxEmails_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxEmails.Items.Count == 0) return;
            string mail = (string)listBoxEmails.SelectedItem;
            textBoxEmail.Text = mail;
            
        }



        private void buttonExport_Click(object sender, EventArgs e)
        {
            hc.export(dataGridViewHistoric);
        }


        //BG TASK

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //init scan
            BackgroundWorker helperBW = sender as BackgroundWorker;

            string email = (string)e.Argument;
            ScanResults sr = new ScanResults(email);

            this.rsc.initScan(this.headless); //init selenium driver
            helperBW.ReportProgress(10);
            
            //scans
            bool googleResult = this.rsc.GoogleScan(email);
            sr.google.value = googleResult;
            helperBW.ReportProgress(20);

            bool amazonResult = this.rsc.AmazonScan(email);
            sr.amazon.value = amazonResult;
            helperBW.ReportProgress(30);

            bool twitterResult = this.rsc.TwitterScan(email);
            sr.twitter.value = twitterResult;
            helperBW.ReportProgress(40);

            bool facebookResult = this.rsc.FacebookScan(email);
            sr.facebook.value = facebookResult;
            helperBW.ReportProgress(50);

            bool instagramResult = this.rsc.InstagramScan(email);
            sr.instagram.value = instagramResult;
            helperBW.ReportProgress(60);

            bool tumblrResult = this.rsc.TumblrScan(email);
            sr.tumblr.value = tumblrResult;
            helperBW.ReportProgress(70);

            bool microsoftResult = this.rsc.MicrosoftScan(email);
            sr.microsoft.value = microsoftResult;
            helperBW.ReportProgress(80);
            
            this.rsc.closeScan();
            
            e.Result = sr;
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarScan.Value = e.ProgressPercentage;
            string step = "";
            switch (e.ProgressPercentage)
            {
                case 10:
                    step = "Google...";
                    break;
                case 20:
                    step = "Amazon...";
                    break;
                case 30:
                    step = "Twitter...";
                    break;
                case 40:
                    step = "Facebook...";
                    break;
                case 50:
                    step = "Instagram...";
                    break;
                case 60:
                    step = "Tumblr...";
                    break;
                case 70:
                    step = "Microsoft...";
                    break;
                case 80:
                    step = "Closing drivers...";
                    break;
                
            }
            lblStep.Text = step;
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ScanResults result = (ScanResults)e.Result;
            System.Drawing.Color trueColor = System.Drawing.Color.ForestGreen;
            System.Drawing.Color falseColor = System.Drawing.Color.DarkSalmon;
            //update history
            hc.updateHistory(result);

            //update history view
            int rowId = dataGridViewHistoric.Rows.Add();
            dataGridViewHistoric.Rows[rowId].Cells[0].Value = result.address;
            
            dataGridViewHistoric.Rows[rowId].Cells[1].Value = result.google.value;
            dataGridViewHistoric.Rows[rowId].Cells[1].Style.BackColor = (result.google.value) ? trueColor : falseColor;

            dataGridViewHistoric.Rows[rowId].Cells[2].Value = result.amazon.value;
            dataGridViewHistoric.Rows[rowId].Cells[2].Style.BackColor = (result.amazon.value) ? trueColor : falseColor;

            dataGridViewHistoric.Rows[rowId].Cells[3].Value = result.twitter.value;
            dataGridViewHistoric.Rows[rowId].Cells[3].Style.BackColor = (result.twitter.value) ? trueColor : falseColor;

            dataGridViewHistoric.Rows[rowId].Cells[4].Value = result.facebook.value;
            dataGridViewHistoric.Rows[rowId].Cells[4].Style.BackColor = (result.facebook.value) ? trueColor : falseColor;

            dataGridViewHistoric.Rows[rowId].Cells[5].Value = result.instagram.value;
            dataGridViewHistoric.Rows[rowId].Cells[5].Style.BackColor = (result.instagram.value) ? trueColor : falseColor;

            dataGridViewHistoric.Rows[rowId].Cells[6].Value = result.tumblr.value;
            dataGridViewHistoric.Rows[rowId].Cells[6].Style.BackColor = (result.tumblr.value) ? trueColor : falseColor;

            dataGridViewHistoric.Rows[rowId].Cells[7].Value = result.microsoft.value;
            dataGridViewHistoric.Rows[rowId].Cells[7].Style.BackColor = (result.microsoft.value) ? trueColor : falseColor;

            //prepare UI
            labelScanning.ForeColor = System.Drawing.Color.Red;
            labelScanning.Text = "Finished";
            progressBarScan.Value = 100;
            lblStep.Text = "History updated.";
            this.scanning = false;
            buttonScan.Enabled = true;

            //notify user
            MessageBox.Show(result.ToString());

        }

        

        
    }
}

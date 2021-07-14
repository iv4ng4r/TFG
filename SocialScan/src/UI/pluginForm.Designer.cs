namespace FocaPlugin
{
    partial class PluginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.listBoxEmails = new System.Windows.Forms.ListBox();
            this.buttonScan = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.textBoxColumn = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxConnectionString = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxHeadless = new System.Windows.Forms.CheckBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.labelScanning = new System.Windows.Forms.Label();
            this.progressBarScan = new System.Windows.Forms.ProgressBar();
            this.lblStep = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonExport = new System.Windows.Forms.Button();
            this.dataGridViewHistoric = new System.Windows.Forms.DataGridView();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.google = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amazon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.twitter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facebook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instagram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tumblr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.microsoft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoric)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(120, 153);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(30, 13);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Data";
            // 
            // listBoxEmails
            // 
            this.listBoxEmails.FormattingEnabled = true;
            this.listBoxEmails.Location = new System.Drawing.Point(427, 45);
            this.listBoxEmails.Name = "listBoxEmails";
            this.listBoxEmails.Size = new System.Drawing.Size(186, 108);
            this.listBoxEmails.TabIndex = 4;
            this.listBoxEmails.DoubleClick += new System.EventHandler(this.listBoxEmails_DoubleClick);
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(387, 49);
            this.buttonScan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(81, 21);
            this.buttonScan.TabIndex = 5;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.tabControl1);
            this.panel.Location = new System.Drawing.Point(11, 11);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(647, 341);
            this.panel.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 336);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lblWelcome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.buttonConnect);
            this.groupBox4.Controls.Add(this.textBoxColumn);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBoxTable);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.listBoxEmails);
            this.groupBox4.Controls.Add(this.textBoxConnectionString);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(7, 137);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(619, 166);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Source";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Data";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(302, 123);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(101, 23);
            this.buttonConnect.TabIndex = 14;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textBoxColumn
            // 
            this.textBoxColumn.Location = new System.Drawing.Point(9, 120);
            this.textBoxColumn.Name = "textBoxColumn";
            this.textBoxColumn.ReadOnly = true;
            this.textBoxColumn.Size = new System.Drawing.Size(184, 20);
            this.textBoxColumn.TabIndex = 12;
            this.textBoxColumn.Text = "Mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Column";
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(9, 80);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.ReadOnly = true;
            this.textBoxTable.Size = new System.Drawing.Size(184, 20);
            this.textBoxTable.TabIndex = 10;
            this.textBoxTable.Text = "EmailsItems";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Table";
            // 
            // textBoxConnectionString
            // 
            this.textBoxConnectionString.Location = new System.Drawing.Point(10, 41);
            this.textBoxConnectionString.Name = "textBoxConnectionString";
            this.textBoxConnectionString.ReadOnly = true;
            this.textBoxConnectionString.Size = new System.Drawing.Size(393, 20);
            this.textBoxConnectionString.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Connection String";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxHeadless);
            this.groupBox3.Controls.Add(this.textBoxEmail);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.buttonScan);
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 77);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameters";
            // 
            // checkBoxHeadless
            // 
            this.checkBoxHeadless.AutoSize = true;
            this.checkBoxHeadless.Location = new System.Drawing.Point(10, 49);
            this.checkBoxHeadless.Name = "checkBoxHeadless";
            this.checkBoxHeadless.Size = new System.Drawing.Size(70, 17);
            this.checkBoxHeadless.TabIndex = 2;
            this.checkBoxHeadless.Text = "Headless";
            this.checkBoxHeadless.UseVisualStyleBackColor = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(48, 17);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(313, 20);
            this.textBoxEmail.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "E-mail";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.labelScanning);
            this.groupBox1.Controls.Add(this.progressBarScan);
            this.groupBox1.Controls.Add(this.lblStep);
            this.groupBox1.Location = new System.Drawing.Point(486, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 124);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scan Progress";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Status:";
            // 
            // labelScanning
            // 
            this.labelScanning.AutoSize = true;
            this.labelScanning.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelScanning.Location = new System.Drawing.Point(55, 24);
            this.labelScanning.Name = "labelScanning";
            this.labelScanning.Size = new System.Drawing.Size(21, 13);
            this.labelScanning.TabIndex = 2;
            this.labelScanning.Text = "Off";
            // 
            // progressBarScan
            // 
            this.progressBarScan.Location = new System.Drawing.Point(6, 95);
            this.progressBarScan.Name = "progressBarScan";
            this.progressBarScan.Size = new System.Drawing.Size(128, 23);
            this.progressBarScan.TabIndex = 1;
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(6, 79);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(73, 13);
            this.lblStep.TabIndex = 0;
            this.lblStep.Text = "Ready to start";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonExport);
            this.tabPage2.Controls.Add(this.dataGridViewHistoric);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(573, 3);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(53, 22);
            this.buttonExport.TabIndex = 9;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // dataGridViewHistoric
            // 
            this.dataGridViewHistoric.AllowUserToAddRows = false;
            this.dataGridViewHistoric.AllowUserToDeleteRows = false;
            this.dataGridViewHistoric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoric.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.email,
            this.google,
            this.amazon,
            this.twitter,
            this.facebook,
            this.instagram,
            this.tumblr,
            this.microsoft});
            this.dataGridViewHistoric.Location = new System.Drawing.Point(8, 28);
            this.dataGridViewHistoric.Name = "dataGridViewHistoric";
            this.dataGridViewHistoric.Size = new System.Drawing.Size(618, 282);
            this.dataGridViewHistoric.TabIndex = 8;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 156;
            // 
            // google
            // 
            this.google.HeaderText = "Google";
            this.google.Name = "google";
            this.google.ReadOnly = true;
            this.google.Width = 60;
            // 
            // amazon
            // 
            this.amazon.HeaderText = "Amazon";
            this.amazon.Name = "amazon";
            this.amazon.ReadOnly = true;
            this.amazon.Width = 60;
            // 
            // twitter
            // 
            this.twitter.HeaderText = "Twitter";
            this.twitter.Name = "twitter";
            this.twitter.ReadOnly = true;
            this.twitter.Width = 60;
            // 
            // facebook
            // 
            this.facebook.HeaderText = "Facebook";
            this.facebook.Name = "facebook";
            this.facebook.ReadOnly = true;
            this.facebook.Width = 60;
            // 
            // instagram
            // 
            this.instagram.HeaderText = "Instagram";
            this.instagram.Name = "instagram";
            this.instagram.ReadOnly = true;
            this.instagram.Width = 60;
            // 
            // tumblr
            // 
            this.tumblr.HeaderText = "Tumblr";
            this.tumblr.Name = "tumblr";
            this.tumblr.ReadOnly = true;
            this.tumblr.Width = 60;
            // 
            // microsoft
            // 
            this.microsoft.HeaderText = "Microsoft";
            this.microsoft.Name = "microsoft";
            this.microsoft.ReadOnly = true;
            this.microsoft.Width = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "History";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 361);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PluginForm";
            this.Text = "Foca plugin example";
            this.panel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ListBox listBoxEmails;
        private System.Windows.Forms.Button buttonScan;
        public System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblStep;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxConnectionString;
        private System.Windows.Forms.ProgressBar progressBarScan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxHeadless;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox textBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.Label labelScanning;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewHistoric;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn google;
        private System.Windows.Forms.DataGridViewTextBoxColumn amazon;
        private System.Windows.Forms.DataGridViewTextBoxColumn twitter;
        private System.Windows.Forms.DataGridViewTextBoxColumn facebook;
        private System.Windows.Forms.DataGridViewTextBoxColumn instagram;
        private System.Windows.Forms.DataGridViewTextBoxColumn tumblr;
        private System.Windows.Forms.DataGridViewTextBoxColumn microsoft;
        private System.Windows.Forms.Button buttonExport;
    }
}


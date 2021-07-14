using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocaPlugin
{
	/*Clase que engloba la logica de aplicación sobre las comprobaciones de redes sociales*/
    class RRSSController
    {
        DBAccess dba;
        WebExtractor webex;
        public RRSSController() { }

        public bool checkValidEmail(string email) {
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.CultureInvariant | RegexOptions.Singleline);
            return regex.IsMatch(email);
        }
        public List<String> queryEmails(string connString, string table, string column) {
            this.dba = new DBAccess(connString, table, column);
            List<String> mails = this.dba.getMails();
            return mails;
        }

        public void initScan(bool headless) {
            this.webex = new WebExtractor(headless);
            
        }

        public void closeScan() {
            if (this.webex != null) this.webex.Close();
        }
        public bool GoogleScan(string email) { return this.webex.GoogleScan(email); }
        public bool AmazonScan(string email) { return this.webex.AmazonScan(email); }
        public bool TwitterScan(string email) { return this.webex.TwitterScan(email); }
        public bool FacebookScan(string email) { return this.webex.FacebookScan(email); }
        public bool InstagramScan(string email) { return this.webex.InstagramScan(email); }
        public bool TumblrScan(string email) { return this.webex.TumblrScan(email); }
        public bool MicrosoftScan(string email) { return this.webex.MicrosoftScan(email); }
    }
}

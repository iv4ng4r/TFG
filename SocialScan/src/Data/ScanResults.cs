using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocaPlugin
{
	/*Clase que modela la información sobre las cuentas de usuario encontradas para un correo electronico*/
    class ScanResults
    {
        public string address;
        public ServiceResult google;
        public ServiceResult amazon;
        public ServiceResult facebook;
        public ServiceResult twitter;
        public ServiceResult instagram;
        public ServiceResult tumblr;
        public ServiceResult microsoft;

        public ScanResults(string address)
        {
            this.address = address;
            this.google = new ServiceResult("google");
            this.amazon = new ServiceResult("amazon");
            this.facebook = new ServiceResult("facebook");
            this.twitter = new ServiceResult("twitter");
            this.instagram = new ServiceResult("instagram");
            this.tumblr = new ServiceResult("tumblr");
            this.microsoft = new ServiceResult("microsoft");

        }
        public override string ToString()
        {
            return "Scan results for ["+address+"]...\n\nGoogle:\t\t" + google.value+ "\nAmazon:\t\t" + amazon.value + "\nTwitter:\t\t" + twitter.value + "\nFacebook:\t" + facebook.value + "\nInstagram:\t" + instagram.value + "\nTumblr:\t\t" + tumblr.value + "\nMicrosoft:\t" + microsoft.value;

        }
    }
	/*Clas que modela si un correo electronico dado posee cuenta en un servicio dado*/
    class ServiceResult 
    {
        public string name;
        public bool value;

        public ServiceResult(string name) {
            this.name = name;
            
        }
    }
}

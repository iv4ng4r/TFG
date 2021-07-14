using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;


namespace FocaPlugin
{
	/*Clase encargada de la interaccion con los servicios web de inicio de sesion mediante Selenium*/
    class WebExtractor
    {
        private static string googleUrl = "https://accounts.google.com/o/oauth2/v2/auth/oauthchooseaccount?redirect_uri=https%3A%2F%2Fdevelopers.google.com%2Foauthplayground&prompt=consent&response_type=code&client_id=407408718192.apps.googleusercontent.com&scope=email&access_type=offline&flowName=GeneralOAuthFlow";
        private static string amazonUrl = "https://www.amazon.es/ap/signin?openid.pape.max_auth_age=0&openid.return_to=https%3A%2F%2Fwww.amazon.es%2F%3Fref_%3Dnav_custrec_signin&openid.identity=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.assoc_handle=esflex&openid.mode=checkid_setup&openid.claimed_id=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0%2Fidentifier_select&openid.ns=http%3A%2F%2Fspecs.openid.net%2Fauth%2F2.0&";
        private static string twitterUrl = "https://twitter.com/account/begin_password_reset";
        private static string facebookUrl = "https://www.facebook.com/login/identify/?ctx=recover&ars=facebook_login&from_login_screen=0";
        private static string instagramUrl = "https://www.instagram.com/accounts/login/";
        private static string tumblrUrl = "https://www.tumblr.com/login";
        private static string microsoftUrl = "https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=13&ct=1620152126&rver=7.0.6738.0&wp=MBI_SSL&wreply=https:%2F%2Faccount.microsoft.com%2Fauth%2Fcomplete-signin%3Fru%3Dhttps%253A%252F%252Faccount.microsoft.com%252F%253Frefp%253Dsignedout-index%2526refd%253Dwww.google.com&lc=3082&id=292666&lw=1&fl=easi2";
        
        public IWebDriver driver;
        
        public WebExtractor(bool headless)
        {
            FirefoxOptions fopts = new FirefoxOptions();

            //Headless Support
            if (headless) { fopts.AddArguments("--headless"); }

            var ffds = FirefoxDriverService.CreateDefaultService();
            ffds.HideCommandPromptWindow = true;

            this.driver = new FirefoxDriver(ffds, fopts);
        }
        public void Close()
        {
            this.driver.Close();
        }
        /*Comprobaciones RRSS*/
        
        public bool GoogleScan(string email)
        {
            
            this.driver.Navigate().GoToUrl(googleUrl);

            IWebElement emailInput = this.driver.FindElement(By.Id("identifierId"));
            emailInput.SendKeys(email);
            IWebElement buttonSiguiente = this.driver.FindElement(By.XPath("//*[@jsname='LgbsSe']"));
            buttonSiguiente.Click();

            new WebDriverWait(this.driver, TimeSpan.FromSeconds(5));
            bool result = false;
            try
            {
                //Si no encuentra el unknown mail div, es que la cuenta no existe
                IWebElement unknownDiv = this.driver.FindElement(By.XPath("//div[contains(@class, 'o6cuMc')]"));
                result = false;
                
            }
            catch (NoSuchElementException)
            {
                result = true;
            }
            return result;
        }

        public bool AmazonScan(string email)
        {

            this.driver.Navigate().GoToUrl(amazonUrl);

            IWebElement emailInput = this.driver.FindElement(By.Id("ap_email"));
            emailInput.SendKeys(email);
            IWebElement buttonSiguiente = this.driver.FindElement(By.Id("continue"));
            buttonSiguiente.Click();

            new WebDriverWait(this.driver, TimeSpan.FromSeconds(3));
            bool result = false;
            try
            {
                IWebElement unknownEmailDiv = this.driver.FindElement(By.Id("auth-error-message-box"));

            }
            catch (NoSuchElementException)
            {
                result = true;
            }
            return result;
        }

        public bool TwitterScan(string email)
        {

            this.driver.Navigate().GoToUrl(twitterUrl);

            IWebElement emailInput = this.driver.FindElement(By.XPath("//input[@name='account_identifier']"));
            emailInput.SendKeys(email);
            IWebElement buttonSiguiente = this.driver.FindElement(By.XPath("//input[@type='submit']"));
            buttonSiguiente.Click();

            new WebDriverWait(this.driver, TimeSpan.FromSeconds(5));
            bool result = false;
            try
            {
                IWebElement unknownEmailDiv = this.driver.FindElement(By.XPath("//div[contains(@class, 'PageHeader is-errored')]"));

            }
            catch (NoSuchElementException)
            {
                result = true;
            }
            return result;
        }

        public bool FacebookScan(string email)
        {

            this.driver.Navigate().GoToUrl(facebookUrl);
            new WebDriverWait(this.driver, TimeSpan.FromSeconds(5));
            try
            {
                IWebElement cookieButton = this.driver.FindElement(By.XPath("//button[@data-testid='cookie-policy-dialog-accept-button']"));
                cookieButton.Click();
            }
            catch (NoSuchElementException) { } //Ignorar NoSuchElement si no aparece el popup de cookies

            IWebElement emailInput = this.driver.FindElement(By.Id("identify_email"));
            emailInput.SendKeys(email);
            IWebElement buttonSiguiente = this.driver.FindElement(By.Id("did_submit"));
            buttonSiguiente.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

          
            bool result = false;
            try
            {
                IWebElement pfp = this.driver.FindElement(By.XPath("//img[contains(@class, '_2qgu img')]"));
                result = true;

            }
            catch (NoSuchElementException ex)
            {
                result = false;
                
            }
            return result;
        }

        public bool InstagramScan(string email)
        {

            this.driver.Navigate().GoToUrl(instagramUrl);

            //
            try
            {
                IWebElement cookieButton = this.driver.FindElement(By.XPath("//button[contains(@class, 'aOOlW  bIiDR  ')]"));
                //cookieButton.Click();
                IJavaScriptExecutor ex = (IJavaScriptExecutor)driver;
                ex.ExecuteScript("arguments[0].click();", cookieButton);
            }
            catch (ElementClickInterceptedException) { } //Ignorar ClickIntercepted si no aparece el popup de cookies
            catch (NoSuchElementException) { } //Y NoElement

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            IWebElement emailInput = this.driver.FindElement(By.XPath("//input[@name='username']"));
            emailInput.SendKeys(email);
            IWebElement passwordInput = this.driver.FindElement(By.XPath("//input[@name='password']"));
            passwordInput.SendKeys("asdfasdfasdf");
            IWebElement buttonSiguiente = this.driver.FindElement(By.XPath("//button[@type='submit']"));

            IJavaScriptExecutor ex2 = (IJavaScriptExecutor)driver;
            ex2.ExecuteScript("arguments[0].click();", buttonSiguiente);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);


            bool result = false;
            try
            {
                IWebElement pfp = this.driver.FindElement(By.Id("slfErrorAlert"));
                result = !pfp.Text.Contains("nombre de usuario");
                

            }
            catch (NoSuchElementException ex)
            {
                result = false;

            }
            return result;
        }

        public bool TumblrScan(string email)
        {

            this.driver.Navigate().GoToUrl(tumblrUrl);

            IWebElement emailInput = this.driver.FindElement(By.XPath("//input[@name='email']"));
            emailInput.SendKeys(email);
            IWebElement buttonSiguiente = this.driver.FindElement(By.XPath("//button[@type='submit']"));
            buttonSiguiente.Click();

            new WebDriverWait(this.driver, TimeSpan.FromSeconds(5));
            bool result = false;
            try
            {
                IWebElement unknownEmailDiv = this.driver.FindElement(By.XPath("//div[contains(@class, '_2ByTr')]"));
                result = !unknownEmailDiv.Text.Contains("Tumblr");
            }
            catch (NoSuchElementException)
            {
                result = true;
            }
            return result;
        }

        public bool MicrosoftScan(string email)
        {

            this.driver.Navigate().GoToUrl(microsoftUrl);

            IWebElement emailInput = this.driver.FindElement(By.XPath("//input[@name='loginfmt']"));
            emailInput.SendKeys(email);
            IWebElement buttonSiguiente = this.driver.FindElement(By.XPath("//input[@type='submit']"));
            buttonSiguiente.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            bool result = false;
            try
            {
                IWebElement unknownEmailDiv = this.driver.FindElement(By.Id("usernameError"));
                
            }
            catch (NoSuchElementException)
            {
                result = true;
            }
            return result;
        }
    }
}

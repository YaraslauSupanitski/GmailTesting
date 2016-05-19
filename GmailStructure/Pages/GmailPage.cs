using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailStructure.Pages
{
    public class GMailPage : BasePage
    {
        private IWebElement _fieldForEmail { get; set; }
        private IWebElement _passwordForEmail { get; set; }

        [FindsBy(How = How.Id,Using = "email-display")]
        private IWebElement _checkCorrectEmail;


        public GMailPage() : base()
        {
            driver.Navigate().GoToUrl(TempData.TempDataClass.siteName);
        }



        
        public void EntryEmailAndGoToPasswordPage(string email)
        {
            _fieldForEmail = driver.FindElement(By.Id("Email"));
            _fieldForEmail.SendKeys(email);
            _fieldForEmail.Submit();
            if (!WaitElementIsPresent(_checkCorrectEmail))
            {
                throw new 
            }
        }


        public void EntryPassword(string password)
        {
            _passwordForEmail = driver.FindElement(By.Id("Password"));
            _passwordForEmail.SendKeys(password);
        }





    }
}

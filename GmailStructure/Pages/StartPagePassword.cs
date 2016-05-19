using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailStructure.Pages
{
    public class StartPagePassword : BasePage
    {

        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement FieldForPassword;

        public StartPagePassword() : base(){}

        public void EntryPassword(string password)
        {
            FieldForPassword.SendKeys(password);
        }

        


    }
}

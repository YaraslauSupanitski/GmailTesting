using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailStructure.Pages
{
    public class StartPageEmail : BasePage
    {
        [FindsBy(How = How.Id, Using = "Email")]
        private IWebElement _fieldForEmail;
        public string FieldForEmail { set { _fieldForEmail.SendKeys(value); } }

        public StartPageEmail() : base()
        {
            driver.Navigate().GoToUrl(TempData.TempDataClass.siteName);
        }



        public StartPagePassword goToStartPagePassword()
        {
            if (_fieldForEmail != null)
            {
                _fieldForEmail.Submit();
                return new StartPagePassword();
            }
            else
            {
                throw new FormatException("FieldForEmail = null");
            }
        }

    }
}

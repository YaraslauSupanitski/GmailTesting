using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using GmailStructure.Drivers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GmailStructure.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver driver = SinglonDriver.getDriver();

        public BasePage()
        {
            PageFactory.InitElements(SinglonDriver.getDriver(), this);
        }

        protected bool WaitElementIsPresent(IWebElement WebElement)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(TempData.TempDataClass.TimerForWaiting));
            bool result = false;

            try
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(WebElement));
                result = true;
            }
            catch (TimeoutException e)
            {
                result = false;
            }

            return result;

        }
    }
}

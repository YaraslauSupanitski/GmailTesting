using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailStructure.Drivers
{
    public abstract class SinglonDriver
    {
        private static IWebDriver _driver;

        private SinglonDriver() { }

        public static IWebDriver getDriver()
        {
            if (_driver == null)
                _driver = new FirefoxDriver();
            return _driver;
        }
    }
}

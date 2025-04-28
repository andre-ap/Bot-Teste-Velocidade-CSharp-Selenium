using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Testevelocidade
{
    internal class AutomationWeb
    {
        public IWebDriver driver;

        public AutomationWeb()
        {
            driver = new ChromeDriver();
        }

        public void TestWeb()
        {
            driver.Navigate().GoToUrl("https://google.com");
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProjecy
{
    public class ChromeLauncher : IDisposable
    {
        protected readonly IWebDriver _driver;

        public ChromeLauncher()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        public void Dispose()
        {
            _driver.Dispose();
            _driver.Quit();
        }
    }
}

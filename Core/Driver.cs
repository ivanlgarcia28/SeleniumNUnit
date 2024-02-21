using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Core
{
    public static class Driver
    {
        public enum BrowserTypes
        {
            Chrome
        }
        static IWebDriver _Browser;
        private static IJavaScriptExecutor _JS;
        public static IWebDriver Browser
        {
            get
            {
                if (_Browser == null)
                {
                    throw new NullReferenceException(nameof(Browser));
                }
                return _Browser;
            }
            private set { _Browser = value; }
        }
        public static IJavaScriptExecutor JS
        {
            get
            {
                if (JS == null || _Browser == null)
                {
                    throw new NullReferenceException(nameof(JS));
                }
                return _JS;
            }
            private set { _JS = value; }
        }
        public static void StartBrowser()
        {
            BrowserTypes browserTypes = BrowserTypes.Chrome;
            switch (browserTypes)
            {
                case BrowserTypes.Chrome:
                    InitializeChromeDriver();
                    break;
            }
            Browser.Manage().Window.Maximize();
        }
        public static void StopBrowser()
        {
            Browser.Quit();
            Browser.Dispose();
        }
        public static void InitializeChromeDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(new List<string>()
            {
                "--headless",
                "--incognito"
            });
            Browser = new ChromeDriver(chromeOptions);
        }
    }
}

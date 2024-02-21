using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.Core;

namespace TestProject1.Settings
{
    public abstract class WebPage <TPage>
        where TPage : new()
    {
        private static readonly Lazy<TPage> _lazyPage = new Lazy<TPage>(() => new TPage());
        protected IWebDriver D => Driver.Browser;
        protected IJavaScriptExecutor JS => Driver.JS;

        public static TPage Instance
        {
            get
            {
                return _lazyPage.Value;
            }
        }
    }
}

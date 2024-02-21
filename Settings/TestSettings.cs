using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Configuration;
using TestProject1.Core;

namespace TestProject1.Settings
{
    [SetUpFixture]
    public static class TestSettings
    {
        public static string Url { get; set; }
        public static Driver.BrowserTypes Driver { get; set; }

        [OneTimeSetUp] 
        public static void Setup()
        {
            Url = ConfigurationManager.AppSettings["Url"];
        }
    }
}

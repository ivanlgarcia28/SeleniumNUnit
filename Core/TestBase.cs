using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Core
{
    [TestFixture]
    [FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
    public abstract class TestBase
    {
        [SetUp]
        public void SetUp()
        {
            Driver.StartBrowser();
        }
        [TearDown]
        public void TearDown()
        {
            Driver.StopBrowser();
        }
    }
}

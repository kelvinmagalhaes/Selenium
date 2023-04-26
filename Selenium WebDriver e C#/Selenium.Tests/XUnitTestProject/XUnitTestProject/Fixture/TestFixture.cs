using Alura.LeilaoOnline.Selenium.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.LeilaoOnline.Selenium.Fixture
{
    public class TestFixture:IDisposable
    {
        public IWebDriver Driver { get; set; }


        /// <summary>
        /// Setup
        /// </summary>
        public TestFixture()
        {
            Driver = new ChromeDriver(TestHelpers.PastaDoExecutavel);
        }

        /// <summary>
        /// TearDown- libera navegador
        /// </summary>
        public void Dispose()
        {
            Driver.Quit();
        }
    }
}

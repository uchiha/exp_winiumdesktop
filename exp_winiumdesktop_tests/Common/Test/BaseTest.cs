using exp_winiumdesktop.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Winium;
using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;

namespace exp_winiumdesktop_tests.Common.Test
{
    public class BaseTest
    {
        Process ExecStart;
        protected RemoteWebDriver driver;


        /*
         * Necessary setup for the Beyond Compare desktop app
         * 
         * */
        [SetUp]
        public void SetUpTest()
        {
            String servName = ConfigurationManager.ConnectionStrings["Server"].ConnectionString;
            String appName = ConfigurationManager.ConnectionStrings["AUT"].ConnectionString;

            //Start the Winium desktop driver
            String winiumDriver = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDi‌​rectory, "..\\..\\Common\\executables\\Winium.Desktop.Driver.exe"));
            //Debug.WriteLine(">>>>>>>>>>>> " + winiumDriver);
            ExecStart = Process.Start(winiumDriver);

            //Setup capabilities and invoke the application
            //got a error 20122017:
            //OpenQA.Selenium.WebDriverException : The HTTP request to the remote WebDriver server for URL 
            // http://localhost:9999/session/AwesomeSession/element timed out after 60 seconds.
            //var dc = new DesiredCapabilities();
            //dc.SetCapability("app", @appName);
            //driver = new RemoteWebDriver(new Uri(servName), dc);

            DesktopOptions options = new DesktopOptions();
            options.ApplicationPath = appName;
            DesiredCapabilities dc = (DesiredCapabilities)options.ToCapabilities();
            driver = new RemoteWebDriver(new Uri(servName), dc);

        }

        [TearDown]
        public void TearDownTest()
        {
            //Kill winium desktop driver
            //driver.Quit();
            //ExecStart.Kill();
        }
    }
}

using exp_winiumdesktop.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System.Threading;

namespace exp_winiumdesktop.pages
{
    public class MainWindow : BasePage
    {
        RemoteWebDriver driver;

        public MainWindow(RemoteWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void NewTextCompareSession()
        {
            // Clicks Session -> New Session -> Text Compare
            // In sequence
            Thread.Sleep(2000);  // 20122017, suddenly didn't work without this line.
            Click("Session");
            Click("New Session");
            Click("Text Compare");
        }
    }
}

using exp_winiumdesktop.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System.Threading;

namespace exp_winiumdesktop.pages
{
    public class TextComparePage : BasePage
    {
        RemoteWebDriver driver;

        public TextComparePage(RemoteWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void typeFileNameAndLocLeft(string filename)
        {
            Thread.Sleep(1000);
            //mainWindow().FindElement(By.XPath("/*[contains(@ClassName, 'TUiPanel')]//*[contains(@ClassName,'Edit') and contains(@ControlType, 'ControlType.Pane')][1]")).SendKeys(filename);
            //compareMainWindow().FindElement(By.XPath("/*[contains(@ClassName,'Edit')]"));
            mainWindow().FindElement(By.XPath("//*[contains(@ClassName,'Edit') and contains(@ControlType,'ControlType.Pane')][1]")).SendKeys(filename);
            //compareMainWindow().FindElement(By.XPath("//*[@ClassName='Edit' and @ControlType='ControlType.Pane'][1]")).SendKeys(filename);
            //Type("//*[contains(@Class,'Edit') and contains(@ControlType, 'ControlType.Edit')][0]", filename);
            //Type("//*[contains(@ClassName,'Edit') and contains(@ControlType, 'ControlType.Pane')][1]", filename);   works but very slow...
            //Type("//*[contains(@ClassName,'TUiSpecComboBox') and contains(@ControlType, 'ControlType.Pane')][1]", filename);
            //Type("/*[contains(@ClassName,'TTextCompareViewFrame')]/..//*[contains(@ClassName, 'TUiPanel')]/*[contains(@ClassName,'Edit') and contains(@ControlType, 'ControlType.Pane')][1]", filename);  //takes 21.5 seconds?!?!
            //Type("//pane[contains(@ClassName, 'TUiPanel')][1]/edit[contains(@ClassName,'Edit') and contains(@CKControlType, 'ControlType.Pane')][1]", filename);  //takes 21.5 seconds?!?!

            //Type("//*[contains(@ClassName,'Edit') and contains(@ControlType, 'ControlType.Pane')][1]", filename);  //takes 21.5 seconds?!?!

            //compareMainWindow().FindElement(By.Id("1001")).SendKeys(filename);
            //Thread.Sleep(3000);
            //Console.WriteLine("hehehehehe");
        }
    }
}

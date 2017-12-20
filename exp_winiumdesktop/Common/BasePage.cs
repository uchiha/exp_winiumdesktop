using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace exp_winiumdesktop.Common
{
    public class BasePage
    {
        RemoteWebDriver driver;
        IWebElement mainWindowElement;

        public BasePage(RemoteWebDriver driver)
        {
            this.driver = driver;
        }

        protected IWebElement mainWindow()
        {
            return mainWindowElement = driver.FindElementByClassName("TViewForm");
        }

        protected IWebElement compareMainWindow()
        {
            return mainWindowElement = driver.FindElementByClassName("TTextCompareViewFrame");
        }

        private IWebElement getElementFromMain(string name)
        {
            return mainWindow().FindElement(By.Name(name));
        }

        private IWebElement getElementWithXPath(string xpath)
        {
            return mainWindow().FindElement(By.XPath(xpath));
        }

        //private IReadOnlyCollection<IWebElement> getElementsFromMain(string name)
        //{
        //    return mainWindow().FindElements(By.ClassName(name));
        //}

        protected void Click(string elem)
        {
            if (elem.StartsWith("//"))
                getElementWithXPath(elem).Click();
            else
                getElementFromMain(elem).Click();
        }

        protected void Type(string locator, string text)
        {
            if (locator.StartsWith("//"))
                getElementWithXPath(locator).SendKeys(text);
                //driver.FindElementById("1001").SendKeys(text); this worked!
            else
                getElementFromMain(locator).SendKeys(text);
        }

        
    }
}

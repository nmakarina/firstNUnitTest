using System.Threading;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTestAdme.Core
{
    public class BasePage
    {
        public static void InitPage<T>(T pageClass) where T : BasePage
        {
            PageFactory.InitElements(Driver.DriverInstance, pageClass);
        }


        public static void WaitForElementPresent(By by, int timeOut = 10)
        {
            for (int i = 0; i < timeOut; i++)
            {

                try
                {
                    Driver.DriverInstance.FindElement(by);
                    return;
                }
                catch (NoSuchElementException)
                {
                    Thread.Sleep(1000); 
                }
            }
            throw new NoSuchElementException("Element is not found");
        }


        public static void GoToIndexPage()
        {
            Driver.DriverInstance.FindElement(logoLink).Click();
        }

        private static By logoLink = By.XPath("//img[@alt='AdMe']");
    }
}

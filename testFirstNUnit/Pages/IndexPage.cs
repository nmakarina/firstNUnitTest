using OpenQA.Selenium;
using AutoTestAdme.Core;


namespace AutoTestAdme.Pages
{
    class IndexPage : BasePage
    {

        public IndexPage()
        {
            InitPage(this);
        }


        public static IndexPage GetIndexPage()
        {
            IndexPage indexPage = new IndexPage();
            InitPage(indexPage);
            return indexPage;
        }


        public IndexPage ClickSearchLink()
        {
            WaitForElementPresent(searchLink);
            Driver.DriverInstance.FindElement(searchLink).Click();
            return IndexPage.GetIndexPage();
        }

        //поиск и переход на страницу с результатами поиска
        public SearchPage EnterTextInSearchField(string text)

        {
            WaitForElementPresent(searchField);
            IWebElement sf = Driver.DriverInstance.FindElement(searchField);
            sf.SendKeys(text);
            sf.SendKeys(Keys.Enter);
            return SearchPage.GetSearchPage();
        }


        private By searchLink = By.XPath("//div[@data-test-id='search-icon']");
        private By searchField = By.XPath("//input[@data-test-id='input']");

    }
}

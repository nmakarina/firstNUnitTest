using System;
using System.Linq;
using OpenQA.Selenium;
using AutoTestAdme.Core;
using System.Threading;

namespace AutoTestAdme.Pages
{
    class SearchPage : BasePage
  {

        public SearchPage()
        {
            InitPage(this);
        }


        public static SearchPage GetSearchPage()
        {
            SearchPage searchPage = new SearchPage();
            return searchPage;
        }


        public SearchPage ClickNextPageLink(IWebElement element)
        {
           element.Click();
           return SearchPage.GetSearchPage();
        }

        public ArticlePage ClickArticleLink(IWebElement element)
        {
            element.Click();
            return ArticlePage.GetArticlePage();
        }


        //подсчет количества найденных по запросу статей
        public int GetCountArticles()
        {
            int count = 0;
            try
            {
                WaitForElementPresent(By.XPath("//div[@class='gsc-resultsbox-visible']"));
                WaitForElementPresent(articleLink);
                if (Driver.DriverInstance.FindElements(articleNotFound).Count() == 1)
                {
                    return count;
                }
                WaitForElementPresent(articleLink);
                Thread.Sleep(1000);
                count = Driver.DriverInstance.FindElements(articleLink).Count();

            }
            catch (Exception)
            { }

            return count;
        }


        private By articleLink = By.XPath("//a[@class='gs-title']");
        private By articleNotFound = By.XPath("//div[contains(@class,'gs-no-results-result')]");

    }
}

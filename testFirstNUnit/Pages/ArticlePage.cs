using OpenQA.Selenium;
using AutoTestAdme.Core;

namespace AutoTestAdme.Pages
{
    class ArticlePage: BasePage
  {

        public ArticlePage()
        {
            InitPage(this);
        }

        public static ArticlePage GetArticlePage()
        {
            ArticlePage articlePage = new ArticlePage();
            return articlePage;
        }

        public string GetArticleTitle()
        {
            string aTitle = Driver.DriverInstance.FindElement(articleTitle).Text;
            return aTitle;
        }


        public string GetFirstParagraph()
        {
            string pText = Driver.DriverInstance.FindElement(firstParagraph).Text;
            return pText;
        }

        public string GetFirstImageLink()
        {
            string imgLink = Driver.DriverInstance.FindElement(firstImage).GetAttribute("src");
            return imgLink;
        }

        public void WaitArticlePageLoad()
        {
            WaitForElementPresent(firstParagraph);
        }


        private By articleTitle = By.XPath("//article/h1");
        private By firstParagraph = By.XPath("//article/div/p");
        private By firstImage = By.XPath("//span[@class='article-pic js-article-image ']/img");


    }
}

using System;
using System.Diagnostics;
using NUnit.Framework;
using AutoTestAdme.Pages;

namespace AutoTestAdme.Test
{
    [TestFixture]
    public class Tests : BaseTest
    {
        
        [Test]
        public void Test1()
        {
            //подсчет времени работы скрипта
            //Stopwatch stopWatch = new Stopwatch();
            //stopWatch.Start();

            //переход на главную страницу adme.ru
            IndexPage indexPage = new IndexPage();

            //поиск статей по ключевому слову
            indexPage.ClickSearchLink();
            SearchPage searchPage = indexPage.EnterTextInSearchField("полезный совет");

            //количество найденных статей
            int count = searchPage.GetCountArticles();
            Console.WriteLine(count);

            //окончание времени замера работы скрипта
            //stopWatch.Stop();
            
            Assert.IsTrue(count>0, "ничего не найдено");
        }
    }
}

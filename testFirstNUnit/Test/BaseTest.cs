using System;
using NUnit.Framework;
using AutoTestAdme.Core;

namespace AutoTestAdme.Test
{
    public class BaseTest
    {
        [OneTimeSetUp]
        public static void Init()
        {
            Driver.DriverInstance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.DriverInstance.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public static void Close()
        {
            Driver.Close();
        }

        [SetUp]
        public void Open()
        {
            Driver.DriverInstance.Navigate().GoToUrl("https://www.adme.ru/");
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.DriverInstance.Manage().Cookies.DeleteAllCookies();
        }
    }
}

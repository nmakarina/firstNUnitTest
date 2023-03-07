using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoTestAdme.Core
{
    public class Driver
    {
        private static IWebDriver ?driverInstance;

        private Driver()
        {
        }

        public static IWebDriver DriverInstance
        {
            get
            {
                if (driverInstance == null)
                {
                    //string path = Directory.GetCurrentDirectory();
                    //from PATH
                    driverInstance = new ChromeDriver();

                }
                return driverInstance;
            }
        }




        public static void Close()
        {
            if (driverInstance != null)
            {
                driverInstance.Quit();
                driverInstance = null;
            }
        }
    }
}

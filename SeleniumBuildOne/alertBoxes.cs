using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;


namespace SeleniumBuildOne
{
    class alertBoxes
    {
        static IWebDriver driver = new ChromeDriver();

        //since alerts arent elements we need to use a IAlert instead
        static IAlert alert;
        static void Main()
        {
            string url = "http://testing.todvachev.com/special-elements/alert-box/";


            driver.Navigate().GoToUrl(url);

            //initialising the alert
            alert = driver.SwitchTo().Alert();

            //checking for the text inside of the alert
            Console.WriteLine(alert.Text);

            Thread.Sleep(2000);

            //clicking the alert after initialising it
            alert.Accept();

            driver.Quit();
        }
    }
}


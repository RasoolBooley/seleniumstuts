using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;


namespace SeleniumBuildOne
{
    class dropdownMenus
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement dropdownMain;
        static IWebElement dropdownMerc;

        static void test()
        {
            string url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
            string dropdownOptions = "#post-6 > div > p:nth-child(6) > select";
            string dropOpThree = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";


            driver.Navigate().GoToUrl(url);

            dropdownMain = driver.FindElement(By.CssSelector(dropdownOptions));

            //checking the current selected value
            Console.WriteLine(dropdownMain.GetAttribute("value"));
            
            //once the element is initialised you can call it and use the click function to click it
            dropdownMain.Click();


            //initializing the second option that will be clicked and checked
            dropdownMerc = driver.FindElement(By.CssSelector(dropOpThree));

            dropdownMerc.Click();

            //checking the new selected value
            Console.WriteLine(dropdownMerc.GetAttribute("value"));

            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}


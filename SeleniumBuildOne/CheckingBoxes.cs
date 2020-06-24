using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;


namespace SeleniumBuildOne
{
    class CheckingBoxes
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement checkBox;

        static void test()
        {
            string url = "http://testing.todvachev.com/special-elements/check-button-test-3/";
            
            //initializing the checkbox 
            string optionOne = "#post-33 > div > p:nth-child(8) > input[type=checkbox]:nth-child(1)";

            driver.Navigate().GoToUrl(url);

            checkBox = driver.FindElement(By.CssSelector(optionOne));

            //getting the checkbox value
            Console.WriteLine(checkBox.GetAttribute("value"));

            //checking if the checkbox is checked
            if (checkBox.GetAttribute("checked") == "true")
            {
                Console.WriteLine("Checked");
            } else
            {
                Console.WriteLine("Not checked");
            }

            checkBox.Click();

            //checking if the checkbox is checked after click
            if (checkBox.GetAttribute("checked") == "true")
            {
                Console.WriteLine("Checked");
            }
            else
            {
                Console.WriteLine("Not checked");
            }

            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;


namespace SeleniumBuildOne
{
    class InputtingData
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement textBox;

        static void test()
        {
            string url = "http://testing.todvachev.com/special-elements/text-input-field/";

            driver.Navigate().GoToUrl(url);

            textBox = driver.FindElement(By.Name("username"));

            textBox.SendKeys("Testing");

            Thread.Sleep(3000);

            // The string below "value" will return the inputted value in the text box
            // "maxlength" for example would return the maximum length the input can receive 

            Console.WriteLine(textBox.GetAttribute("value"));

            textBox.Clear();

            Thread.Sleep(3000);

            driver.Quit();
        }
    }
}

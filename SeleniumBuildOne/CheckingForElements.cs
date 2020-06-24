using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;

class CheckingForElements
{
    static void testing()
    {
        string url = "http://testing.todvachev.com/selectors/css-path/";
        string cssPath = "#post-108 > div > fimg";
        string xPath = "//*[@id='post-108']/div/figure/img";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement elementOne;
        IWebElement xPathElement;

        Thread.Sleep(3000);

        try
        {
            elementOne = driver.FindElement(By.CssSelector(cssPath));

            if (elementOne.Displayed)
            {
                Console.WriteLine("cssPath Displayed");
            }            
        }
        catch (NoSuchElementException)
        {
            Console.WriteLine("cssPath Not Displayed");
        } 
        
        try
        {
            xPathElement = driver.FindElement(By.XPath(xPath));

            if (xPathElement.Displayed)
            {
                Console.WriteLine("xPath Displayed");
            }            
        }
        catch (NoSuchElementException)
        {
            Console.WriteLine("xPath Not Displayed");
        }
        driver.Quit();
    }
}


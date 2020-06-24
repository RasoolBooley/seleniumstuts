using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

class BaseThings
{
    static void test()
    {


        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://testing.todorvachev.com");

        Thread.Sleep(3000);  

        driver.Quit();
    }
}

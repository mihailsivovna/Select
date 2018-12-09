
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://aqa.works/xpath-tests");

            var selectElement = driver.FindElement(By.Id("numbers"));
            var numbers = new Select(selectElement);
            numbers.SelectByValue("2");
            //numbers.SelectByText("Four");
           //numbers.SelectByIndex(3);

            Console.ReadKey();
            driver.Quit();
        }
    }




}


using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Select;
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
            driver.Navigate().GoToUrl("http://htmlbook.ru/html/select");

            var character = driver.FindElement(By.Name("select2"));
            var select2 = new SelectByText(character);
            select2.SelectText();
            Thread.Sleep(2000);


            //IWebDriver driver = new ChromeDriver();
            // driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("https://www.facebook.com/");

            //var month = driver.FindElement(By.Id("month"));
            //var month_value = new SelectByValue(month);
            //month_value.SelectValue();


            //var year = driver.FindElement(By.Id("year"));
            //var year_value = new Element(year);
            //year_value.SelectByIndex();


            driver.Quit();




        }

    }
}
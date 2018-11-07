
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

            //IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("http://htmlbook.ru/html/select");

            //var day = driver.FindElement(By.Name("select2"));
            //var select2 = new SelectElement(day);
            //select2.SelectByText("Крыса Лариса");
            //Thread.Sleep(2000);




            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.facebook.com/");

            var month = driver.FindElement(By.Id("month"));
            var month_value = new SelectElement(month);
            month_value.SelectByValue("6");


            var year = driver.FindElement(By.Id("year"));
            var year_value = new SelectElement(year);
            year_value.SelectByIndex(1);
            

            driver.Quit();




        }

    }
}
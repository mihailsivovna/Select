using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select
{
    public class Element
    {
        public IWebElement year;

        public Element(IWebElement year)
        {
            this.year = year;
        }

        public void SelectByIndex()
        {
        
            var year_value = new SelectElement(year);
            year_value.SelectByIndex(1);

        }

      

    }
}


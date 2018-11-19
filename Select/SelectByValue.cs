using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select
{
    public class SelectByValue
    {
        public IWebElement month;

        public SelectByValue(IWebElement month)
        {
            this.month = month;
        }

        public void SelectValue()
        {
            var month_value = new SelectElement(month);
            month_value.SelectByValue("6");
        }



    }
}

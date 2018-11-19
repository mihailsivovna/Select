using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select
{
    public class SelectByText
    {
        public IWebElement text;

        public SelectByText(IWebElement text)
        {
            this.text = text;
        }

        public void SelectText()
        {
            var month_value = new SelectElement(text);
            month_value.SelectByText("Крыса Лариса");
        }



    }
}

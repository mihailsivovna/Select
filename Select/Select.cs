using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Linq;

namespace ConsoleApp
{
    public class Select
    {
       
        private readonly SelectElement _selectelement;
        private readonly IWebElement _element;

        public Select(IWebElement element)
        {
            _selectelement = new SelectElement(element);
            _element = element;
        }

        public IWebElement[] GetOptions()
        {
            return _element.FindElements(By.TagName("option")).ToArray();
        }

        public void SelectByText(string text)
        {
            _selectelement.SelectByText(text);
        }

        public void SelectByValue(string value)
        {

            _selectelement.SelectByValue(value);
            
        }

        internal void SelectByIndex(int index)
        {
            _selectelement.SelectByIndex(index);
        }
    }
}
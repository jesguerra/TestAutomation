using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using NUnit.Framework;

namespace Test_Automation
{
    class SeleniumSetMethods
    {

        //Method Enter Text//

        public static void EnterText(string Element, string Value, string ElementType)
        {
            try
            {
                IWebElement webElement = SeleniumGetMethods.WaitAndFindElement(ElementType, Element);
                webElement.SendKeys(Value);
            }
            catch(Exception ErrorM)
            {
                Utils.WriteLog(ErrorM, Element);
            }
        }


        //Method Click Element

        public static void Click(string element, string elementType, int ValT)
        {
            try
            {
                IWebElement webElement = SeleniumGetMethods.WaitAndFindElement(elementType,element);
                webElement.Click();
                System.Threading.Thread.Sleep(ValT);
            }
            catch(Exception ErrroM)
            {
                Utils.WriteLog(ErrroM, element);
            }

        }



    }
}

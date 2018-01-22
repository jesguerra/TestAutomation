using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;

namespace Test_Automation
{
    class SeleniumGetMethods
    {

        /*
         * Methods Get Selenium
         */

        //Method Wait Find Element//

        public static IWebElement WaitAndFindElement(string elementType, string element)
        {
            By ByElement = FindElement(elementType, element);
          //  Utils.AutoScroll(element, Utils.div);
            return Utils.driver.FindElement(ByElement);
        }

        /*
         * Given a xpath the system search an element into a page, if the element exist, return a list of elements
         */

        public static IList<IWebElement> WaitAndFindElements(string elementType, string element)
        {
            By ByElement = FindElement(elementType, element);
            return Utils.driver.FindElements(ByElement);
        }





        //Method Find And return Element in to form//

        public static By FindElement(string elementType, string element)
        {
            By tempElement = null;
            try
            {
                if (elementType.ToLower() == "id")
                    tempElement = By.Id(element);

                if (elementType.ToLower() == "xpath")
                    tempElement = By.XPath(element);

                if (elementType.ToLower() == "classname")
                    tempElement = By.XPath(element);

                if(elementType.ToLower() == "css")
                    tempElement = By.CssSelector(element);

                WebDriverWait wait = new WebDriverWait(Utils.driver, TimeSpan.FromSeconds(10));
                wait.Until<IWebElement>(d => d.FindElement(tempElement));
            }
            catch (Exception ErrorM)
            {
                Utils.WriteLog(ErrorM, element);
            }
            return tempElement;
        }


        //returns the Value of the field// 
        
        public static string GetValue(string element, string elementType, string attribute)
        {
            try
            {
                IWebElement webElement = WaitAndFindElement(elementType, element);
                if (attribute == "text")
                    return webElement.Text;
                else
                    return webElement.GetAttribute(attribute);
            }
            catch (Exception ErrorM)
            {
                Utils.WriteLog(ErrorM, element);
                return "Element not found";
            }

        }

        
         // Return true/false if the given element is displayed
         
        public static bool DisplayedElement(string element, string elementType)
        {
            try
            {
                IWebElement webElement = WaitAndFindElement(elementType, element);
                return webElement.Displayed;
            }
            catch (Exception ErrorM)
            {
                Utils.WriteLog(ErrorM, element);
                return false;
            }
        }


        /*
        * this method gets the values of the elements
           of the cards
        */

        public static void Count_Elements_Cards(string elementType, string element)
        {
            string lista;

            try
            {
                lista = Utils.CountObjects(elementType, Page_Object_Cruise.Container_Elements_Cruiser());
                IWebElement webElement = WaitAndFindElement(elementType, element);
                Console.WriteLine("Se encontraron un resultado de : " + lista + " Cards Disponibles");

            }
            catch (Exception ErrorM)
            {
                Utils.WriteLog(ErrorM, element);
            }

        }
        //Obtener Titulo//

        public static string Obtener_Titulo(string elementType, string element)
        {
           
            string Titule = SeleniumGetMethods.GetValue(element, elementType, "text");
            return Titule;

        }

        public static string Obtener_DurationTitle(string elementType, string element)
        {
           
            string DurationTitle = SeleniumGetMethods.GetValue(element, elementType, "text");
            return DurationTitle;
        }
        public static string Obtener_SecondText(string elementType, string element)
        {
           
            string Second_Title = SeleniumGetMethods.GetValue(element, elementType, "text");
            return Second_Title;
        }
        public static string Obtener_PriceFrom(string elementType, string element)
        {
           
            string Price_From = SeleniumGetMethods.GetValue(element, elementType, "text");
            return Price_From;
        }
        public static string Obtener_ButtonLearnMore(string elementType, string element)
        {
           
            bool result = SeleniumGetMethods.DisplayedElement(element, elementType);
            return result.ToString();

        }


        //Method Obtener todos los datos//
        /*
        public static void Obtener_TodosDatos(string elementType, string element)
        {

            Console.WriteLine("El titulo del Card 1 es: " + Obtener_Titulo(elementType,Page_Object_Cruise.Card_Title()));
            Console.WriteLine("La duración del CARD 1 es : " + Obtener_DurationTitle(elementType,Page_Object_Cruise.Duration_Title1()));
            Console.WriteLine("El segundo titulo del Card 1 es :" + Obtener_SecondText(elementType,Page_Object_Cruise.Second_Text1()));
            Console.WriteLine("El precio del Card 1 es : " + Obtener_PriceFrom(elementType,Page_Object_Cruise.Price_From()));
            Console.WriteLine("El Boton Learn More del Card 1 Existe ? : " + Obtener_ButtonLearnMore(elementType,Page_Object_Cruise.Button_LearnMore1()));

        }
        */


    }
}

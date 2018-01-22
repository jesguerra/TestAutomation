using OpenQA.Selenium;
using System;
using System.IO;
using System.Configuration;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using NUnit.Framework;

namespace Test_Automation
{

    class Utils
    {
        public static IWebDriver driver { get; set; }
        public static string MessageError { get; private set; }
        public static string div = "content-wrapper";

        /*App config Variables*/

        public static string Browser_Firefox = "Firefox";
        public static string Browser_Chrome = "Chrome";
        public static string Browser_Explorer = "Explorer";
        public static string URL = "https://www.carnival.com/";
        public static string URL2 = "https://www.carnival.com/cruise-search";
        public static int t1 = Convert.ToInt16("1000");
        public static int t2 = Convert.ToInt16("2000");

        //Count Variables for Assert result
        public static int NumAssertPass = 0;
        public static int NumAssertFail = 0;
        public static int NumNotFoudElements = 0;


        public static void Open_Browser(string Browser, string Url)
        {
            if (Browser == "Firefox")
                Utils.driver = new FirefoxDriver();
            if (Browser == "Chrome")
                Utils.driver = new ChromeDriver();
            if (Browser == "Explorer")
                Utils.driver = new InternetExplorerDriver();

            Utils.driver.Url = Url;
          //  Utils.driver.Manage().Window.Maximize();
            Utils.driver.Navigate().GoToUrl(Url);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);

        }


        //Method Display Result//

        public static void DisplayAssertsResults()
        {

            int TotalAsserts = NumAssertPass + NumAssertFail;
            float PassPercent = 100 * NumAssertPass / TotalAsserts;
            float FailPercent = 100 * NumAssertFail / TotalAsserts;

            Console.WriteLine("-------------------------------------------------- Test Result -------------------------------------------------- ");
            Console.WriteLine(" # Asserts PASS: " + NumAssertPass + " -----" + PassPercent + "% ");
            Console.WriteLine(" # Asserts FAIL: " + NumAssertFail + " -----" + FailPercent + "% ");
            Console.WriteLine(" # Asserts Not found Elements: " + NumNotFoudElements);
            Console.WriteLine(" # Asserts TOTAL: " + TotalAsserts);
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------- ");
        }

        //Method Write Log in Console//

        public static void WriteLog(Exception ErrorM, string element)
        {

            //write in console
            Console.WriteLine("------------ Assert Fail ------------ ");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Element not found -->" + TestContext.CurrentContext.Test.MethodName + " ---> " + element, ErrorM.Message);
            Console.WriteLine("-------------------------------------");
        }


        //Method Auto Scroll//
        public static void AutoScroll(string element, string div)
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                IWebElement elementX = driver.FindElement(By.XPath(element));
                js.ExecuteScript("arguments[0].scrollIntoView(true);", elementX);
                js.ExecuteScript("var elmnt = document.getElementById('" + div + "'); elmnt.scrollTop=elmnt.scrollTop-150");
            }
            catch
            {

            }
        }

        /*
         * Validate an Assert show and write a message into the console Log
         */ 

        public static void Asserts(string ScenarioDesc,string ExpectedMessage, string ActualMessage)
        {
            try
            {
                NumAssertPass++;

                if (ScenarioDesc != null)
                {
                    Console.WriteLine("Scenario:" + ScenarioDesc + "");
                    
                }

                //Assert
                Assert.AreEqual(ExpectedMessage, ActualMessage);

                //Write in the message in console//
                Console.WriteLine("Data Time Execution:" + DateTime.Now);
                Console.WriteLine("Assert OK :" + ActualMessage);
            }
            catch(Exception ErrorM)
            {
                NumAssertFail++;

                //Write the message in console

                Console.WriteLine("------------ Assert Fail ------------ ");
                Console.WriteLine("Scenario: " + ScenarioDesc + "");
                Console.WriteLine("TestMethod Failed: " + TestContext.CurrentContext.Test.MethodName);
                Console.WriteLine("Exception Name: " + ErrorM.Message);
                Console.WriteLine("--------------------------------------");
            }

        }

        /*
        * Validate an assert for boolean field.
        * If bool is true, assert its OK
        */
        public static void AssertsBool(string scnearioDesc, bool Exist)
        {
            

            if (Exist)
            {
                NumAssertPass++;
                Console.WriteLine("Data Time Execution:" + DateTime.Now);
                Console.WriteLine(scnearioDesc + " : " + Exist); //Write the messsage in console
                Console.WriteLine("Assert OK");
              //  Console.WriteLine("The Found Value is :" + SeleniumGetMethods.GetValue(Page_Object_Login.ErrorMessageLogin(),"Xpath","text"));
                
            }
            else
            {
                NumAssertFail++;
                //Write the messsage in console
                Console.WriteLine("------------ Assert Fail ------------ ");
                Console.WriteLine("TestMethod Failed: " + TestContext.CurrentContext.Test.MethodName);
                Console.WriteLine(scnearioDesc + " : " + Exist);
                Console.WriteLine("Data Time:" + DateTime.Now);
                Console.WriteLine("-----------------------------------------");

                               
            }
            
        }

        //This Method Count Elements in the Container page//

        public static string CountObjects(string elementType, string element)
        {
            int currentObjects = SeleniumGetMethods.WaitAndFindElements(elementType, element).Count;
            return currentObjects.ToString();
                        
        }

        public static void Text_Start_End_Escenario(string scneario)
        { 
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(scneario);
            Console.WriteLine("--------------------------------------");

        }

    }
}

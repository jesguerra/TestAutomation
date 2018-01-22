using System;
using OpenQA.Selenium;

namespace Test_Automation
{
    class Methods_Test
    {
            /*
             * Method Login
             */
        public static void LogginFail()
        {
           
            try
            {
                Utils.Open_Browser(Utils.Browser_Chrome, Utils.URL);
                SeleniumSetMethods.Click(Page_Object_Login.Loggin(),"Xpath",Utils.t2);
                SeleniumSetMethods.EnterText(Page_Object_Login.Input_Email(),Page_Object_Login.User1,"id");
                SeleniumSetMethods.EnterText(Page_Object_Login.Input_Password(),Page_Object_Login.Password,"id");
                SeleniumSetMethods.Click(Page_Object_Login.Button_Login(),"id",Utils.t2);
                Utils.AssertsBool("Metodo 'Login Faild' valida que el ingreso No sea exitoso y se visualice el mensaje de Error",SeleniumGetMethods.DisplayedElement(Page_Object_Login.ErrorMessageLogin(),"Xpath"));

            }
            catch(Exception ErrorM)
            {
                Console.WriteLine(ErrorM.Message);
            }


        }


        /*
         * this method get The Number the elements available and visible
            of the cards
         */

        public static void Count_Elements_Visible()
        {
            Utils.AssertsBool("Valida que el Contenedor de Cards Se encuentre Visible",SeleniumGetMethods.DisplayedElement(Page_Object_Cruise.Container_Elements_Cruiser(),"Xpath"));
            SeleniumGetMethods.Count_Elements_Cards("Xpath",Page_Object_Cruise.Card_Title());
        }
        
        /*
         * This Method Get All the Values of the Cards that are in the Container Cards 1
         */ 

        public static void Get_Values_Cards()
        {

            Utils.Open_Browser(Utils.Browser_Chrome, Utils.URL2);
            Count_Elements_Visible();
            Console.WriteLine("El titulo del Card 1 es :" + SeleniumGetMethods.Obtener_Titulo("Xpath",Page_Object_Cruise.Card_Title1()));
            Console.WriteLine("La duración del Card 1 es : " + SeleniumGetMethods.Obtener_DurationTitle("Xpath",Page_Object_Cruise.Duration_Title1()));
            Console.WriteLine("El segundo titulo del Card 1 es :" + SeleniumGetMethods.Obtener_SecondText("Xpath",Page_Object_Cruise.Second_Text1()));
            Console.WriteLine("El precio del Card 1 es :"+ SeleniumGetMethods.Obtener_PriceFrom("Xpath",Page_Object_Cruise.Price_From()));
            Console.WriteLine("El Botón 'Learn More' del Card 1 Existe ? :" + SeleniumGetMethods.Obtener_ButtonLearnMore("Xpath",Page_Object_Cruise.Button_LearnMore1()));
            Utils.Text_Start_End_Escenario("Get_Values_Cards");
        }


        /*
         * This Method Get All the Values of the Cards that are in the Container Cards 2
         */

        public static void Get_Values_Cards2()
        {
            Utils.Open_Browser(Utils.Browser_Chrome, Utils.URL2);
            Count_Elements_Visible();
            Console.WriteLine("El titulo del Card 2 es :" + SeleniumGetMethods.Obtener_Titulo("Xpath", Page_Object_Cruise.Card_Title2()));
            Console.WriteLine("La duración del Card 2 es : " + SeleniumGetMethods.Obtener_DurationTitle("Xpath", Page_Object_Cruise.Duration_Title2()));
            Console.WriteLine("El segundo titulo del Card 2 es :" + SeleniumGetMethods.Obtener_SecondText("Xpath", Page_Object_Cruise.Second_Text2()));
            Console.WriteLine("El precio del Card 2 es :" + SeleniumGetMethods.Obtener_PriceFrom("Xpath", Page_Object_Cruise.Price_From2()));
            Console.WriteLine("El Botón 'Learn More' del Card 2 Existe ? :" + SeleniumGetMethods.Obtener_ButtonLearnMore("Xpath", Page_Object_Cruise.Button_LearnMore2()));
            Utils.Text_Start_End_Escenario("Get_Values_Cards2");
        }

        /*
         * This Method Get All the Values of the Cards that are in the Container Cards 3
         */

        public static void Get_Values_Cards3()
        {
            Utils.Open_Browser(Utils.Browser_Chrome, Utils.URL2);
            Count_Elements_Visible();
            Console.WriteLine("El titulo del Card 3 es :" + SeleniumGetMethods.Obtener_Titulo("Xpath", Page_Object_Cruise.Card_Title3()));
            Console.WriteLine("La duración del Card 3 es : " + SeleniumGetMethods.Obtener_DurationTitle("Xpath", Page_Object_Cruise.Duration_Title3()));
            Console.WriteLine("El segundo titulo del Card 3 es :" + SeleniumGetMethods.Obtener_SecondText("Xpath", Page_Object_Cruise.Second_Text3()));
            Console.WriteLine("El precio del Card 3 es :" + SeleniumGetMethods.Obtener_PriceFrom("Xpath", Page_Object_Cruise.Price_From3()));
            Console.WriteLine("El Botón 'Learn More' del Card 3 Existe ? :" + SeleniumGetMethods.Obtener_ButtonLearnMore("Xpath", Page_Object_Cruise.Button_LearnMore3()));
            Utils.Text_Start_End_Escenario("Get_Values_Cards3");
        }

        /*
         * This Method Get All the Values of the Cards that are in the Container Cards 4
         */

        public static void Get_Values_Cards4()
        {
            Utils.Open_Browser(Utils.Browser_Chrome, Utils.URL2);
            Count_Elements_Visible();
            Console.WriteLine("El titulo del Card 4 es :" + SeleniumGetMethods.Obtener_Titulo("Xpath", Page_Object_Cruise.Card_Title4()));
            Console.WriteLine("La duración del Card 4 es : " + SeleniumGetMethods.Obtener_DurationTitle("Xpath", Page_Object_Cruise.Duration_Title4()));
            Console.WriteLine("El segundo titulo del Card 4 es :" + SeleniumGetMethods.Obtener_SecondText("Xpath", Page_Object_Cruise.Second_Text4()));
            Console.WriteLine("El precio del Card 4 es :" + SeleniumGetMethods.Obtener_PriceFrom("Xpath", Page_Object_Cruise.Price_From4()));
            Console.WriteLine("El Botón 'Learn More' del Card 4 Existe ? :" + SeleniumGetMethods.Obtener_ButtonLearnMore("Xpath", Page_Object_Cruise.Button_LearnMore4()));
            Utils.Text_Start_End_Escenario("Get_Values_Cards4");
        }

        /*
         * This Method Get All the Values of the Cards that are in the Container Cards 5
         */

        public static void Get_Values_Cards5()
        {
            Utils.Open_Browser(Utils.Browser_Chrome, Utils.URL2);
            Count_Elements_Visible();
            Console.WriteLine("El titulo del Card 5 es :" + SeleniumGetMethods.Obtener_Titulo("Xpath", Page_Object_Cruise.Card_Title5()));
            Console.WriteLine("La duración del Card 5 es : " + SeleniumGetMethods.Obtener_DurationTitle("Xpath", Page_Object_Cruise.Duration_Title5()));
            Console.WriteLine("El segundo titulo del Card 5 es :" + SeleniumGetMethods.Obtener_SecondText("Xpath", Page_Object_Cruise.Second_Text5()));
            Console.WriteLine("El precio del Card 5 es :" + SeleniumGetMethods.Obtener_PriceFrom("Xpath", Page_Object_Cruise.Price_From5()));
            Console.WriteLine("El Botón 'Learn More' del Card 5 Existe ? :" + SeleniumGetMethods.Obtener_ButtonLearnMore("Xpath", Page_Object_Cruise.Button_LearnMore5()));
            Utils.Text_Start_End_Escenario("Get_Values_Cards5");
        }

        /*
         * This Method Get All the Values of the Cards that are in the Container Cards 6
         */

        public static void Get_Values_Cards6()
        {
           // Utils.Open_Browser(Utils.Browser_Chrome, Utils.URL2);
            Count_Elements_Visible();
            Console.WriteLine("El titulo del Card 6 es :" + SeleniumGetMethods.Obtener_Titulo("Xpath", Page_Object_Cruise.Card_Title6()));
            Console.WriteLine("La duración del Card 6 es : " + SeleniumGetMethods.Obtener_DurationTitle("Xpath", Page_Object_Cruise.Duration_Title6()));
            Console.WriteLine("El segundo titulo del Card 6 es :" + SeleniumGetMethods.Obtener_SecondText("Xpath", Page_Object_Cruise.Second_Text6()));
            Console.WriteLine("El precio del Card 6 es :" + SeleniumGetMethods.Obtener_PriceFrom("Xpath", Page_Object_Cruise.Price_From6()));
            Console.WriteLine("El Botón 'Learn More' del Card 6 Existe ? :" + SeleniumGetMethods.Obtener_ButtonLearnMore("Xpath", Page_Object_Cruise.Button_LearnMore6()));
            Utils.Text_Start_End_Escenario("Get_Values_Cards6");
        }


        /*
         * This Method Get All the Values of the Cards that are in the Container Cards 7
         */

        public static void Get_Values_Cards7()
        {
           // Utils.Open_Browser(Utils.Browser_Chrome, Utils.URL2);
            Count_Elements_Visible();
            Console.WriteLine("El titulo del Card 7 es :" + SeleniumGetMethods.Obtener_Titulo("Xpath", Page_Object_Cruise.Card_Title7()));
            Console.WriteLine("La duración del Card 7 es : " + SeleniumGetMethods.Obtener_DurationTitle("Xpath", Page_Object_Cruise.Duration_Title7()));
            Console.WriteLine("El segundo titulo del Card 7 es :" + SeleniumGetMethods.Obtener_SecondText("Xpath", Page_Object_Cruise.Second_Text7()));
            Console.WriteLine("El precio del Card 7 es :" + SeleniumGetMethods.Obtener_PriceFrom("Xpath", Page_Object_Cruise.Price_From7()));
            Console.WriteLine("El Botón 'Learn More' del Card 7 Existe ? :" + SeleniumGetMethods.Obtener_ButtonLearnMore("Xpath", Page_Object_Cruise.Button_LearnMore7()));
            Utils.Text_Start_End_Escenario("Get_Values_Cards7");
        }


        /*
         * This Method Get All the Values of the Cards that are in the Container Cards 8
         */

        public static void Get_Values_Cards8()
        {
         //   Utils.Open_Browser(Utils.Browser_Chrome, Utils.URL2);
            Count_Elements_Visible();
            Console.WriteLine("El titulo del Card 8 es :" + SeleniumGetMethods.Obtener_Titulo("Xpath", Page_Object_Cruise.Card_Title8()));
            Console.WriteLine("La duración del Card 8 es : " + SeleniumGetMethods.Obtener_DurationTitle("Xpath", Page_Object_Cruise.Duration_Title8()));
            Console.WriteLine("El segundo titulo del Card 8 es :" + SeleniumGetMethods.Obtener_SecondText("Xpath", Page_Object_Cruise.Second_Text8()));
            Console.WriteLine("El precio del Card 8 es :" + SeleniumGetMethods.Obtener_PriceFrom("Xpath", Page_Object_Cruise.Price_From8()));
            Console.WriteLine("El Botón 'Learn More' del Card 8 Existe ? :" + SeleniumGetMethods.Obtener_ButtonLearnMore("Xpath", Page_Object_Cruise.Button_LearnMore8()));
            Utils.Text_Start_End_Escenario("Get_Values_Cards8");
        }









    }



}

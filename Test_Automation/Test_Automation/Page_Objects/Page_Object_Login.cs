using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Automation
{
    class Page_Object_Login
    {
       /*
        * Elements Page Manage
        */

        public static string Loggin()
        {
            //return "ccl_header_expand-login-link";
            return "//*[@id='ccl_header_expand-login-link']";
        }

        /*
         * Elements Page Manage
        */

        // Element Username//
        public static string Input_Email()
        {
            return "username";
        }

        //Element Password//
        public static string Input_Password()
        {
            return "password";
        }

        //Eement Button Login//
        public static string Button_Login()
        {
            return "login";
        }


        //Values for the Page Loggin//

        //Users//
        public static string User1 = "jesguerra";

        //Password
        public static string Password = "123";
        

        //Element , Message Error in the Loggin page //

        public static string ErrorMessageLogin()
        {
            return "//*[@class='validation-summary-errors validation-message error']//span";
        }





    }
}

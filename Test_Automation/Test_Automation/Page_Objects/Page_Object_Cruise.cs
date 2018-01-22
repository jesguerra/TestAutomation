using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Automation
{
    class Page_Object_Cruise
    {
        public static string Container_Elements_Cruiser()
        {
            return "//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']";
        }

        /*
         * Elements Card 1
         */

        public static string Card_Title()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__main-text ng-binding'])";
        }
        public static string Card_Title1()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__main-text ng-binding'])[1]";
        }
        public static string Duration_Title1()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__duration-title-content ng-binding'])[1]";
        }
        public static string Second_Text1()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__secondary-text ng-binding'])[1]";
        }
        public static string Price_From()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//span[contains(.,'159')])[1]";
        }
        public static string Button_LearnMore1()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='vrgf-learn-more'])[1]";
        }

        /*
         * Elments Card 2
         */

        
        public static string Card_Title2()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__main-text ng-binding'])[2]";
        }
        public static string Duration_Title2()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__duration-title-content ng-binding'])[2]";
        }
        public static string Second_Text2()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__secondary-text ng-binding'])[2]";
        }
        public static string Price_From2()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//span[contains(.,'159')])[2]";
        }
        public static string Button_LearnMore2()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='vrgf-learn-more'])[2]";
        }


        /*
         * Elments Card 3
         */


        public static string Card_Title3()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__main-text ng-binding'])[3]";
        }
        public static string Duration_Title3()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__duration-title-content ng-binding'])[3]";
        }
        public static string Second_Text3()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__secondary-text ng-binding'])[3]";
        }
        public static string Price_From3()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//span[contains(.,'1')])[3]";
        }
        public static string Button_LearnMore3()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='vrgf-learn-more'])[3]";
        }



        /*
         * Elments Card 4
         */


        public static string Card_Title4()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__main-text ng-binding'])[4]";
        }
        public static string Duration_Title4()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__duration-title-content ng-binding'])[4]";
        }
        public static string Second_Text4()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__secondary-text ng-binding'])[4]";
        }
        public static string Price_From4()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//span[contains(.,'1')])[4]";
        }
        public static string Button_LearnMore4()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='vrgf-learn-more'])[4]";
        }


        /*
         * Elments Card 5
         */


        public static string Card_Title5()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__main-text ng-binding'])[5]";
        }
        public static string Duration_Title5()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__duration-title-content ng-binding'])[5]";
        }
        public static string Second_Text5()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__secondary-text ng-binding'])[5]";
        }
        public static string Price_From5()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//span[contains(.,'1')])[5]";
        }
        public static string Button_LearnMore5()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='vrgf-learn-more'])[5]";
        }

        /*
         * Elments Card 6
         */


        public static string Card_Title6()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__main-text ng-binding'])[6]";
        }
        public static string Duration_Title6()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__duration-title-content ng-binding'])[6]";
        }
        public static string Second_Text6()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__secondary-text ng-binding'])[6]";
        }
        public static string Price_From6()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//span[contains(.,'1')])[6]";
        }
        public static string Button_LearnMore6()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='vrgf-learn-more'])[6]";
        }


        /*
         * Elments Card 7
         */


        public static string Card_Title7()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__main-text ng-binding'])[7]";
        }
        public static string Duration_Title7()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__duration-title-content ng-binding'])[7]";
        }
        public static string Second_Text7()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__secondary-text ng-binding'])[7]";
        }
        public static string Price_From7()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//span[contains(.,'1')])[7]";
        }
        public static string Button_LearnMore7()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='vrgf-learn-more'])[7]";
        }



        /*
         * Elments Card 8
         */


        public static string Card_Title8()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__main-text ng-binding'])[8]";
        }
        public static string Duration_Title8()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__duration-title-content ng-binding'])[8]";
        }
        public static string Second_Text8()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='cgc-cruise-glance__secondary-text ng-binding'])[8]";
        }
        public static string Price_From8()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//span[contains(.,'1')])[8]";
        }
        public static string Button_LearnMore8()
        {
            return "(//*[@class='vrg-result-item ng-scope vrg-result-item--result vrg-result-item--small']//*[@class='vrgf-learn-more'])[8]";
        }

    }
}

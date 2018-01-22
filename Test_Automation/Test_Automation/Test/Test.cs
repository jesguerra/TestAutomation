using NUnit.Framework;

namespace Test_Automation
{
    class Test
    {
       /*
        public void Inizalizace()
        {
            Utils.Open_Browser(Utils.Browser_Chrome, Utils.URL);
        }
        */
        [TearDown]

        public void CleanUp()
        {
            Utils.driver.Quit();
            Utils.DisplayAssertsResults();
        }

       

        // Escenario 1 Method Login Invalid//
        [Test]
        public static void Login_Invalid()
        {
            Methods_Test.LogginFail();
        }

        //Scenario 2 Method Get Elements Cards Cruiser//
        [Test]
        public static void Scenario_Cards()
        {
            Methods_Test.Get_Values_Cards();
            Methods_Test.Get_Values_Cards2();
            Methods_Test.Get_Values_Cards3();
            Methods_Test.Get_Values_Cards4();
            Methods_Test.Get_Values_Cards5();
            Methods_Test.Get_Values_Cards6();
            Methods_Test.Get_Values_Cards7();
            Methods_Test.Get_Values_Cards8();
        }

    }
}

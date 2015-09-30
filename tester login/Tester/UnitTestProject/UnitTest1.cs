using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Tester;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {

        //Kunna kontrollera om ett användarnamn och lösenordspar är giltigt. Returnerar true eller false.
        [TestMethod]
        public void Control_That_Name_And_Password_Is_Viable_Return_True()
        {
            //Assert 
           //var user = new Tester.Users();
            //var name = user.Name;
            
          Users t = new Users();
          var name = t.Name;
          var password = t.PassWord;
          Assert.IsTrue("Abdullah" == name && "Moreno" == password);

        }

        [TestMethod]
        public void Control_That_Name_And_Password_Is_Viable_Return_False()
        {
            Users t = new Users();
            var name = t.Name;
            var password = t.PassWord;
            Assert.IsFalse("Fakename" == name && "FakeLastName" == password);
        }
    }
}

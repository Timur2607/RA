using Microsoft.VisualStudio.TestTools.UnitTesting;
using RA.Pages;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void LoginIsEmpty()
        {
            var page = new AuthPAge();
            Assert.IsFalse(page.Auth("", "my_car_07"));
            
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Controls;
using RA.Pages;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void AuthTestSuccess()
        {
            var page = new AuthPAge();
            Assert.IsTrue(page.Auth("admin", "admin123"));
            Assert.IsTrue(page.Auth("user1", "password1"));
            Assert.IsTrue(page.Auth("user2", "password2"));
            Assert.IsTrue(page.Auth("manager1", "mng123"));
        }
    }
}

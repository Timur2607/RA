using Microsoft.VisualStudio.TestTools.UnitTesting;
using RA.Pages;
using System;

namespace TestAutorization
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void PasswordIsEmpty()
        {
            var page = new AuthPAge();
            Assert.IsFalse(page.Auth("Timka2607", ""));
        }
    }
}

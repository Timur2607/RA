using Microsoft.VisualStudio.TestTools.UnitTesting;
using RA.Pages;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void AuthTestNegative()
        {
            var page = new AuthPAge();
            Assert.IsFalse(page.Auth("", ""));
            
        }
    }
}

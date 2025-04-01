using Microsoft.VisualStudio.TestTools.UnitTesting;
using RA.Pages;
using System;

namespace TestAutorization
{
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void UserNotExist()
        {

            var page = new AuthPAge();
            Assert.IsFalse(page.Auth("ramazotti", "italyan_music12"));


        }
    }
}

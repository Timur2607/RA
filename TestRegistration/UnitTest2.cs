using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RA.Pages;

namespace TestRegistration
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Создание экземпляра класса RegPage
            RA.Pages.RegPage regPage = new RA.Pages.RegPage();

            // Входные данные для теста
            string fio = "";
            string login = "";
            string password = ""; // Должен быть на английском и содержать цифры
            string gender = "";
            string role = "";
            string phoneNumber = ""; // Должен соответствовать формату +7XXXXXXXXXX
            string photo = "";

            // Вызов метода Reg и проверка результата
            bool result = regPage.Reg(fio, login, password, gender, role, phoneNumber, photo);

            // Утверждение: метод должен вернуть true при успешной регистрации
            Assert.IsFalse(result, "Регистрация должна быть успешной с корректными данными");
        }
    }
}

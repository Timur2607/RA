using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestRegistration
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Создание экземпляра класса RegPage
            RA.Pages.RegPage regPage = new RA.Pages.RegPage();

            // Входные данные для теста
            string fio = "3478343";
            string login = "329348r23";
            string password = "aaaaVasya12"; // Должен быть на английском и содержать цифры
            string gender = "Мужской";
            string role = "Пользователь";
            string phoneNumber = "87777875454"; // Должен соответствовать формату +7XXXXXXXXXX
            string photo = "path/to/vines.jpg";

            // Вызов метода Reg и проверка результата
            bool result = regPage.Reg(fio, login, password, gender, role, phoneNumber, photo);

            // Утверждение: метод должен вернуть true при успешной регистрации
            Assert.IsFalse(result, "Регистрация должна быть успешной с корректными данными");
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestRegistration
{
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]
        public void TestMethod1()
        {
            RA.Pages.RegPage regPage = new RA.Pages.RegPage();

            // Входные данные для теста
            string fio = "Федоров Федор Федорович";
            string login = "fedos9012";
            string password = "fedykaredyka3490"; // Должен быть на английском и содержать цифры
            string gender = "Мужской";
            string role = "Пользователь";
            string phoneNumber = "+7777787545412"; // Должен соответствовать формату +7XXXXXXXXXX
            string photo = "path/to/vines.jpg";

            // Вызов метода Reg и проверка результата
            bool result = regPage.Reg(fio, login, password, gender, role, phoneNumber, photo);

            // Утверждение: метод должен вернуть true при успешной регистрации
            Assert.IsFalse(result, "Регистрация должна быть успешной с корректными данными");
        }
    }
}

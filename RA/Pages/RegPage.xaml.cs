using RA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RA.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();

            btnRegister.Click += btnRegister_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            

            Reg(fio.Text, txtLogin.Text, txtPassword.Text, txtGender.Text, txtRole.Text, txtPhone.Text, txtPhotoUrl.Text);
        }



        public bool Reg(string FIO, string Login, string Password, string Gender, string Role, string PhoneNumber, string Photo)
        {
            // Валидация данных
            if (string.IsNullOrWhiteSpace(Login) ||
                string.IsNullOrWhiteSpace(Password) ||
                string.IsNullOrWhiteSpace(FIO) ||
                string.IsNullOrWhiteSpace(Gender) ||
                string.IsNullOrWhiteSpace(Role) ||
                string.IsNullOrWhiteSpace(PhoneNumber) ||
                string.IsNullOrWhiteSpace(Photo))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }

            // Проверка пароля
            bool containsEnglish = Password.Any(c => (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'));
            bool containsNumber = Password.Any(char.IsDigit);

            var regex = new Regex(@"^\+7\d{10}$");

            StringBuilder errors = new StringBuilder();

            if (Password.Length <= 6) errors.AppendLine("Пароль должен быть больше 6 символов");
            if (!regex.IsMatch(PhoneNumber)) errors.AppendLine("Укажите номер телефона в формате +7XXXXXXXXXX");
            if (!containsEnglish) errors.AppendLine("Пароль должен быть на английском языке");
            if (!containsNumber) errors.AppendLine("Пароль должен содержать хотя бы одну цифру");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return false;
            }

            using (var db = new UsersEntities())
            {
                // Проверка существующего пользователя
                if (db.User.Any(u => u.Login == Login))
                {
                    MessageBox.Show("Пользователь с такими данными уже существует!");
                    return false;
                }

                // Создание нового пользователя
                User userObject = new User
                {
                    FIO = FIO,
                    Login = Login,
                    Password = Password,
                    Gender = Gender,
                    Role = Role,
                    PhoneNumber = PhoneNumber,
                    Photo = Photo
                };

                db.User.Add(userObject);
                db.SaveChanges();
            }

            MessageBox.Show("Вы успешно зарегистрировались!", "Успешно!", MessageBoxButton.OK);
            this.NavigationService.Navigate(new AuthPAge());

            return true;
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {

        }








    }
}

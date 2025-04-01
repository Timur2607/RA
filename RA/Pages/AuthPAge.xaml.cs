    using RA.Pages;
using RA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPAge : Page
    {
        public AuthPAge()
        {
            InitializeComponent();
        }

        private void RegisterLink_Click(object sender, RoutedEventArgs e)
        {
            // Переход на страницу регистрации
            NavigationService?.Navigate(new RegPage());
        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            Auth(loginText.Text, txtPassword.Text);
        }


        public bool Auth(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Введите логин и пароль!");
                return false;

            }


            using (var db = new UsersEntities())
            {
                // Находим пользователя по логину и паролю
                var user = db.User.AsNoTracking().FirstOrDefault(u => u.Login == login && u.Password == password);

                if (user == null)
                {
                    MessageBox.Show("Пользователь с такими данными не найден!");
                    return false;
                }


                MessageBox.Show("Пользователь успешно найден!");
                loginText.Clear();
                txtPassword.Clear();
                return true;






                // Закрываем текущее окно

            }

            

        }
        
    }
}

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
using System.Windows.Shapes;

namespace FullTilt.Views
{
    /// <summary>
    /// Логика взаимодействия для LoginView1.xaml
    /// </summary>
    public partial class LoginView1 : Window
    {
        public LoginView1()
        {
            InitializeComponent();
        }
        private void Join_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Login.Text) && !string.IsNullOrWhiteSpace(Password.Password))
            {
                var item = App.Entities.users.Where(x => x.Login == Login.Text && x.Password == Password.Password).FirstOrDefault();
                if (item != null)
                {
                    var window = new AdminMenuView();
                    window.Show();
                    Close();
                }


                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
            }
            else
            {
                MessageBox.Show("Что-то пошло не так...");
            }
        }
    }
}

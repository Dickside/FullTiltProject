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
    /// Логика взаимодействия для UsersAddView.xaml
    /// </summary>
    public partial class UsersAddView : Window
    {
        bool _isEdit;
        Models.users _user = new Models.users();
        public UsersAddView(Models.users user)
        {
            InitializeComponent();
            if (user == null)
            {
                _isEdit = false;
                Title = "Добавление";
            }
            else
            {
                _isEdit = true;
                Title = "Редактирование";
                _user = user;
            }
            grid1.DataContext = _user;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_isEdit == false)
                {
                    App.Entities.users.Add(_user);
                }
                App.Entities.SaveChanges();
                MessageBox.Show("Успешно");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("что-то пошло не так.");
            }
        }
    }
}

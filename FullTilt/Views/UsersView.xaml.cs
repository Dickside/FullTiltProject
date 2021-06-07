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
    /// Логика взаимодействия для UsersView.xaml
    /// </summary>
    public partial class UsersView : Window
    {
        public UsersView()
        {
            InitializeComponent();
            
            
        }
        void Refresh()
        {
            usersDataGrid.DataContext = App.Entities.users.ToList();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

           
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var window = new UsersAddView(null);
            window.ShowDialog();
            Refresh();
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            var item = usersDataGrid.SelectedItem as Models.users;
            if (item == null)
            {
                return;
            }
            var window = new UsersAddView(item);
            window.ShowDialog();
            Refresh();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var item = usersDataGrid.SelectedItem as Models.users;
            if (item==null)
            {
                return;
            }
            App.Entities.users.Remove(item);
            App.Entities.SaveChanges();
            Refresh();
        }
    }
}

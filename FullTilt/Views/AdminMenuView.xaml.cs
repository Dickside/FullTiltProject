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
    /// Логика взаимодействия для AdminMenuView.xaml
    /// </summary>
    public partial class AdminMenuView : Window
    {
        public AdminMenuView()
        {
            InitializeComponent();
        }

        private void Service_Click(object sender, RoutedEventArgs e)
        {
            var window = new ServiceListView();
            window.Show();
            Close();
        }

        private void Users_Click(object sender, RoutedEventArgs e)
        {
            var window = new UsersView();
            window.Show();
            Close();
        }
    }
}

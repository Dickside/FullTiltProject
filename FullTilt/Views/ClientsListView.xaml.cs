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
    /// Логика взаимодействия для ClientsListView.xaml
    /// </summary>
    public partial class ClientsListView : Window
    {
        public ClientsListView()
        {
            InitializeComponent();

        }
        void Refresh()
        {
            clientDataGrid.DataContext = App.Entities.Client.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var window = new ClientAddView(null);
            window.ShowDialog();
            Refresh();
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            var item = clientDataGrid.SelectedItem as Models.Client;
            if (item == null)
            {
                return;
            }
            var window = new ClientAddView(item);
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var item = clientDataGrid.SelectedItem as Models.Client;
            if (item == null)
            {
                return;
            }
            App.Entities.Client.Remove(item);
            App.Entities.SaveChanges();
            Refresh();
        }
        

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void SearchComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}

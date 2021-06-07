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
    /// Логика взаимодействия для ServiceListView.xaml
    /// </summary>
    public partial class ServiceListView : Window
    {
        public ServiceListView()
        {
            InitializeComponent();
            serviceDataGrid.DataContext = App.Entities.Service.ToList();
        }
        void Refresh()
        {
            serviceDataGrid.DataContext = App.Entities.Service.ToList();
        }
        void FiltrationMethod()
        {
            var service = App.Entities.Service.AsQueryable();
            switch (SearchComboBox.SelectedIndex)
            {
                case 1:
                    service = service.Where(x => x.Discount >= 0 && x.Discount < 5);
                    break;
                case 2:
                    service = service.Where(x => x.Discount >= 5 && x.Discount < 15);
                    break;
                case 3:
                    service = service.Where(x => x.Discount >= 15 && x.Discount < 30);
                    break;
                case 4:
                    service = service.Where(x => x.Discount >= 30 && x.Discount < 70);
                    break;
                case 5:
                    service = service.Where(x => x.Discount >= 70 && x.Discount <= 100);
                    break;
            }
        }



        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            var window = new ServiceAddView(null);
            window.ShowDialog();
            Refresh();
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FiltrationMethod();
        }

        private void SearchComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FiltrationMethod();
        }
    }
}

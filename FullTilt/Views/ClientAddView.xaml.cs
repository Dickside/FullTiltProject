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
    /// Логика взаимодействия для ClientAddView.xaml
    /// </summary>
    public partial class ClientAddView : Window
    {
        bool _isEdit;
        Models.Client _client = new Models.Client();
        public ClientAddView(Models.Client client)
        {
            InitializeComponent();
            if (client == null)
            {
                _isEdit = false;
                Title = "Добавление";
            }
            else
            {
                _isEdit = true;
                Title = "Редактирование";
                _client = client;
            }
            grid1.DataContext = _client;
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
                    App.Entities.Client.Add(_client);
                }
                App.Entities.SaveChanges();
                MessageBox.Show("GAVNO");
                Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Что-то пошло не так, проверьте заполнение полей");
            }
        }
    }
}

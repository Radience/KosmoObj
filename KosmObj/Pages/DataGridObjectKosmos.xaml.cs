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

namespace KosmObj.Pages
{
    /// <summary>
    /// Логика взаимодействия для DataGridObjectKosmos.xaml
    /// </summary>
    public partial class DataGridObjectKosmos : Page
    {
        public DataGridObjectKosmos()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainMenu());
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Redactor());
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Redactor());
        }
    }
}

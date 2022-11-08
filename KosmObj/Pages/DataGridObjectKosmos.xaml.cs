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
using System.Data;
using System.Data.SqlClient;

namespace KosmObj.Pages
{
    /// <summary>
    /// Логика взаимодействия для DataGridObjectKosmos.xaml
    /// </summary>
    public partial class DataGridObjectKosmos : Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=RADIANCE\SQLEXPRESS;Initial Catalog=kosmoObj;Integrated Security=True");
        public DataGridObjectKosmos()
        {
            InitializeComponent();
            LoadGrid();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainMenu());
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView row = lstbox.SelectedItem as DataRowView;
                NavigationService.Navigate(new Redactor(row));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("УДАЛИТЬ?", "ВНИМАНИЕ", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                DataRowView row = lstbox.SelectedItem as DataRowView;
                string id = row.Row.ItemArray[0].ToString();
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"DELETE FROM Planet WHERE id_planet = '{id}'", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("УДАЛЕНИЕ ЗАВЕРШЕНО", "ВНИМАНИЕ", MessageBoxButton.OK, MessageBoxImage.Information);
                    con.Close();
                    LoadGrid();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NavigationService.Navigate(new Redactor(null));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand($"SELECT id_planet, photo_planet, name_planet, name_kategory FROM Planet, kategory_planet WHERE Planet.id_kategory = kategory_planet.id_kategory ORDER BY name_planet ASC", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            lstbox.ItemsSource = dt.DefaultView;
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand($"SELECT id_planet, photo_planet, name_planet, name_kategory FROM Planet, kategory_planet WHERE Planet.id_kategory = kategory_planet.id_kategory and name_planet LIKE '{search.Text + "%"}'", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                lstbox.ItemsSource = dt.DefaultView;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Kategory_object_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (Kategory_object.SelectedIndex == 1) //gas
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"SELECT id_planet, photo_planet, name_planet, name_kategory FROM Planet, kategory_planet WHERE Planet.id_kategory = kategory_planet.id_kategory and kategory_planet.name_kategory = 'Газовые'", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    lstbox.ItemsSource = dt.DefaultView;
                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (Kategory_object.SelectedIndex == 2) //karlik
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"SELECT id_planet, photo_planet, name_planet, name_kategory FROM Planet, kategory_planet WHERE Planet.id_kategory = kategory_planet.id_kategory and kategory_planet.name_kategory = 'Карликовые'", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    lstbox.ItemsSource = dt.DefaultView;
                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(Kategory_object.SelectedIndex == 3) //led
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"SELECT id_planet, photo_planet, name_planet, name_kategory FROM Planet, kategory_planet WHERE Planet.id_kategory = kategory_planet.id_kategory and kategory_planet.name_kategory = 'Ледяные'", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    lstbox.ItemsSource = dt.DefaultView;
                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else //all
            {
                try
                {
                    LoadGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

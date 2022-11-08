using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
    /// Логика взаимодействия для Redactor.xaml
    /// </summary>
    public partial class Redactor : Page
    {
        int a = 4;
        int b;
        DataRowView row2;
        string filepath = "";
        string namefile = "";
        string endfilepath = "";
        string sourcefilepath = @"C:\Users\Radiance\source\repos\KosmObj\Resources\";
        List<string> str = new List<string>();
        SqlConnection con = new SqlConnection(@"Data Source=RADIANCE\SQLEXPRESS;Initial Catalog=kosmoObj;Integrated Security=True");
        public Redactor(DataRowView row)
        {
                row2 = row;
                InitializeComponent();
                Kategory_object.Visibility = Visibility.Hidden;
                if (row != null)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        str.Add(row.Row.ItemArray[i].ToString());
                    }
                    name_planet.Text = str[2];
                    photoT.Source = BitmapFrame.Create(new Uri(str[1]));
                }
                else
                {
                    SqlCommand cmd = new SqlCommand($"SELECT MAX(Planet.id_planet) FROM Planet", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    b = Convert.ToInt32(dt.Rows[0].ItemArray[0]) + 1;
                    Kategory_object.Visibility = Visibility.Visible;
                }
            }

        private void LOADPIC_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            bool? result = dialog.ShowDialog();
            if (result == true)
            {
                filepath = dialog.FileName;
                namefile = dialog.SafeFileName;
                sourcefilepath += namefile;
                endfilepath = sourcefilepath;
                photoT.Source = BitmapFrame.Create(new Uri(filepath));
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DataGridObjectKosmos());
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (Check() == "2")
            {
                MessageBox.Show("ЗАПОЛНИТЕ ПОЛЯ!", "ОШИБКА", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (Check() == "1")
            {
                if (row2 != null)
                {
                    try
                    {
                        if(str[3] == "Газовые")
                        {
                            a = 1;
                        }
                        else if (str[3] == "Карликовые")
                        {
                            a = 2;
                        }
                        else if (str[3] == "Ледяные")
                        {
                            a = 3;
                        }
                        File.Copy(filepath, endfilepath, true);
                        con.Open();
                        SqlCommand cmd = new SqlCommand($"UPDATE Planet SET name_planet = '{name_planet.Text}', id_kategory = '{a}', photo_planet = '{endfilepath}'" +
                                                        $"WHERE id_planet = '{str[0]}'", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        if (MessageBox.Show("ИЗМЕНЕНИЯ СОХРАНЕНЫ", "ВНИМАНИЕ", MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                            NavigationService.Navigate(new DataGridObjectKosmos());
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
                else
                {
                    try
                    {
                        if (Kategory_object.SelectedItem.ToString() == "Газовые")
                        {
                            a = 1;
                        }
                        else if (Kategory_object.SelectedItem.ToString() == "Карликовые")
                        {
                            a = 2;
                        }
                        else if (Kategory_object.SelectedItem.ToString() == "Ледяные")
                        {
                            a = 3;
                        }
                        File.Copy(filepath, endfilepath, true);
                        con.Open();
                        SqlCommand cmd = new SqlCommand($"INSERT INTO Planet (id_planet, name_planet, photo_planet, id_kategory) VALUES ('{b}', '{name_planet.Text}', '{photoT.Source}', '{a}')", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        con.Close();
                        if (MessageBox.Show("ИЗМЕНЕНИЯ СОХРАНЕНЫ", "ВНИМАНИЕ", MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                            NavigationService.Navigate(new DataGridObjectKosmos());
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
        }

        public string Check()
        {
            if (name_planet.Text == "")
            {
                name_planet.BorderBrush = Brushes.Red;
                return "2";
            }
            if (photoT.Source == null)
            {
                border.BorderBrush = Brushes.Red;
                return "2";
            }
            return "1";
        }
    }
}

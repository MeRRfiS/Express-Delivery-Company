using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Express_Delivery
{
    /// <summary>
    /// Логика взаимодействия для WatchClient.xaml
    /// </summary>
    public partial class WatchClient : Window
    {
        private static string connectString = "SERVER=localhost;DATABASE=expressdeliverycompany;UID=root;PASSWORD=MeRRFiS2002;";
        private string index;

        private MySqlConnection connection;

        private MySqlCommand client;
        private MySqlCommand clientSearch;
        private MySqlCommand clientName;
        private MySqlCommand clientDelete;

        private MySqlDataAdapter adapterClient;

        private DataTable dt = new DataTable();

        public WatchClient()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectString);
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Return_Click(object sender, RoutedEventArgs e)
        {
            connection.Open();
            EmployeeMenu employeeMenu = new EmployeeMenu();
            AdminMenu adminMenu = new AdminMenu();
            if (MainWindow.namePostEmployee == "Касир")
            {
                employeeMenu.Show();
                employeeMenu.nameEmployee.Text = EmployeeMenu.nameEmloyee;
                Hide();
            }
            else
            {
                adminMenu.Show();
                adminMenu.nameEmployee.Text = AdminMenu.nameEmloyee;
                Hide();
            }
            connection.Close();
        }

        private void dataGridClient_Loaded(object sender, RoutedEventArgs e)
        {
            connection.Open();
            client = new MySqlCommand("SELECT client_id,client_first_name,client_last_name,client_pasport,client_adress,client_tel FROM client_ ORDER BY 1", connection);
            adapterClient = new MySqlDataAdapter(client);
            adapterClient.Fill(dt);
            dataGridClient.ItemsSource = dt.DefaultView;
            connection.Close();
        }

        private void Button_Edit_Click(object sender, RoutedEventArgs e)
        {
            dataGridClient.IsReadOnly = false;
            buttonEdit.Visibility = Visibility.Collapsed;
            buttonSave.Visibility = Visibility.Visible;
        }

        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {
            clientSearch = new MySqlCommand($@"SELECT client_id, client_first_name,
                                            client_last_name,
                                            client_pasport,
                                            client_adress,
                                            client_tel
                                            FROM client_
                                            WHERE client_first_name LIKE('{textBoxName.Text}%') and
                                            client_last_name LIKE('{textBoxSurname.Text}%') and
                                            client_pasport LIKE('{textBoxPasport.Text}%') and
                                            client_adress LIKE('{textBoxAdress.Text}%')
                                            Order by 1; ", connection);
            adapterClient = new MySqlDataAdapter(clientSearch);
            dt.Clear();
            adapterClient.Fill(dt);
            dataGridClient.DataContext = dt;
        }

        private void button_Save_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommandBuilder cmdb = new MySqlCommandBuilder(adapterClient);
            adapterClient.Update(dt);
            dataGridClient.IsReadOnly = true;
            buttonEdit.Visibility = Visibility.Visible;
            buttonSave.Visibility = Visibility.Collapsed;
        }
    }
}

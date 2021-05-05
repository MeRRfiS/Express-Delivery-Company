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
using FastReport;
using MySql.Data.MySqlClient;

namespace Express_Delivery
{
    /// <summary>
    /// Логика взаимодействия для AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        public static string nameEmloyee;
        private static string connectString = "SERVER=localhost;DATABASE=expressdeliverycompany;UID=root;PASSWORD=MeRRFiS2002;";
        
        private Report report = new Report();
        
        private MySqlConnection connection;

        private MySqlCommand order;

        private DataSet ds = new DataSet();

        private MySqlDataAdapter adapterMin;

        public AdminMenu()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectString);
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Watch_Order_Click(object sender, RoutedEventArgs e)
        {
            WatchOrder watchOrder = new WatchOrder();
            watchOrder.Show();
            Hide();
        }

        private void Button_Watch_Client_Click(object sender, RoutedEventArgs e)
        {
            WatchClient watchClient = new WatchClient();
            watchClient.Show();
            Hide();
        }

        private void Button_Watch_Employee_Click(object sender, RoutedEventArgs e)
        {
            WatchEmployee watchEmployee = new WatchEmployee();
            watchEmployee.Show();
            Hide();
        }

        private void Button_Create_Report_Click(object sender, RoutedEventArgs e)
        {
            //connection.Open();
            //order = new MySqlCommand("SELECT * FROM order_ ORDER BY 1", connection);
            //adapterMin = new MySqlDataAdapter(order);
            //adapterMin.Fill(ds, "orders");
            //report.RegisterData(ds);
            //report.Load("Orders.frx");
            //report.Show();
            //connection.Close();
        }

        private void Button_Add_Employee_Click(object sender, RoutedEventArgs e)
        {
            NewEmployee newEmployee = new NewEmployee();
            newEmployee.Show();
            Hide();
        }
    }
}

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

        private MySqlCommand dateCheck;

        private DataSet ds = new DataSet();

        private DataTable dt = new DataTable();

        private MySqlDataAdapter adapterMin;
        private MySqlDataAdapter adapterDepId;

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
            adapterDepId = new MySqlDataAdapter(MainWindow.departmentNumber);
            adapterDepId.Fill(dt);
            connection.Open();
            dateCheck = new MySqlCommand($@"SELECT order_id,
                                    order_date_receiving,
                                    order_date_end,
                                    IFNULL(order_tel_client, (SELECT client_tel FROM client_ WHERE client_id = order_client_id)) as 'client_tel',
                                    IFNULL(order_fine, '0 грн') as 'order_fine'
                                    FROM order_
                                    WHERE order_place = 'У місті отримання' AND
                                    order_date_end <= '2021-05-08' AND
                                    (SELECT department_id FROM department WHERE order_department_number = department_number and order_city_id = department_city_id) = {dt.Rows[0]["department_id"]};", connection);
            adapterMin = new MySqlDataAdapter(dateCheck);
            adapterMin.Fill(ds, "dateChecks");
            report.RegisterData(ds);
            report.Load("DateCheck.frx");
            report.Show();
            connection.Close();
        }

        private void Button_Add_Employee_Click(object sender, RoutedEventArgs e)
        {
            NewEmployee newEmployee = new NewEmployee();
            newEmployee.Show();
            Hide();
        }
    }
}

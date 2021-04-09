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
    /// Логика взаимодействия для NewEmployee.xaml
    /// </summary>
    public partial class NewEmployee : Window
    {
        private static string connectString = "SERVER=localhost;DATABASE=expressdeliverycompany;UID=root;PASSWORD=MeRRFiS2002;";

        private MySqlConnection connection;

        private MySqlDataAdapter adapterAddEmployee;

        private DataTable dt = new DataTable();

        private MySqlCommand postName;
        private MySqlCommand departmentNumber;

        public NewEmployee()
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
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            adminMenu.nameEmployee.Text = EmployeeMenu.nameEmloyee;
            Hide();
        }
    }
}

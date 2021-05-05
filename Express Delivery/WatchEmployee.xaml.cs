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
    /// Логика взаимодействия для WatchEmployee.xaml
    /// </summary>
    public partial class WatchEmployee : Window
    {
        private static string connectString = "SERVER=localhost;DATABASE=expressdeliverycompany;UID=root;PASSWORD=MeRRFiS2002;";
        private string index;

        private MySqlConnection connection;

        private MySqlDataAdapter adapterEmployee;
        private MySqlDataAdapter adapterDepId;

        private DataTable dt = new DataTable();

        private MySqlCommand employee;
        private MySqlCommand employeePost;
        private MySqlCommand employeeName;
        private MySqlCommand employeeSearch;
        private MySqlCommand employeeDelete;

        public WatchEmployee()
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

        private void dataGridEmployee_Loaded(object sender, RoutedEventArgs e)
        {
            connection.Open();
            switch (MainWindow.namePostEmployee)
            {
                case "Адміністратор відділення":
                    adapterDepId = new MySqlDataAdapter(MainWindow.departmentNumber);
                    adapterDepId.Fill(dt);
                    employee = new MySqlCommand($@"SELECT employee_id,
                                                employee_first_name,
                                                employee_last_name,
                                                (SELECT department_number FROM department
                                                WHERE department_id = employee_department_id ORDER BY 1 LIMIT 1) AS 'departmentNumber',
                                                employee_tel,
                                                (SELECT post_name FROM post
                                                WHERE post_id = employee_post_id ORDER BY 1 LIMIT 1) AS 'postName'
                                                FROM employee
                                                WHERE employee_department_id = {dt.Rows[0]["department_id"]};", connection);
                    break;
                case "Директор областної філії":
                    employee = new MySqlCommand($@"SELECT employee_id,
                                                employee_first_name,
                                                employee_last_name,
                                                (SELECT department_number FROM department
                                                WHERE department_id = employee_department_id ORDER BY 1 LIMIT 1) AS 'departmentNumber',
                                                employee_tel,
                                                (SELECT post_name FROM post
                                                WHERE post_id = employee_post_id ORDER BY 1 LIMIT 1) AS 'postName'
                                                FROM employee
                                                WHERE (SELECT department_city_id FROM department WHERE department_id = employee_department_id ORDER BY 1 LIMIT 1) = {MainWindow.departmentCity};", connection);
                    break;
                case "Директор компанії":
                    employee = new MySqlCommand(@"SELECT employee_id,
                                                employee_first_name,
                                                employee_last_name,
                                                (SELECT department_number FROM department
                                                WHERE department_id = employee_department_id ORDER BY 1 LIMIT 1) AS 'departmentNumber',
                                                employee_tel,
                                                (SELECT post_name FROM post
                                                WHERE post_id = employee_post_id ORDER BY 1 LIMIT 1) AS 'postName'
                                                FROM employee", connection);
                    break;
            }
            dt.Clear();
            adapterEmployee = new MySqlDataAdapter(employee);
            adapterEmployee.Fill(dt);
            dataGridEmployee.ItemsSource = dt.DefaultView;
            connection.Close();
        }

        private void button_Save_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommandBuilder cmdb = new MySqlCommandBuilder(adapterEmployee);
            adapterEmployee.Update(dt);
            dataGridEmployee.IsReadOnly = true;
            buttonEdit.Visibility = Visibility.Visible;
            buttonSave.Visibility = Visibility.Collapsed;
        }

        private void Button_Edit_Click(object sender, RoutedEventArgs e)
        {
            dataGridEmployee.IsReadOnly = false;
            buttonEdit.Visibility = Visibility.Collapsed;
            buttonSave.Visibility = Visibility.Visible;
        }

        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {
            switch (MainWindow.namePostEmployee)
            {
                case "Адміністратор відділення":
                    adapterDepId = new MySqlDataAdapter(MainWindow.departmentNumber);
                    adapterDepId.Fill(dt);
                    employeeSearch = new MySqlCommand($@"SELECT employee_id,
                                                employee_first_name,
                                                employee_last_name,
                                                (SELECT department_number FROM department
                                                WHERE department_id = employee_department_id ORDER BY 1 LIMIT 1) AS 'departmentNumber',
                                                employee_tel,
                                                (SELECT post_name FROM post
                                                WHERE post_id = employee_post_id ORDER BY 1 LIMIT 1) AS 'postName'
                                                FROM employee
                                                WHERE employee_department_id = {dt.Rows[0]["department_id"]} and
                                                employee_first_name LIKE ('{textBoxName.Text}%') and
										        employee_last_name LIKE ('{textBoxSurname.Text}%') and
										        (SELECT post_name FROM post
                                                WHERE post_id = employee_post_id ORDER BY 1 LIMIT 1) LIKE ('{textBoxPost.Text}%');", connection);
                    break;
                case "Директор областної філії":
                    employeeSearch = new MySqlCommand($@"SELECT employee_id,
                                                employee_first_name,
                                                employee_last_name,
                                                (SELECT department_number FROM department
                                                WHERE department_id = employee_department_id ORDER BY 1 LIMIT 1) AS 'departmentNumber',
                                                employee_tel,
                                                (SELECT post_name FROM post
                                                WHERE post_id = employee_post_id ORDER BY 1 LIMIT 1) AS 'postName'
                                                FROM employee
                                                WHERE (SELECT department_city_id FROM department WHERE department_id = employee_department_id ORDER BY 1 LIMIT 1) = {MainWindow.departmentCity} and
                                                employee_first_name LIKE ('{textBoxName.Text}%') and
										        employee_last_name LIKE ('{textBoxSurname.Text}%') and
										        (SELECT post_name FROM post
                                                WHERE post_id = employee_post_id ORDER BY 1 LIMIT 1) LIKE ('{textBoxPost.Text}%');", connection);
                    break;
                case "Директор компанії":
                    employeeSearch = new MySqlCommand($@"SELECT employee_id,
                                                employee_first_name,
                                                employee_last_name,
                                                (SELECT department_number FROM department
                                                WHERE department_id = employee_department_id ORDER BY 1 LIMIT 1) AS 'departmentNumber',
                                                employee_tel,
                                                (SELECT post_name FROM post
                                                WHERE post_id = employee_post_id ORDER BY 1 LIMIT 1) AS 'postName'
                                                FROM employee
                                                WHERE employee_first_name LIKE ('{textBoxName.Text}%') and
										        employee_last_name LIKE ('{textBoxSurname.Text}%') and
										        (SELECT post_name FROM post
                                                WHERE post_id = employee_post_id ORDER BY 1 LIMIT 1) LIKE ('{textBoxPost.Text}%');", connection);
                    break;
            }
            adapterEmployee = new MySqlDataAdapter(employeeSearch);
            dt.Clear();
            adapterEmployee.Fill(dt);
            dataGridEmployee.DataContext = dt;
        }
    }
}

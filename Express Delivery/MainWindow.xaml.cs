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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Express_Delivery
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string idEmployee;
        public static string namePostEmployee;
        public static string departmentCity;
        
        private static string connectString = "SERVER=localhost;DATABASE=expressdeliverycompany;UID=root;PASSWORD=MeRRFiS2002;";
        
        private MySqlConnection connection = new MySqlConnection(connectString);
        
        public static MySqlCommand namePost;
        public static MySqlCommand departmentNumber;
        private MySqlCommand depCityCmd;

        private EmployeeMenu employeeMenu = new EmployeeMenu();
        
        private AdminMenu adminMenu = new AdminMenu();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Enter_Click(object sender, RoutedEventArgs e)
        {
            MySqlCommand autorizationCmd = new MySqlCommand("SELECT employee_id FROM employee WHERE employee_login = '" + loginBox.Text + "' and employee_password = '" + passBox.Password + "'", connection);
            MySqlCommand nameEmployeeCmd;
            
            connection.Open();
            if(autorizationCmd.ExecuteScalar() == null)
                MessageBox.Show("Такого користувача не існує!\nПеревірте логін чи пароль.", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                idEmployee = autorizationCmd.ExecuteScalar().ToString();
                nameEmployeeCmd = new MySqlCommand("SELECT employee_first_name FROM employee WHERE employee_id = '" + idEmployee + "'", connection);
                namePost = new MySqlCommand("SELECT p.post_name FROM post p JOIN employee e ON p.post_id = e.employee_post_id WHERE employee_id = '" + idEmployee + "' ORDER BY 1", connection);
                namePostEmployee = namePost.ExecuteScalar().ToString();
                depCityCmd = new MySqlCommand($@"SELECT d.department_city_id as 'departmentCity'
                                            FROM department d
                                            JOIN employee e ON(employee_department_id = department_id)
                                            WHERE e.employee_id = {idEmployee}
                                            ORDER BY e.employee_id", connection);
                departmentNumber = new MySqlCommand($@"SELECT d.department_id,d.department_number
                                                        FROM department d
                                                        JOIN employee e ON(employee_department_id = department_id)
                                                        WHERE e.employee_id = {idEmployee}
                                                        ORDER BY e.employee_id", connection);
                departmentCity = depCityCmd.ExecuteScalar().ToString();
                if (namePostEmployee == "Касир")
                {
                    employeeMenu.Show();
                    employeeMenu.nameEmployee.Text = nameEmployeeCmd.ExecuteScalar().ToString();
                    EmployeeMenu.nameEmloyee = nameEmployeeCmd.ExecuteScalar().ToString();
                    Hide();
                }
                else
                {
                    
                    adminMenu.Show();
                    adminMenu.nameEmployee.Text = nameEmployeeCmd.ExecuteScalar().ToString();
                    AdminMenu.nameEmloyee = nameEmployeeCmd.ExecuteScalar().ToString();
                    Hide();
                }
            }
            connection.Close();
        }
    }
}

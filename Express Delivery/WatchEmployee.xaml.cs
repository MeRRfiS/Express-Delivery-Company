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

        private void Button_Dismiss_Click(object sender, RoutedEventArgs e)
        {
            connection.Open();
            employeePost = new MySqlCommand($"SELECT p.post_name FROM post p JOIN employee e ON p.post_id = e.employee_post_id WHERE employee_id = '{index}' ORDER BY 1", connection);
            employeeName = new MySqlCommand($"SELECT employee_first_name FROM employee WHERE employee_id = '{index}'", connection);
            MessageBoxResult dialogResult = MessageBox.Show($"Ви впевнені що хочете звільнити {employeeName.ExecuteScalar().ToString()}?", "Повідомлення", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (dialogResult == MessageBoxResult.No)
                return;
            if (MainWindow.namePostEmployee == "Адміністратор відділення")
                if (employeePost.ExecuteScalar().ToString() != "Касир")
                {
                    MessageBox.Show("Неможливо виконати дію!\nВи не можете звільнити людину, яка має вищу посаду", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            if (MainWindow.namePostEmployee == "Директор областної філії")
                if (employeePost.ExecuteScalar().ToString() == "Директор компанії")
                {
                    MessageBox.Show("Неможливо виконати дію!\nВи не можете звільнити людину, яка має вищу посаду", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            employeeDelete = new MySqlCommand($"DELETE FROM employee WHERE employee_id = {index};", connection);
            employeeDelete.ExecuteReader();
            dt.Clear();
            adapterEmployee.Fill(dt);
            dataGridEmployee.ItemsSource = dt.DefaultView;
            connection.Close();
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
            employee = new MySqlCommand(@"SELECT employee_id, employee_first_name,
                                        employee_last_name,
                                        (SELECT department_number FROM department
                                        WHERE department_id = employee_department_id ORDER BY 1 LIMIT 1) AS 'departmentNumber',
                                        employee_tel,
                                        (SELECT post_name FROM post
                                        WHERE post_id = employee_post_id ORDER BY 1 LIMIT 1) AS 'postName'
                                        FROM employee", connection);
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
            employeeSearch = new MySqlCommand($@"SELECT employee_id, employee_first_name,
                                        employee_last_name,
                                        (SELECT department_number FROM department
                                        WHERE department_id = employee_department_id ORDER BY 1 LIMIT 1) AS 'departmentNumber',
                                        employee_tel,
                                        (SELECT post_name FROM post
                                        WHERE post_id = employee_post_id ORDER BY 1 LIMIT 1) AS 'postName'
                                        FROM employee
                                        WHERE employee_first_name LIKE ('{textBoxName.Text}%') and
										employee_last_name LIKE ('{textBoxSurname.Text}%') and
										(SELECT department_number FROM department
                                        WHERE department_id = employee_department_id ORDER BY 1 LIMIT 1) LIKE ('{textBoxDepartment.Text}%') and
										employee_tel LIKE ('{textBoxPhone.Text}%') and
										(SELECT post_name FROM post
										WHERE post_id = employee_post_id ORDER BY 1 LIMIT 1) LIKE ('{textBoxPost.Text}%')", connection);
            adapterEmployee = new MySqlDataAdapter(employeeSearch);
            dt.Clear();
            adapterEmployee.Fill(dt);
            dataGridEmployee.DataContext = dt;
        }

        private void dataGridEmployee_MouseUp(object sender, MouseButtonEventArgs e)
        {
            buttonDismiss.Visibility = Visibility.Visible;
            index = dt.DefaultView[dataGridEmployee.SelectedIndex]["employee_id"].ToString();
        }
    }
}

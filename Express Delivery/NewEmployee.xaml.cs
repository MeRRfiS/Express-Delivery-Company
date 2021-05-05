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
        private string departmentCity;
        private string postId;
        private string departmentId;
        private string login;
        private string password;

        private MySqlConnection connection;

        private MySqlDataAdapter adapterPostName;
        private MySqlDataAdapter adapterDepNumber;

        private DataTable dt = new DataTable();

        private MySqlCommand postName;
        private MySqlCommand departmentNumber;
        private MySqlCommand addEmployee;
        private MySqlCommand depCityCmd;

        private string GenerateLogin(string firstName, string lastName, string depId)
        {
            string chars = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string login = "";
            Random rand = new Random();
            login += firstName[0]; login += lastName[0]; login += "_" + depId + "_";
            for (int i = 0; i < 5; i++)
                login += chars[rand.Next(0,chars.Length)];
            return login;
        }

        private string GeneratePasswort()
        {
            string chars = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuioplkjhgfdsazxcvbnm1234567890";
            string password = "";
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
                password += chars[rand.Next(0, chars.Length)];
            return password;
        }

        public NewEmployee()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectString);
            switch (MainWindow.namePostEmployee)
            {
                case "Адміністратор відділення":
                    postName = new MySqlCommand("SELECT post_name FROM post ORDER BY post_id LIMIT 1;", connection);
                    adapterDepNumber = new MySqlDataAdapter(MainWindow.departmentNumber);
                    adapterDepNumber.Fill(dt);
                    comboBoxDepartment.Items.Add(dt.Rows[0]["department_number"]);
                    break;
                case "Директор областної філії":
                    postName = new MySqlCommand("SELECT post_name FROM post ORDER BY post_id LIMIT 2;", connection);
                    departmentNumber = new MySqlCommand($@"SELECT d.department_id,d.department_number
                                                        FROM department d
                                                        JOIN city c ON(department_city_id = city_id)
                                                        WHERE city_id = {MainWindow.departmentCity};", connection);
                    adapterDepNumber = new MySqlDataAdapter(departmentNumber);
                    adapterDepNumber.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                        comboBoxDepartment.Items.Add(dt.Rows[i]["department_number"]);
                    break;
                case "Директор компанії":
                    postName = new MySqlCommand("SELECT post_name FROM post ORDER BY post_id LIMIT 3;", connection);
                    departmentNumber = new MySqlCommand($@"SELECT department_id,CONCAT((SELECT city_name FROM city WHERE city_id = department_city_id),'-',department_number) as 'department'
                                                        FROM department;", connection);
                    adapterDepNumber = new MySqlDataAdapter(departmentNumber);
                    adapterDepNumber.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                        comboBoxDepartment.Items.Add(dt.Rows[i]["department"]);
                    break;
            }
            dt.Clear();
            adapterPostName = new MySqlDataAdapter(postName);
            adapterPostName.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
                comboBoxPost.Items.Add(dt.Rows[i]["post_name"]);
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

        private void Button_Register_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Помилка оформлення!\nБудь ласка заповніть поле \"Ім'я\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (textBoxSurname.Text == "")
            {
                MessageBox.Show("Помилка оформлення!\nБудь ласка заповніть поле \"Прізвище\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (textBoxLastname.Text == "")
            {
                MessageBox.Show("Помилка оформлення!\nБудь ласка заповніть поле \"Побатькові\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            for (int i = 0; i < 10; i++)
            {
                if (textBoxName.Text.Contains(i.ToString()))
                {
                    MessageBox.Show("Помилка оформлення!\nУ полі \"Ім'я\" не повинно буди цифр", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (textBoxSurname.Text.Contains(i.ToString()))
                {
                    MessageBox.Show("Помилка оформлення!\nУ полі \"Прізвище\" не повинно буди цифр", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (textBoxLastname.Text.Contains(i.ToString()))
                {
                    MessageBox.Show("Помилка оформлення!\nУ полі \"Побатькові\" не повинно буди цифр", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            if (textBoxPhone.Text == "")
            {
                MessageBox.Show("Помилка оформлення!\nБудь ласка заповніть поле \"Телефон\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (textBoxPhone.Text.Length == 9)
            {
                MessageBox.Show("Помилка оформлення!\nУ полі \"Телефон\" Не вірна кількість символів. Повино буди рівно 10 цифр", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                int.Parse(textBoxPhone.Text);
            }
            catch
            {
                MessageBox.Show("Помилка оформлення!\nУ полі \"Телефон\" Повинні буди тільки цифри", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (comboBoxPost.SelectedIndex == -1)
            {
                MessageBox.Show("Помилка оформлення!\nБудь ласка заповніть поле \"Посада\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (comboBoxDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Помилка оформлення!\nБудь ласка заповніть поле \"Номер відділення\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            MessageBoxResult dialogResult = MessageBox.Show("Ви впевнені що всі дані вірні?", "Повідомлення", MessageBoxButton.YesNo, MessageBoxImage.Question);
            connection.Open();
            if (dialogResult == MessageBoxResult.Yes)
            {
                postId = comboBoxPost.SelectedIndex.ToString();
                dt.Clear();
                adapterDepNumber.Fill(dt);
                departmentId = dt.Rows[comboBoxDepartment.SelectedIndex]["department_id"].ToString();
                login = GenerateLogin(textBoxName.Text, textBoxLastname.Text, departmentId);
                password = GeneratePasswort();
                addEmployee = new MySqlCommand($@"INSERT INTO employee VALUES(NULL,'{int.Parse(departmentId) + 1}','{textBoxName.Text + " " + textBoxSurname.Text}', 
                                                '{textBoxLastname.Text}', '{textBoxPhone.Text}', '{int.Parse(postId) + 1}' , '{login}', '{password}')", connection);
                addEmployee.ExecuteReader();
                MessageBox.Show($"Працівника зареєстровано!\nЛогін Працівника: {login}\nПароль Працівника: {password}", "Повідомлення", MessageBoxButton.OK, MessageBoxImage.Information);
                AdminMenu adminMenu = new AdminMenu();
                adminMenu.Show();
                Hide();
            }
            connection.Close();
        }
    }
}

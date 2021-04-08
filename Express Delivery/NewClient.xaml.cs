using MySql.Data.MySqlClient;
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
using System.Windows.Shapes;

namespace Express_Delivery
{
    /// <summary>
    /// Логика взаимодействия для NewClient.xaml
    /// </summary>
    public partial class NewClient : Window
    {
        private static string connectString = "SERVER=localhost;DATABASE=expressdeliverycompany;UID=root;PASSWORD=MeRRFiS2002;";

        private MySqlConnection connection;

        private MySqlCommand checkPasport;
        private MySqlCommand cityName;
        private MySqlCommand addClient;

        public NewClient()
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
            AddOrder addOrder = new AddOrder();
            addOrder.Show();
            Hide();
        }

        private void Button_Registered_Click(object sender, RoutedEventArgs e)
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
            if (textBoxPasport.Text == "")
            {
                MessageBox.Show("Помилка оформлення!\nБудь ласка заповніть поле \"Серія паспорту\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (textBoxPasport.Text.Length == 8)
            {
                MessageBox.Show("Помилка оформлення!\nУ полі \"Серія паспорту\" Не вірна кількість символів. Повино буди рівно 9 символів", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            checkPasport = new MySqlCommand("SELECT client_id FROM client_ WHERE client_pasport = '" + textBoxPasport.Text + "';", connection);
            if (checkPasport.ExecuteScalar() != null)
            {
                MessageBox.Show("Помилка оформлення!\nКористувач з таким паспортом вже існує", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (textBoxAdress.Text == "")
            {
                MessageBox.Show("Помилка оформлення!\nБудь ласка заповніть поле \"Адреса\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            MessageBoxResult dialogResult = MessageBox.Show("Ви впевнені що всі дані вірні?", "Повідомлення", MessageBoxButton.YesNo, MessageBoxImage.Question);
            connection.Open();
            if (dialogResult == MessageBoxResult.Yes)
            {
                cityName = new MySqlCommand("SELECT city_name FROM city WHERE city_id = (SELECT department_city_id FROM department WHERE department_id = (SELECT employee_department_id FROM employee WHERE employee_id = " + MainWindow.idEmployee + "));", connection);
                addClient = new MySqlCommand("INSERT INTO client_ VALUES(NULL,'" + textBoxPasport.Text + "','" + textBoxName.Text + " " + textBoxLastname.Text + "', '" +
                    textBoxSurname.Text + "', 'місто " + cityName.ExecuteScalar().ToString() + ", " + textBoxAdress.Text + "', '" + textBoxPhone.Text + "')", connection);
                addClient.ExecuteReader();
                MessageBox.Show("Клієнта зареєстровано!", "Повідомлення", MessageBoxButton.OK, MessageBoxImage.Information);
                AddOrder addOrder = new AddOrder();
                addOrder.Show();
                Hide();
            }
            connection.Close();
        }

        private void textBoxAdress_LostFocus(object sender, RoutedEventArgs e)
        {
            if ((!textBoxAdress.Text.Contains("вул.") || !textBoxAdress.Text.Contains("вул") || 
                !textBoxAdress.Text.Contains("вулиця") || !textBoxAdress.Text.Contains("Вулиця")) && textBoxAdress.Text != "")
                textBoxAdress.Text = "вул. " + textBoxAdress.Text;
        }
    }
}

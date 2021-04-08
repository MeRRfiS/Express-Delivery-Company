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

    public partial class AddOrder : Window
    {
        private static string connectString = "SERVER=localhost;DATABASE=expressdeliverycompany;UID=root;PASSWORD=MeRRFiS2002;";

        public static string name;
        public static string surname = "123";
        public static string phone;
        public static string weight;
        public static string package;
        public static string delivery;
        public static string cityName;
        public static string department;
        public static string fragality;
        public static string nameReceiver;
        public static string surnameReceiver;
        public static string phoneReceiver;
        public static string dateStorage;
        public static string dateReceiving;
        public static string returnDoc;
        public static string pasport;
        public static string price;
        public static int packageNumber;
        public static int deliveryNumber;
        public static int cityNameNumber;
        public static int departmentNumber;

        private MySqlConnection connection;

        private MySqlCommand city;
        private MySqlCommand kindPackage;
        private MySqlCommand kindDelivery;
        private MySqlCommand checkPasport;
        private MySqlCommand checkDepartment;
        private MySqlCommand getFullName;

        private DataTable table;

        private MySqlDataAdapter cityAdapter;
        private MySqlDataAdapter kindPackageAdapter;
        private MySqlDataAdapter kindDeliveryAdapter;
        private MySqlDataAdapter departmentAdapter;
        private MySqlDataAdapter getFullNameAdapter;

        private float priceWeight = 0;

        private int priceDelivery = 0;
        private int priceAdd = 0;

        private bool allCorect = true;

        //private EmployeeMenu employeeMenu;

        private void SetPrice()
        {
            textBlockPrice.Text = (priceWeight + priceDelivery + priceAdd) + " грн";
        }

        public AddOrder()
        {
            InitializeComponent();

            //employeeMenu = new EmployeeMenu();
            table = new DataTable();
            connection = new MySqlConnection(connectString);
            city = new MySqlCommand("SELECT city_name FROM city ORDER BY city_id;", connection);
            kindPackage = new MySqlCommand("SELECT kind_package_name FROM kind_package ORDER BY kind_package_id;", connection);
            kindDelivery = new MySqlCommand("SELECT kind_delivery_name FROM kind_delivery ORDER BY kind_delivery_id;", connection);
            getFullName = new MySqlCommand("SELECT client_first_name, client_last_name, client_tel FROM client_;", connection);
            cityAdapter = new MySqlDataAdapter(city);
            kindPackageAdapter = new MySqlDataAdapter(kindPackage);
            kindDeliveryAdapter = new MySqlDataAdapter(kindDelivery);
            getFullNameAdapter = new MySqlDataAdapter(getFullName);

            cityAdapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
                comboBoxCity.Items.Add(table.Rows[i]["city_name"]);
            table.Clear();
            kindPackageAdapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
                comboBoxPackage.Items.Add(table.Rows[i]["kind_package_name"]);
            table.Clear();
            kindDeliveryAdapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
                comboBoxDelivery.Items.Add(table.Rows[i]["kind_delivery_name"]);
        }

        private void checkBoxRegistered_Click(object sender, RoutedEventArgs e)
        {
            if (checkBoxRegistered.IsChecked == true)
            {
                textBoxPasport.Visibility = Visibility.Visible;
                textBoxName.Visibility = Visibility.Collapsed;
                textBoxSurname.Visibility = Visibility.Collapsed;
                textBoxTelephone.Visibility = Visibility.Collapsed;
            }
            else
            {
                textBoxPasport.Visibility = Visibility.Collapsed;
                textBoxName.Visibility = Visibility.Visible;
                textBoxSurname.Visibility = Visibility.Visible;
                textBoxTelephone.Visibility = Visibility.Visible;
            }
        }

        private void checkBoxEnd_Click(object sender, RoutedEventArgs e)
        {
            if (checkBoxEnd.IsChecked == true)
                textBoxEnd.IsEnabled = true;
            else
            {
                int value = 0;
                try
                {
                    value = int.Parse(textBoxEnd.Text);
                }
                catch
                {

                }
                priceAdd -= 5 * value;
                SetPrice();
                textBoxEnd.Text = "";
                textBoxEnd.IsEnabled = false;
            }

        }

        private void checkBoxReturn_Click(object sender, RoutedEventArgs e)
        {
            if (checkBoxReturn.IsChecked == true)
                priceAdd += 15;
            else
                priceAdd -= 15;
            SetPrice();
        }

        private void textBoxWeight_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                float weight = float.Parse(textBoxWeight.Text);
                if (weight < 1)
                    priceWeight = 28;
                else if (weight >= 1 && weight < 10)
                    priceWeight = 40;
                else if (weight >= 10 && weight < 30)
                    priceWeight = 70;
                else if (weight > 30)
                    priceWeight = 70 + ((weight - 30) * 1.5f);
                allCorect = true;
                SetPrice();
            }
            catch
            {
                allCorect = false;
                MessageBox.Show("Неправильний формат вводу!\nБудь лалка введіть у форматі: 0,0", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void textBoxEnd_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                int value = int.Parse(textBoxEnd.Text);
                if (value <= 7 && value > 0)
                {
                    priceAdd += 5 * value;
                    allCorect = true;
                    SetPrice();
                }
                else
                {
                    allCorect = false;
                    MessageBox.Show("Введенно неправильне число!\nБудь ласка введіть число не менше 7 та більше 0", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                    
            }
            catch
            {
                allCorect = false;
                MessageBox.Show("Неправильний формат вводу!\nБудь лалка введіть ціле число", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void comboBoxCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            checkDepartment = new MySqlCommand("SELECT department_number FROM department WHERE department_city_id=" + (comboBoxCity.SelectedIndex+1) + " ORDER BY 1;", connection);
            departmentAdapter = new MySqlDataAdapter(checkDepartment);
            table.Clear();
            departmentAdapter.Fill(table);
            comboBoxDepartment.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
                comboBoxDepartment.Items.Add(table.Rows[i]["department_number"]);
            comboBoxDepartment.IsEnabled = true;
        }

        private void comboBoxDelivery_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBoxDelivery.SelectedIndex)
            {
                case 0:
                    priceDelivery = 0;
                    break;
                case 1:
                    priceDelivery = 15;
                    break;
                case 2:
                    priceDelivery = 30;
                    break;
            }
            SetPrice();
        }

        private void Button_End_Order_Click(object sender, RoutedEventArgs e)
        {
            CheckOrder checkOrder = new CheckOrder();
            if (checkBoxRegistered.IsChecked == true)
            {
                if(textBoxPasport.Text == "")
                {
                    MessageBox.Show("Помилка оформлення!\nБудь ласка заповніть поле \"Серія паспорту\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                checkPasport = new MySqlCommand("SELECT client_id FROM client_ WHERE '" + textBoxPasport.Text + "' = client_pasport ORDER BY 1", connection);
                connection.Open();
                if (checkPasport.ExecuteScalar() == null)
                {
                    MessageBox.Show("Помилка авторизації!\nНе існує користувача с таким паспортом", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    connection.Close();
                    return;
                }
                connection.Close();
            }
            else
            {
                if(textBoxName.Text == "")
                {
                    MessageBox.Show("Помилка оформлення!\nБудь ласка заповніть поле \"Ім'я\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (textBoxSurname.Text == "")
                {
                    MessageBox.Show("Помилка оформлення!\nБудь ласка заповніть поле \"Прізвище\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
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
                }
                if (textBoxTelephone.Text == "")
                {
                    MessageBox.Show("Помилка оформлення!\nБудь ласка заповніть поле \"Телефон\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if(textBoxTelephone.Text.Length == 9)
                {
                    MessageBox.Show("Помилка оформлення!\nУ полі \"Телефон\" Не вірна кількість символів. Повино буди рівно 10 цифр", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                try
                {
                    int.Parse(textBoxTelephone.Text);
                }
                catch
                {
                    MessageBox.Show("Помилка оформлення!\nУ полі \"Телефон\" Повинні буди тільки цифри", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            if(textBoxWeight.Text == "")
            {
                MessageBox.Show("Помилка оформлення!\nБудь ласка заповніть поле \"Вага\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(comboBoxPackage.SelectedIndex == -1)
            {
                MessageBox.Show("Помилка оформлення!\nБудь ласка оберіть значення у полі \"Вид упакування\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (comboBoxDelivery.SelectedIndex == -1)
            {
                MessageBox.Show("Помилка оформлення!\nБудь ласка оберіть значення у полі \"Вид доставки\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (comboBoxCity.SelectedIndex == -1)
            {
                MessageBox.Show("Помилка оформлення!\nБудь ласка оберіть значення у полі \"Місто\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(comboBoxDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Помилка оформлення!\nБудь ласка оберіть значення у полі \"Номер відділення\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (radioButtonYes.IsChecked == false && radioButtonNo.IsChecked == false)
            {
                MessageBox.Show("Помилка оформлення!\nБудь ласка оберіть значення у полі \"Крихкість\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (textBoxNameReceiver.Text == "")
            {
                MessageBox.Show("Помилка оформлення!\nБудь ласка заповніть поле \"Ім'я отримувача\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (textBoxSurnameReceiver.Text == "")
            {
                MessageBox.Show("Помилка оформлення!\nБудь ласка заповніть поле \"Прізвище отримувача\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            for (int i = 0; i < 10; i++)
            {
                if (textBoxNameReceiver.Text.Contains(i.ToString()))
                {
                    MessageBox.Show("Помилка оформлення!\nУ полі \"Ім'я отримувача\" не повинно буди цифр", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                if (textBoxSurnameReceiver.Text.Contains(i.ToString()))
                {
                    MessageBox.Show("Помилка оформлення!\nУ полі \"Прізвище отримувача\" не повинно буди цифр", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            }
            if (textBoxTelephoneReceiver.Text == "")
            {
                MessageBox.Show("Помилка оформлення!\nБудь ласка заповніть поле \"Телефон отримувача\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (textBoxTelephoneReceiver.Text.Length == 9)
            {
                MessageBox.Show("Помилка оформлення!\nУ полі \"Телефон отримувача\" Не вірна кількість символів. Повино буди рівно 10 цифр", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                int.Parse(textBoxTelephoneReceiver.Text);
            }
            catch
            {
                MessageBox.Show("Помилка оформлення!\nУ полі \"Телефон отримувача\" Повинні буди тільки цифри", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(checkBoxEnd.IsChecked == true)
                if(textBoxEnd.Text == "")
                {
                    MessageBox.Show("Помилка оформлення!\nБудь ласка заповніть поле \"Кількість днів (до 7 днів)\"", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
            if (allCorect)
            {
                if(checkBoxRegistered.IsChecked == true)
                {
                    table.Clear();
                    getFullNameAdapter.Fill(table);
                    name = table.Rows[0]["client_first_name"].ToString();
                    surname = table.Rows[0]["client_last_name"].ToString();
                    phone = table.Rows[0]["client_tel"].ToString();
                    pasport = textBoxPasport.Text;
                }
                else
                {
                    pasport = "";
                    name = textBoxName.Text;
                    surname = textBoxSurname.Text;
                    phone = textBoxTelephone.Text;
                }
                weight = textBoxWeight.Text;
                package = comboBoxPackage.SelectedItem.ToString();
                packageNumber = comboBoxPackage.SelectedIndex;
                delivery = comboBoxDelivery.SelectedItem.ToString();
                deliveryNumber = comboBoxPackage.SelectedIndex;
                cityName = comboBoxCity.SelectedItem.ToString();
                cityNameNumber = comboBoxCity.SelectedIndex;
                department = comboBoxDepartment.SelectedItem.ToString();
                departmentNumber = comboBoxDepartment.SelectedIndex;
                if (radioButtonYes.IsChecked == true)
                    fragality = "Так";
                else
                    fragality = "Ні";
                nameReceiver = textBoxNameReceiver.Text;
                surnameReceiver = textBoxSurnameReceiver.Text;
                phoneReceiver = textBoxTelephoneReceiver.Text;
                switch (comboBoxDelivery.SelectedIndex)
                {
                    case 0:
                        dateReceiving = DateTime.Now.Date.AddDays(3).ToString("yyyy-MM-dd");
                        if (checkBoxEnd.IsChecked == true)
                            dateStorage = DateTime.Now.Date.AddDays(int.Parse(textBoxEnd.Text)+3).ToString("yyyy-MM-dd");
                        break;
                    case 1:
                        dateReceiving = DateTime.Now.Date.AddDays(2).ToString("yyyy-MM-dd");
                        if (checkBoxEnd.IsChecked == true)
                            dateStorage = DateTime.Now.Date.AddDays(int.Parse(textBoxEnd.Text)+2).ToString("yyyy-MM-dd");
                        break;
                    case 2:
                        dateReceiving = DateTime.Now.Date.AddDays(1).ToString("yyyy-MM-dd");
                        if (checkBoxEnd.IsChecked == true)
                            dateStorage = DateTime.Now.Date.AddDays(int.Parse(textBoxEnd.Text)+1).ToString("yyyy-MM-dd");
                        break;
                }
                if ((checkBoxEnd.IsChecked != true))
                    dateStorage = dateReceiving;
                if (checkBoxReturn.IsChecked == true)
                    returnDoc = "Так";
                else
                    returnDoc = "Ні";
                price = textBlockPrice.Text;
                checkOrder.Show();
                Hide();
            }
            else
                MessageBox.Show("Помилка оформлення!\nБудь ласка перевірте заповнені поля", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Return_Click(object sender, RoutedEventArgs e)
        {
            EmployeeMenu employeeMenu = new EmployeeMenu();
            employeeMenu.Show();
            employeeMenu.nameEmployee.Text = EmployeeMenu.nameEmloyee;
            Hide();
        }

        private void Button_Registered_Click(object sender, RoutedEventArgs e)
        {
            NewClient newClient = new NewClient();
            newClient.Show();
            Hide();
        }
    }
}

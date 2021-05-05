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
using FastReport;

namespace Express_Delivery
{
    public partial class CheckOrder : Window
    {

        private static string connectString = "SERVER=localhost;DATABASE=expressdeliverycompany;UID=root;PASSWORD=MeRRFiS2002;";

        private MySqlConnection connection;

        private MySqlCommand lastIndex;
        private MySqlCommand newOrder;
        private MySqlCommand idClient;
        private MySqlCommand receipt;

        private Report report = new Report();

        private DataSet ds = new DataSet();

        private MySqlDataAdapter adapterReceipt;

        private void ShowReceipt()
        {
            connection.Open();
            receipt = new MySqlCommand("SELECT * FROM receipt ORDER BY 1 DESC LIMIT 1", connection);
            adapterReceipt = new MySqlDataAdapter(receipt);
            adapterReceipt.Fill(ds, "receipt");
            report.RegisterData(ds);
            report.Load("Receipt.frx");
            report.Show();
            connection.Close();
        }

        public CheckOrder()
        {
            InitializeComponent();

            connection = new MySqlConnection(connectString);
            lastIndex = new MySqlCommand("SELECT max(order_id) FROM order_",connection);
            
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

        private void dataGridBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<BoxTable> result = new List<BoxTable>();
            connection.Open();
            result.Add(new BoxTable(int.Parse(lastIndex.ExecuteScalar().ToString())+1,
                float.Parse(AddOrder.weight), AddOrder.fragality,AddOrder.returnDoc,
                AddOrder.package,AddOrder.delivery,AddOrder.dateStorage, AddOrder.dateReceiving));
            dataGridBox.ItemsSource = result;
            connection.Close();
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            textBlockFullName.Text = AddOrder.surname + " " + AddOrder.name;
            textBlockFullNameReceiver.Text = AddOrder.surnameReceiver + " " + AddOrder.nameReceiver;
            textBlockPhone.Text = AddOrder.phoneReceiver;
            textBlockCity.Text = AddOrder.cityName;
            textBlockAdress.Text = AddOrder.department;
            textBlockPrice.Text = AddOrder.price;
        }

        private void Button_Edit_Click(object sender, RoutedEventArgs e)
        {
            AddOrder addOrder = new AddOrder();
            if(AddOrder.pasport != "")
            {
                addOrder.textBoxPasport.Text = AddOrder.pasport;
                addOrder.checkBoxRegistered.IsChecked = true;
            }
            else
            {
                addOrder.textBoxName.Text = AddOrder.name;
                addOrder.textBoxSurname.Text = AddOrder.surname;
                addOrder.textBoxTelephone.Text = AddOrder.phone;
            }
            addOrder.textBoxWeight.Text = AddOrder.weight;
            addOrder.comboBoxPackage.SelectedIndex = AddOrder.packageNumber;
            addOrder.comboBoxDelivery.SelectedIndex = AddOrder.deliveryNumber;
            addOrder.comboBoxCity.SelectedIndex = AddOrder.cityNameNumber;
            addOrder.comboBoxDepartment.SelectedIndex = AddOrder.departmentNumber;
            if (AddOrder.fragality == "Так")
                addOrder.radioButtonYes.IsChecked = true;
            else
                addOrder.radioButtonNo.IsChecked = true;
            addOrder.textBoxNameReceiver.Text = AddOrder.nameReceiver;
            addOrder.textBoxSurnameReceiver.Text = AddOrder.surnameReceiver;
            addOrder.textBoxTelephoneReceiver.Text = AddOrder.phoneReceiver;
            if (AddOrder.dateStorage != AddOrder.dateReceiving)
            {
                addOrder.checkBoxEnd.IsChecked = true;
                addOrder.textBoxEnd.Text = int.Parse((DateTime.Parse(AddOrder.dateStorage) - DateTime.Parse(AddOrder.dateReceiving)).ToString("dd")).ToString();
                addOrder.textBoxEnd.IsEnabled = true;
            }
            if (AddOrder.returnDoc == "Так")
                addOrder.checkBoxReturn.IsChecked = true;
            addOrder.textBlockPrice.Text = AddOrder.price;
            addOrder.Show();
            Hide();
        }

        private void Button_Accses_Click(object sender, RoutedEventArgs e)
        {
            connection.Open();
            if (AddOrder.pasport == "")
            {
                newOrder = new MySqlCommand("INSERT INTO order_ VALUES(NULL, " + float.Parse(AddOrder.weight) + ", '" +
               AddOrder.fragality + "', " + (AddOrder.packageNumber + 1) + ", '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "', '" + DateTime.Parse(AddOrder.dateStorage).ToString("yyyy-MM-dd") + "', NULL, '" +
               DateTime.Parse(AddOrder.dateReceiving).ToString("yyyy-MM-dd") + "', NULL, " + MainWindow.idEmployee + ", " + (AddOrder.deliveryNumber + 1) + ", " + (AddOrder.department) + ", '" +
               AddOrder.nameReceiver + " " + AddOrder.surnameReceiver + "', " + (AddOrder.cityNameNumber + 1) + ", 'У місті відправника', '" +
               AddOrder.price + "', '" + AddOrder.returnDoc + "', '" + AddOrder.phoneReceiver + "', '" + AddOrder.name + " " + AddOrder.surname + "', '" +
               AddOrder.phone + "')", connection);
            } else
            {
                idClient = new MySqlCommand("SELECT client_id FROM client_ WHERE client_pasport = '" + AddOrder.pasport + "';", connection);
                newOrder = new MySqlCommand("INSERT INTO order_ VALUES(NULL, " + float.Parse(AddOrder.weight) + ", '" +
               AddOrder.fragality + "', " + (AddOrder.packageNumber + 1) + ", '" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "', '" + DateTime.Parse(AddOrder.dateStorage).ToString("yyyy-MM-dd") + "', NULL, '" +
               DateTime.Parse(AddOrder.dateReceiving).ToString("yyyy-MM-dd") + "', "+ int.Parse(idClient.ExecuteScalar().ToString()) +", " + MainWindow.idEmployee + ", " + (AddOrder.delivery) + ", " + (AddOrder.departmentNumber + 1) + ", '" +
               AddOrder.nameReceiver + " " + AddOrder.surnameReceiver + "', " + (AddOrder.cityNameNumber + 1) + ", 'У місті відправника', '" +
               AddOrder.price + "', '" + AddOrder.returnDoc + "', '" + AddOrder.phoneReceiver + "', NULL, NULL)", connection);
            }
            newOrder.ExecuteReader();
            connection.Close();
            MessageBox.Show("Замовлення оформленно!", "Повідомлення", MessageBoxButton.OK, MessageBoxImage.Information);
            Surrender surrender = new Surrender();
            if(surrender.ShowDialog() == true)
                MessageBox.Show($"Решта: {int.Parse(surrender.textBoxMoney.Text) - int.Parse(AddOrder.priceNumber)}", "Решта", MessageBoxButton.OK, MessageBoxImage.Information);
                
            ShowReceipt();
            EmployeeMenu employeeMenu = new EmployeeMenu();
            employeeMenu.nameEmployee.Text = EmployeeMenu.nameEmloyee;
            employeeMenu.Show();
            Hide();
        }
    }
}

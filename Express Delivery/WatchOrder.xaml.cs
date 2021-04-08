﻿using MySql.Data.MySqlClient;
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
    /// Логика взаимодействия для WatchOrder.xaml
    /// </summary>
    public partial class WatchOrder : Window
    {
        private static string connectString = "SERVER=localhost;DATABASE=expressdeliverycompany;UID=root;PASSWORD=MeRRFiS2002;";
        private string[] nameInfo = { "ID Замовлення",
        "ПІБ відправника",
        "Телефон відправника",
        "ПІБ отримувача",
        "Телефон отримувача",
        "Дата оформлення",
        "Дата отримання",
        "Дата зберігання",
        "Вага",
        "Крихкість",
        "Упакування",
        "Вид доставки",
        "Адреса",
        "ІБ працівника",
        "Місто",
        "Пеня",
        "Місцезнаходження",
        "Зворот документів",
        "Ціна"};

        private MySqlConnection connection;

        private MySqlCommand minOrder;
        private MySqlCommand checkId;
        private MySqlCommand[] order = new MySqlCommand[19];
        

        private DataTable dt = new DataTable();

        private MySqlDataAdapter adapterMin;


        public WatchOrder()
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
            EmployeeMenu employeeMenu = new EmployeeMenu();
            employeeMenu.Show();
            employeeMenu.nameEmployee.Text = EmployeeMenu.nameEmloyee;
            Hide();
        }

        private void dataGridOrderMin_Loaded(object sender, RoutedEventArgs e)
        {
            connection.Open();
            minOrder = new MySqlCommand("SELECT order_id,order_name_recipient,DATE_FORMAT(order_date, '%d.%m.%Y') as 'dateOrder',order_department_number,order_place FROM order_ ORDER BY 1", connection);
            adapterMin = new MySqlDataAdapter(minOrder);
            adapterMin.Fill(dt);
            dataGridOrderMin.DataContext = dt;
            connection.Close();
        }

        private void dataGridOrderMin_MouseUp(object sender, MouseButtonEventArgs e)
        {
            connection.Open();
            order[0] = new MySqlCommand("SELECT order_id FROM order_ WHERE order_id = '" + dt.DefaultView[dataGridOrderMin.SelectedIndex]["order_id"].ToString() + "'", connection);
            checkId = new MySqlCommand("SELECT order_client_id FROM order_ WHERE order_id = '"+ order[0].ExecuteScalar().ToString() + "'", connection);
            if(checkId.ExecuteScalar().ToString() == null)
            {
                order[1] = new MySqlCommand("SELECT order_name_client FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "'", connection);
                order[2] = new MySqlCommand("SELECT order_tel_client FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "'", connection);
            }
            else
            {
                order[1] = new MySqlCommand("SELECT concat(client_last_name,' ',client_first_name) FROM client_ WHERE client_id = " +
                    "(SELECT order_client_id FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "')", connection);
                order[2] = new MySqlCommand("SELECT client_tel FROM client_ WHERE client_id = " +
                    "(SELECT order_client_id FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "')", connection);
            }
            order[3] = new MySqlCommand("SELECT order_name_recipient FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "'", connection);
            order[4] = new MySqlCommand("SELECT order_tel_recipient FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "'", connection);
            order[5] = new MySqlCommand("SELECT DATE_FORMAT(order_date, '%d.%m.%Y') FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "'", connection);
            order[7] = new MySqlCommand("SELECT DATE_FORMAT(order_date_end, '%d.%m.%Y') FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "'", connection);
            order[6] = new MySqlCommand("SELECT DATE_FORMAT(order_date_receiving, '%d.%m.%Y') FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "'", connection);
            order[8] = new MySqlCommand("SELECT order_weight FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "'", connection);
            order[9] = new MySqlCommand("SELECT order_fragility FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "'", connection);
            order[10] = new MySqlCommand("SELECT kind_package_name FROM kind_package WHERE kind_package_id =" + 
                "(SELECT order_kind_package_id FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "')", connection);
            order[11] = new MySqlCommand("SELECT kind_delivery_name FROM kind_delivery WHERE kind_delivery_id =" + 
                "(SELECT order_kind_delivery_id FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "')", connection);
            order[12] = new MySqlCommand("SELECT department_adress FROM department WHERE department_number = " +
                "(SELECT order_department_number FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "')", connection);
            order[13] = new MySqlCommand("SELECT employee_first_name FROM employee WHERE employee_id =" +
                "(SELECT order_employee_id FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "')", connection);
            order[14] = new MySqlCommand("SELECT city_name FROM city WHERE city_id = " +
                "(SELECT order_city_id FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "')", connection);
            order[15] = new MySqlCommand("SELECT order_fine FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "'", connection);
            order[16] = new MySqlCommand("SELECT order_place FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "'", connection);
            order[17] = new MySqlCommand("SELECT order_return FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "'", connection);
            order[18] = new MySqlCommand("SELECT order_price FROM order_ WHERE order_id = '" + order[0].ExecuteScalar().ToString() + "'", connection);
            List<OrderInformation> result = new List<OrderInformation>();
            for (int i = 0; i < 19; i++)
                result.Add(new OrderInformation(nameInfo[i], order[i].ExecuteScalar().ToString()));
            dataGridOrder.ItemsSource = result;
            connection.Close();
        }

        private void Button_Search_Click(object sender, RoutedEventArgs e)
        {
            connection.Open();
            minOrder = new MySqlCommand("SELECT order_id,order_name_recipient,DATE_FORMAT(order_date, '%d.%m.%Y') as 'dateOrder',order_department_number,order_place FROM order_ " + 
                "WHERE order_id LIKE ('"+ textBoxID.Text + "%') and order_place LIKE ('" + textBoxPlace.Text + "%') ORDER BY 1", connection);
            adapterMin = new MySqlDataAdapter(minOrder);
            dt.Clear();
            adapterMin.Fill(dt);
            dataGridOrderMin.DataContext = dt;
            
            connection.Close();
        }

        private void Button_Edit_Click(object sender, RoutedEventArgs e)
        {
            dataGridOrder.IsReadOnly = false;
            buttonEdit.Visibility = Visibility.Collapsed;
            buttonSave.Visibility = Visibility.Visible;
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            DataSet ds = new DataSet();
            adapterMin = new MySqlDataAdapter("SELECT * FROM order_", connection);
            MySqlCommandBuilder cmdb = new MySqlCommandBuilder(adapterMin);
            adapterMin.Update(ds,);
            buttonEdit.Visibility = Visibility.Visible;
            buttonSave.Visibility = Visibility.Collapsed;
            dataGridOrder.IsReadOnly = true;
        }
    }
}
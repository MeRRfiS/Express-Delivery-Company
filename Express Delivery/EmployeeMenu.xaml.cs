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
    /// Логика взаимодействия для EmployeeMenu.xaml
    /// </summary>
    public partial class EmployeeMenu : Window
    {
        public static string nameEmloyee;

        private AddOrder addOrder = new AddOrder();

        public EmployeeMenu()
        {
            InitializeComponent();
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Add_Order_Click(object sender, RoutedEventArgs e)
        {
            addOrder.Show();
            Hide();
        }
    }
}

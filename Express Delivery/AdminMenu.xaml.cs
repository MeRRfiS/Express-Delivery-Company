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
    /// Логика взаимодействия для AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        public static string nameEmloyee;
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void Button_Close_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Button_Watch_Order_Click(object sender, RoutedEventArgs e)
        {
            WatchOrder watchOrder = new WatchOrder();
            watchOrder.Show();
            Hide();
        }

        private void Button_Watch_Client_Click(object sender, RoutedEventArgs e)
        {
            WatchClient watchClient = new WatchClient();
            watchClient.Show();
            Hide();
        }
    }
}

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
    /// Логика взаимодействия для Surrender.xaml
    /// </summary>
    public partial class Surrender : Window
    {
        public Surrender()
        {
            InitializeComponent();
        }

        private void Button_Count_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxMoney.Text != "")
                DialogResult = true;
        }
    }
}

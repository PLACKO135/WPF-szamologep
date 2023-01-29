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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void osszead_Click(object sender, RoutedEventArgs e)
        {
            String eredmeny = $"{a_szam.Text} + {b_szam.Text} = {(Convert.ToDouble(a_szam.Text) + Convert.ToDouble(b_szam.Text))}";
            eredmeny_helye.Items.Add(eredmeny);
        }

        private void kivon_Click(object sender, RoutedEventArgs e)
        {
            String eredmeny = $"{a_szam.Text} - {b_szam.Text} = {(Convert.ToDouble(a_szam.Text) - Convert.ToDouble(b_szam.Text))}";
            eredmeny_helye.Items.Add(eredmeny);
        }

        private void szoroz_Click(object sender, RoutedEventArgs e)
        {
            String eredmeny = $"{a_szam.Text} * {b_szam.Text} = {(Convert.ToDouble(a_szam.Text) * Convert.ToDouble(b_szam.Text))}";
            eredmeny_helye.Items.Add(eredmeny);
        }

        private void oszt_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(b_szam.Text) == 0)
            {
                MessageBox.Show("A 0-val való osztást nem értelmezzük");
            }
            else
            {
                String eredmeny = $"{a_szam.Text} / {b_szam.Text} = {(Convert.ToDouble(a_szam.Text) / Convert.ToDouble(b_szam.Text))}";
                eredmeny_helye.Items.Add(eredmeny);
            }
        }
    }
}

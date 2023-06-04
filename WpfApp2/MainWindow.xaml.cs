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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> ints = new List<int>();
        private List<double> doubles = new List<double>();
        private PhoneQueue _phoneQueue;
        public MainWindow()
        {
            InitializeComponent();
            InitializeComponent();
            _phoneQueue = new PhoneQueue();

            // добавляем несколько телефонов в очередь
            _phoneQueue.AddPhone(new Phone { Name = "Samsung Galaxy S21", Price = 699 });
            _phoneQueue.AddPhone(new Phone { Name = "iPhone 12", Price = 799 });
            _phoneQueue.AddPhone(new Phone { Name = "Xiaomi Mi 11", Price = 499 });

            // отображаем телефоны в ListBox
            lbPhones.ItemsSource = _phoneQueue.GetAllPhones();
        }



        private void txtMassiv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 ||
                e.Key == Key.OemComma || e.Key == Key.Back) return;
            e.Handled = true;
        }
            private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < int.Parse(txtSize.Text); i++)
            {
                int n = random.Next() / 100000000;
                ints.Add(n);
                txbGenMassiv.Text += n.ToString("") + " ";
            }
        }
        
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            foreach (int item in ints)
            {
                if (item % 3 == 0 && item > 0) sum = item + sum;
            }
            txbDoubleResult.Text = sum.ToString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // удаляем первый телефон из очереди
            _phoneQueue.RemoveFirstPhone();

            // обновляем данные в ListBox
            lbPhones.ItemsSource = _phoneQueue.GetAllPhones();
        }
    }
}
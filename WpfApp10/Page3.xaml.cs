using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        private TREntities context = new TREntities();
        public Page3()
        {
            InitializeComponent();
            OrdersDT.ItemsSource = context.Orders.ToList();
            SS.ItemsSource = context.Orders.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OrdersDT.ItemsSource = context.Orders.Where(item => item.Customer_ID.ToString().Contains(SearchTxt.Text));
        }



        private void SS_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OrdersDT.ItemsSource = context.Orders.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (SS.SelectedItem != null)
            {

                var selected = SS.SelectedItem as Orders;
                OrdersDT.ItemsSource = context.Orders.ToList().Where(item => item.Customer_ID.ToString() == selected.Customer_ID.ToString());

            }
        }
    }
}

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

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        private TREntities context = new TREntities();
        public Page2()
        {
            InitializeComponent();
            CustomersDataGrid.ItemsSource = context.Customers.ToList();
            SS.ItemsSource = context.Customers.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CustomersDataGrid.ItemsSource = context.Customers.ToList().Where(item => item.CustomerName.Contains(SearchTxt.Text));
        }

        private void SS_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CustomersDataGrid.ItemsSource = context.Customers.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (SS.SelectedItem != null)
            {

                var selected = SS.SelectedItem as Customers;
                CustomersDataGrid.ItemsSource = context.Customers.ToList().Where(item => item.CustomerName == selected.CustomerName);

            }
        }
    }
}

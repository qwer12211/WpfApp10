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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private TREntities context = new TREntities();
        public Page1()
        {
            InitializeComponent();
            BurgerDgr.ItemsSource = context.Burgers.ToList();
            SS.ItemsSource = context.Burgers.ToList();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BurgerDgr.ItemsSource = context.Burgers.ToList().Where(item => item.BurgerName.Contains(SearchTxt.Text));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BurgerDgr.ItemsSource = context.Burgers.ToList();
        }

        private void SS_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SS.SelectedItem != null)
            {

                var selected = SS.SelectedItem as Burgers;
                BurgerDgr.ItemsSource = context.Burgers.ToList().Where(item => item.BurgerName == selected.BurgerName);

            }
        }
    }
}

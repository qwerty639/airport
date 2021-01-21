using AIRPORT.Context;
using AIRPORT.Model;
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

namespace AIRPORT.Pages
{
    /// <summary>
    /// Логика взаимодействия для GridPage.xaml
    /// </summary>
    public partial class GridPage : Page
    {
        public GridPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dbView.ItemsSource = dbContext.db.TYPE.ToList();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TypePage());
        }

        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            TYPE DeleteType = (TYPE)dbView.SelectedItem;
            dbContext.db.TYPE.Remove(DeleteType);
            dbContext.db.SaveChanges();

            Page_Loaded(null, null);

        }


        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {
            TYPE edit2 = (TYPE )dbView.SelectedItem;
            if (edit2 != null)
            {
                NavigationService.Navigate(new edit(edit2));
            }

            else
            {
                MessageBox.Show("Вы ничего не выбрали");
            }
        }

        private void btn_Menu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }
    }
}

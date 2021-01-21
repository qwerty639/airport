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
    /// Логика взаимодействия для PathGridPage.xaml
    /// </summary>
    public partial class PathGridPage : Page
    {
        public PathGridPage()
        {
            InitializeComponent();
        }

        private void btn_Menu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dbView.ItemsSource = dbContext.db.PATH.ToList();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PathPage());
        }

        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            PATH DeletePath = (PATH)dbView.SelectedItem;

            dbContext.db.PATH.Remove(DeletePath);

            dbContext.db.SaveChanges();

            Page_Loaded(null, null);
        }

        private void btn_Edit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

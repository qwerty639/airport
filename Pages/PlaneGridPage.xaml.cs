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
    /// Логика взаимодействия для PlaneGridPage.xaml
    /// </summary>
    public partial class PlaneGridPage : Page
    {
        public PlaneGridPage()
        {
            InitializeComponent();
        }

        private void btn_Menu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dbView.ItemsSource = dbContext.db.PLANE.ToList();
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void btn_Remove_Click(object sender, RoutedEventArgs e)
        {
            PLANE DeletePlane = (PLANE)dbView.SelectedItem;
            dbContext.db.PLANE.Remove(DeletePlane);
            dbContext.db.SaveChanges();
            Page_Loaded(null, null);
        }
    }
}

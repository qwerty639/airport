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
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void btnAddType_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GridPage());
        }

        private void btnAddPlane_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PlaneGridPage());
        }

        private void btnAddPath_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PathGridPage());
        }

        private void btnAddDate_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DateGridPage());
        }

        private void btnAddTickets_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TicketsGridPage());
        }
    }
}

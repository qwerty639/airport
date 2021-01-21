using AIRPORT.Context;
using AIRPORT.Model;
using AIRPORT.Pages;
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

namespace AIRPORT
{
    /// <summary>
    /// Логика взаимодействия для TicketsPage.xaml
    /// </summary>
    public partial class TicketsPage : Page
    {
        public TicketsPage()
        {
            InitializeComponent();
            cmbDestination.ItemsSource = dbContext.db.PATH.Select(item => item.DESTINATION).ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DatePage());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            TICKETS newTickets = new TICKETS();

            var a = dbContext.db.PATH.FirstOrDefault(item => item.DESTINATION == cmbDestination.Text);
            newTickets.SELLTICKETS = Convert.ToInt32(txbSelltickets.Text);

            MessageBox.Show("Данные добавлены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        private void btnDataGrid_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TicketsGridPage());
        }
    }
}

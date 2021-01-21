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
    /// Логика взаимодействия для DatePage.xaml
    /// </summary>
    public partial class DatePage : Page
    {
        public DatePage()
        {
            InitializeComponent();
            cmbDestination.ItemsSource = dbContext.db.PATH.Select(item => item.DESTINATION).ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PathPage());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            DATE newDate = new DATE();

            var a = dbContext.db.PATH.FirstOrDefault(item => item.DESTINATION == cmbDestination.Text);
            newDate.DEPARTUREDATE = Convert.ToDateTime(dpDepartureDate.SelectedDate);
            newDate.DESTINATIONDATE = Convert.ToDateTime(dpDestinationDate.SelectedDate);

            newDate.IDPATH = a.ID;

            MessageBox.Show("Данные добавлены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            dbContext.db.DATE.Add(newDate);

            dbContext.db.SaveChanges();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new TicketsPage());
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DateGridPage());
        }
    }
}

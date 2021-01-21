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
    /// Логика взаимодействия для PathPage.xaml
    /// </summary>
    public partial class PathPage : Page
    {
        public PathPage()
        {
            InitializeComponent();
            cmbTypeID.ItemsSource = dbContext.db.TYPE.Select(item => item.TYPE1).ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            PATH newPath = new PATH();
            
            var a = dbContext.db.TYPE.FirstOrDefault(item => item.TYPE1 == cmbTypeID.Text);
            newPath.IDTYPE = a.ID;
            newPath.DISTANCE = Convert.ToInt32(txbDistance.Text);
            newPath.DEPARTURE = txbDeparture.Text;
            newPath.DESTINATION = txbDestination.Text;

            MessageBox.Show("Данные добавлены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            dbContext.db.PATH.Add(newPath);

            dbContext.db.SaveChanges();
           
        }

      

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PathGridPage());
        }
    }
}

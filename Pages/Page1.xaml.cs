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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            cmbTypeID.ItemsSource = dbContext.db.TYPE.Select(item => item.TYPE1).ToList();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PathPage());
           
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            PLANE newPlane = new PLANE();

            var a = dbContext.db.TYPE.FirstOrDefault(item => item.TYPE1 == cmbTypeID.Text);
            newPlane.PLACE = txbPlaces.Text;
            newPlane.SPEED = Convert.ToInt32(txbSpeed.Text);

            newPlane.IDTYPE = a.ID;
            MessageBox.Show("Данные добавлены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            dbContext.db.PLANE.Add(newPlane);

            dbContext.db.SaveChanges();


        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PlaneGridPage());
        }
    }
}

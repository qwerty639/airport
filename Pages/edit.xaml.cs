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
    /// Логика взаимодействия для edit.xaml
    /// </summary>
    public partial class edit : Page
    {
        private TYPE selecteditem ;
        public edit(TYPE selecteditem)

        {
            InitializeComponent();
            this.selecteditem = selecteditem;
            TxbType.Text = selecteditem.TYPE1;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var editer = dbContext.db.TYPE.FirstOrDefault(item => item.ID == selecteditem.ID);
            editer.TYPE1 = TxbType.Text;
            dbContext.db.SaveChanges();
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

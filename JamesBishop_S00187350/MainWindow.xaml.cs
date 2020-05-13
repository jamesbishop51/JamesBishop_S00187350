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

namespace JamesBishop_S00187350
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneData db = new PhoneData();
        List<Phone> AllPhones = new List<Phone>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //query that sets the source for the listbox
            var query = from p in db.Phones
                        select p;

            AllPhones = query.ToList();
            LbxPhones.ItemsSource = AllPhones;
        }
        //displays the information based on the selected phone
        private void LbxPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //gets the selected phone
            Phone selectedPhone = LbxPhones.SelectedItem as Phone;

            //check to make sure the selection is not null
            if(selectedPhone != null)
            {
                string Price = $"Phone Price: €{selectedPhone.Price}";
                TxtPrice.Text = Price;

                ImgPhone.Source = new BitmapImage(new Uri(selectedPhone.Phone_Image, UriKind.Relative));

            }


        }
    }

}

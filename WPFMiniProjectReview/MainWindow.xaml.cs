using DemoLibrary;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFMiniProjectReview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();
        public MainWindow()
        {
            InitializeComponent();

            addressesList.ItemSource = addresses;

            addresses.Add(new AddressModel
            {
                StreetAddress = "123 Wallabe Way",
                City = "Clarks Summit",
                State = "PA",
                ZipCode = "18411"
            });
        }
    }
}
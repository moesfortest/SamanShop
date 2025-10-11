using SamanShop.Bussiness.Models.Payments;
using SamanShop.Bussiness_.Contract;
using SamanShop.UI.Forms.Invoicefrm;
using System.Windows;
using System.Windows.Controls;

namespace SamanShop.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
  
        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            //List<string> paymentWays = new List<string>();
            //paymentWays.Add("CardToCard");
            //paymentWays.Add("ArzeDigital");
            //paymentWays.Add("Paypal");
            //paymentlst.ItemsSource = paymentWays;
            this.DataContext = viewModel;

        }

        private void InvoiceCreate_Click(object sender, RoutedEventArgs e)
        {

            var invoicefrm = new Invoicefrm((MainViewModel)this.DataContext);
            invoicefrm.Show();
        }
    }
}
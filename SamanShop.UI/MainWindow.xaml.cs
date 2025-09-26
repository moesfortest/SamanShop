using SamanShop.Bussiness.Models.Banks;
using SamanShop.Bussiness.Models.Payments;
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

namespace SamanShop.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        //public MainWindow()
        //{
        //    InitializeComponent();

        //    List<string> paymentWays = new List<string>();
        //    paymentWays.Add("CardToCard");
        //    paymentWays.Add("ArzeDigital");
        //    paymentWays.Add("Paypal");
        //    paymentlst.ItemsSource = paymentWays;

        //}

        public MainWindow(MainViewModel viewModel)
        {
            InitializeComponent();
            List<string> paymentWays = new List<string>();
            paymentWays.Add("CardToCard");
            paymentWays.Add("ArzeDigital");
            paymentWays.Add("Paypal");
            paymentlst.ItemsSource = paymentWays;
            DataContext = viewModel;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {




        }


        private void paymentlst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

           
            var  item = paymentlst.SelectedItem as string;


            var payment = new Payment();

            payment.Add(12, 13, (a, b) => { return a + b; });
               
            if (item!=null)
            {
             var  obj=   payment.payMentWay.TryGetValue(item, out Payment val);

                val.Pay(12);
            }

 




        }
    }
}
using SamanShop.Bussiness.Models.Payments;
using SamanShop.Bussiness_.Contract;
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
        

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            var dto = new ProductDTO();
            dto.ProductName = "car23";
            dto.ProductPrice = 1212;
         

            var  id=Guid.NewGuid();

            var productservice = ((MainViewModel)DataContext).ProductService;
            ((MainViewModel)DataContext).ProductService.CreateProduct(dto);


            var result = productservice.GetAll();
            ProductsGrid.ItemsSource = result;


            productservice.DeleteProduct(90);

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
using SamanShop.Bussiness.Models;
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
using System.Windows.Shapes;

namespace SamanShop.UI.Forms.Invoicefrm
{
    /// <summary>
    /// Interaction logic for Invoicefrm.xaml
    /// </summary>
    public partial class Invoicefrm : Window
    {
        public int _totalRecords;
        public int _pageSize;
        public int _currentPage = 1;

        public Invoicefrm(MainViewModel viewmodel)
        {
            InitializeComponent();
            _totalRecords = 100;
            _pageSize = 10;

            LoadData(1);
        }

        private async Task LoadData(int pageindex)
        {
            List<Customer> customerList = new List<Customer>();

            for (int i = 1; i <= 100; i++)
            {

                var customer = new Customer()
                {

                    FirstName = $"FirstName{i}",
                    LastName = $"LastName{i}",
                    NationalCode = i,
                    PhoneNumber = i * 9

                };


                customerList.Add(customer);


            }

            customerList = customerList.
                Skip((pageindex - 1) * _pageSize).
                Take(_pageSize).ToList();
    
            UpdatePaginationState( pageindex);
            DataGrid.ItemsSource = customerList;

        }




        private void UpdatePaginationState(int pageindex)
        {
            int totalPages = (_totalRecords + _pageSize - 1) / _pageSize;
            PageInfo.Text = $" {pageindex} of {totalPages}";
            FirstPageButton.IsEnabled = _currentPage > 1;
            PreviousPageButton.IsEnabled = _currentPage > 1;
            NextPageButton.IsEnabled = _currentPage < totalPages;
            LastPageButton.IsEnabled = _currentPage < totalPages;
        }

        private async void FirstPage_Click(object sender, RoutedEventArgs e)
        {
            _currentPage = 1;
            LoadData(1);
        }


        private async void PreviousPage_Click(object sender, RoutedEventArgs e)
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                await LoadData(_currentPage--);
            }
        }

        private async void NextPage_Click(object sender, RoutedEventArgs e)
        {
            int totalPages = (_totalRecords + _pageSize - 1) / _pageSize;
            if (_currentPage < totalPages)
            {
                _currentPage++;
                await LoadData(_currentPage++);
            }
        }

        private async void LastPage_Click(object sender, RoutedEventArgs e)
        {
            _currentPage = (_totalRecords + _pageSize - 1) / _pageSize; // Total Pages
            await LoadData(_currentPage);
        }

        public class Customer
        {

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public long NationalCode { get; set; }

            public string Address { get; set; }

            public long? PhoneNumber { get; set; }

            public long InvoiceNumber { get; set; }

        }
    }
}


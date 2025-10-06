using SamanShop.Bussiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamanShop.UI
{
    public class MainViewModel
    {
        public string ProductName { get; set; }

        public readonly IProductService _productService;
        public IProductService ProductService => _productService;
        public MainViewModel(IProductService productService)
        {
            _productService = productService;
            ProductName = "jhgjhgj";
        }


    }
}

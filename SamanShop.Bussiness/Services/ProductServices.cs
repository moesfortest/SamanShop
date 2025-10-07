using SamanShop.Bussiness_.Contract;
using SmanaShop.DAL.Model;

namespace SamanShop.Bussiness.Services
{
    internal class ProductServices : IProductService
    {
       private readonly IProductRepository  _repository;
        public ProductServices(IProductRepository productRepository)
        {
            _repository=productRepository;
        }

        public bool CreateProduct(ProductDTO productdto)
        {

            var num = new Random().NextDouble;
            var  product=new Product();
            product.ProductPrice = productdto.ProductPrice;
            product.ProductName = productdto.ProductName;
            product.ProductPrice=productdto.ProductPrice;
            _repository.AddProduct(product);
            _repository.SaveChange();
            return true;
        }

        public void DeleteProduct(int productCode)
        {
  _repository.DeleteProduct(productCode);
            _repository.SaveChange();
        }

        public List<ProductDTO> GetAll()
        {
        var  productlst=_repository.GetAll();
         
        var  finalresult=new  List<ProductDTO>();

            productlst.ForEach(product =>
            {

                var productDto = new ProductDTO();
                productDto.ProductPrice = product.ProductPrice;
                productDto.ProductName = product.ProductName;
                productDto.ProducCode = product.ProducCode;
                finalresult.Add(productDto);


            });


            return finalresult;                 

        }

        public ProductDTO GetProductByCode(int productcode)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProduct(ProductDTO product)
        {
            throw new NotImplementedException();
        }
    }
}

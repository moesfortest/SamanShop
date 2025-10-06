using SamanShop.Bussiness_.Contract;

namespace SamanShop.Bussiness
{
    public interface IProductService
    {
        public bool CreateProduct(ProductDTO productdto);

        public ProductDTO GetProductByCode(int productcode);
        public bool UpdateProduct(ProductDTO product);
        public List<ProductDTO> GetAll();

        public void DeleteProduct(int productCode);
    }
}

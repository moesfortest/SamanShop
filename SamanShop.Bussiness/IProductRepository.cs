using SmanaShop.DAL.Model;

namespace SamanShop.Bussiness
{
    public interface IProductRepository
    {

        public bool AddProduct(Product product);
        public Product GetProductByCode(int productcode);
        public  bool UpdateProduct(Product product);
        public   List<Product>  GetAll();

        public void DeleteProduct(int productCode);

        public void SaveChange();

        { _context.SaveChanges(); }

    }
}

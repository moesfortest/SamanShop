using SamanShop.Bussiness;
using SmanaShop.DAL.Model;
using SmanaShop.DAL.NullObject;

namespace SmanaShop.DAL.Repositories
{
    internal class ProductRepository : IProductRepository
    {
        private readonly SamanDbContext _context;
        public ProductRepository(SamanDbContext context)
        {
            _context = context;
        }
        public bool AddProduct(Product product)
        {

            product.ProductID = Guid.NewGuid();
            _context.Products.Add(product);
            SaveChange();
            return true;
        }

        public void DeleteProduct(int productCode)
        {
            var product = _context.Products.Where(s => s.ProducCode == productCode).ToList();



            product.ForEach(c =>
            {
                _context.Products.Remove(c);
            });
            SaveChange();

        }



        public List<Product> GetAll()
        {
            var lstProduct = _context.Products.ToList();

            return lstProduct;

        }

        public Product GetProductByCode(int productid)
        {
            var producut = _context.Products.Where(t => t.ProductID == productid).FirstOrDefault();

            if (producut != null)
            {
                return producut;
            }

            return new ProductNull();
        }

        public bool UpdateProduct(Product product)
        {
            _context.Update(product);
            SaveChange();
            return true;
        }

        public void SaveChange()

        { _context.SaveChanges(); }
    }
}

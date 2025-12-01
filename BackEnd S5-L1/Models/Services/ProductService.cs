using BackEnd_S5_L1.Models.Entity;

namespace BackEnd_S5_L1.Models.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Product Get(Guid Id)
        {
            return null;
        }

        public List<Product> GetAll()
        {
            return this._context.Products.ToList();
        }

        public bool Create(Product product)
        {
            this._context.Products.Add(product);

            if (this._context.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

        public bool Update(Product product)
        {
            return false;
        }

        public bool Delete(Guid Id)
        {
            return false;
        }

    }
}

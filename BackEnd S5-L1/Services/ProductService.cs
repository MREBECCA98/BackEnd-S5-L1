using BackEnd_S5_L1.Models.Entity;

namespace BackEnd_S5_L1.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public Product GetId(Guid Id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == Id);
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
            this._context.Products.Update(product);
            return this._context.SaveChanges() > 0;
        }

        public bool Delete(Guid Id)
        {
            Product toDelete = this.GetId(Id);
            if (toDelete != null)
            {
                this._context.Products.Remove(toDelete);
                return this.Save();
            }
            return false;
        }

        public bool Save()
        {
            if (this._context.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }

    }
}

using BackEnd_S5_L1.Models.Entity;

namespace BackEnd_S5_L1.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public User GetId(Guid Id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == Id);
        }

        public List<User> GetAll()
        {
            return this._context.Users.ToList();
        }

        public bool Create(User user)
        {
            this._context.Users.Add(user);

            if (this._context.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }
    }
}

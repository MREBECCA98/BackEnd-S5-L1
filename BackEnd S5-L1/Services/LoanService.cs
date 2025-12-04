using BackEnd_S5_L1.Models.Entity;


namespace BackEnd_S5_L1.Services
{
    public class LoanService
    {
        private readonly ApplicationDbContext _context;
        public LoanService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public void AddLoan(Guid productId, Guid userId)
        {
            var loan = new Loan
            {
                ProductId = productId,
                UserId = userId,
                DataDiRiconsegna = DateTime.Now.AddDays(30)
            };
            _context.Loans.Add(loan);
            _context.SaveChanges();
        }
    }
}

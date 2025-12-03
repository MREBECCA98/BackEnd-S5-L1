namespace BackEnd_S5_L1.Models.Entity
{
    public class Loan
    {
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public DateTime? DataDiRiconsegna { get; set; }
        public Product? Product { get; set; }
        public User? User { get; set; }
    }
}

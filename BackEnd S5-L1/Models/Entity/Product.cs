using System.ComponentModel.DataAnnotations;

namespace BackEnd_S5_L1.Models.Entity
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string? Copertina { get; set; }
        public string? Titolo { get; set; }
        public string? Autore { get; set; }

        public decimal Prezzo { get; set; }

    }
}

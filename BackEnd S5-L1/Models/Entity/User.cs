using System.ComponentModel.DataAnnotations;

namespace BackEnd_S5_L1.Models.Entity
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Cognome { get; set; }
        public string? Email { get; set; }

    }
}

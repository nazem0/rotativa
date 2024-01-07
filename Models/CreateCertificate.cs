using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class CreateCertificate
    {
        [Required]
        public string Course { get; set; }
        [Required]
        public string Issuer { get; set; }
        [Required]
        public string RecipientName { get; set; }
        [Required]
        public DateOnly IssuanceDate { get; set; }
        public DateOnly? ExpirationDate { get; set; }
    }
}

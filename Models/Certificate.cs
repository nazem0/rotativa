namespace API.Models
{
    public class Certificate
    {
        public Guid Key { get; set; } = Guid.NewGuid();
        public string Course { get; set; }
        public string Issuer { get; set; }
        public string RecipientName { get; set; }
        public DateOnly IssuanceDate { get; set; }
        public DateOnly? ExpirationDate { get; set; }
    }
}

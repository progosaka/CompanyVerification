namespace CompanyVerification
{
    public class TaxPayer
    {
        public string QID { get; set; } = string.Empty;
        public string TaxId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool IsVerified { get; set; }

        public TaxPayer()
        {
            QID= string.Empty;
            TaxId = string.Empty;
            Name = string.Empty;
            Address = string.Empty;
        }
        public TaxPayer(string taxId, string name, string address)
        {
            QID= taxId;
            TaxId = taxId;
            Name = name;
            Address = address;
            IsVerified = false;
        }
    }
}

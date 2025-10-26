namespace CompanyVerification
{
    public class SAPPayment
    {
        public string PaymentDocumentNumber { get; set; } = string.Empty;
        public string PaymentStatus { get; set; } = string.Empty;
        public string CustomerName { get; set; } = string.Empty;
        public decimal Amount { get; set; } = 0;
        public DateTime PaymentDate { get; set; } = DateTime.MinValue;
        public string PaymentMethod { get; set; } = string.Empty;
        public string CustomerEmail { get; set; } = string.Empty;
        public string MOCIAccountID { get; set; } = string.Empty;
        public string Remarks { get; set; } = string.Empty;
        public string TaxPayerID { get; set; } = string.Empty;  
        public string Status { get; set; } = string.Empty;
    }
}
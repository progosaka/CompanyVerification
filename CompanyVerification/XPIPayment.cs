namespace CompanyVerification
{
    public class XPIPayment
    {
        public string PaymentId { get; set; } = string.Empty;
        public string PayerName { get; set; } = string.Empty;
        public decimal Amount { get; set; } = 0;
        public DateTime PaymentDate { get; set; } = DateTime.MinValue;
        public string PaymentType { get; set; } = string.Empty;
        public string PayerEmail { get; set; } = string.Empty;
        public string mociAccountID { get; set; } = string.Empty;
        public string Remarks { get; set; } = string.Empty;
        public string taxPayerID { get; set; } = string.Empty;
        public string PaymentStatus { get; set; } = string.Empty;
    }
}


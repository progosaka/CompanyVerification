namespace CompanyVerificatFion
{
    public class Company
    {
        public String QID { get; set; }
        public String ownerFirstName { get; set; }
        public String registrationDate { get; set; }
        public String expiryDate { get; set; }
        public String ownerLastName { get; set; }
        public String companyID { get; set; }
        public String companyName { get; set; }
        public String companyAddress { get; set; }
        public String companyEmail { get; set; }
        public String companyPhone { get; set; }
        public String companyCity { get; set; }
        public String companyRegion { get; set; }
        public String companyCountry { get; set; }
        public String companyState { get; set; }
        public String companyZipCode { get; set; } = String.Empty;
        public String industry { get; set; }
        public int numberOfEmployees { get; set; }
        public String registrationStatus { get; set; }
    }
}

using CompanyVerificatFion;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using System.Numerics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyVerification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MOCICompanyController : ControllerBase
    {
        // GET: api/<MOCICompanyController>
        [HttpGet]
        public IEnumerable<Company> Get()
        {
            //create a list of companies
            List<Company> companyList = new List<Company>();

            Company company = new Company();
            company.companyID = "12343499";
            company.QID = "22331242234";
            company.companyName = "Falcon Contracting LLC";
            company.registrationDate = "2020-01-01";
            company.expiryDate = "2025-01-01";
            company.ownerFirstName = "Khalid";
            company.ownerLastName = "Al Ansari";
            company.companyAddress = "123, Barwa City";
            company.companyEmail = "khalied.alansari@falcon.com.qa";
            company.companyPhone = "+97434567890";
            company.companyCity = "Barwa City";
            company.companyRegion = "Doha";
            company.companyCountry = "Qatar";
            company.companyState = "Doha";
            company.companyZipCode = "32345";
            company.industry = "Technology";
            company.numberOfEmployees = 50;
            company.registrationStatus = "Active";

            companyList.Add(company);


            company = new Company();
            company.companyID = "12343434";
            company.QID = "66331242290";
            company.companyName = "Blue Waters LLC";
            company.registrationDate = "2022-01-01";
            company.expiryDate = "2027-01-01";
            company.ownerFirstName = "Stuart";
            company.ownerLastName = "Anderson";
            company.companyAddress = "345, Madinat Khalifa";
            company.companyEmail = "stuart.anderson@bluewaters.qa";
            company.companyPhone = "+9743434333";
            company.companyCity = "Doha";
            company.companyRegion = "Doha";
            company.companyCountry = "Qatar";
            company.companyState = "Doha";
            company.companyZipCode = "55644";
            company.industry = "Water Purification";
            company.numberOfEmployees = 32;
            company.registrationStatus = "Active";

            companyList.Add(company);

            company = new Company();
            company.companyID = "12343453";
            company.QID = "93451242234";
            company.companyName = "Dolphin Constructions LLC";
            company.registrationDate = "2020-01-01";
            company.expiryDate = "2025-01-01";
            company.ownerFirstName = "Majid";
            company.ownerLastName = "Noaimi";
            company.companyAddress = "900, Belhain Street";
            company.companyEmail = "majid@falcon.com.qa";
            company.companyPhone = "+97434567890";
            company.companyCity = "Lusail City";
            company.companyRegion = "Lusail";
            company.companyCountry = "Qatar";
            company.companyState = "Doha";
            company.companyZipCode = "32399";
            company.industry = "Construction";
            company.numberOfEmployees = 72;
            company.registrationStatus = "Active";

            companyList.Add(company);


            return companyList;
        }

        // GET api/<MOCICompanyController>/5
        [HttpGet("{companyID}")]
        public Company Get(String companyID)
        {
            Company company = new Company();
            company.companyID = companyID;
            company.QID = "22331242234";
            company.companyName = "Falcon Contracting LLC";
            company.registrationDate = "2020-01-01";
            company.expiryDate = "2025-01-01";
            company.ownerFirstName = "Khalid";
            company.ownerLastName = "Al Ansari";
            company.companyAddress = "123, Barwa City";
            company.companyEmail = "khalied.alansari@falcon.com.qa";
            company.companyPhone = "+97434567890";
            company.companyCity = "Barwa City";
            company.companyRegion = "Doha";
            company.companyCountry = "Qatar";
            company.companyState = "Doha";
            company.companyZipCode = "32345";
            company.industry = "Technology";
            company.numberOfEmployees = 50;
            company.registrationStatus = "Active";


            return company;
        }
    }
}

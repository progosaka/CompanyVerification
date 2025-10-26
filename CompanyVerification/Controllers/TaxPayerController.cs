using Microsoft.AspNetCore.Mvc;
using CompanyVerification;
using System; // Ensure System is included for Random


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyVerification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxPayerController : ControllerBase
    {
        // Add a static Random instance to avoid CS0120
        private static readonly Random _random = new Random();


        //out of 10 times this API is called, the API should return a 503 server unavailable error 3 times to simulate real world scenario of service unavailability. The other times it should just return one Tax payer based on ID. Please make changes to the existing [httpGet{id}] method to implement this behavior.


        [HttpGet("{qid}")]
        public ActionResult<TaxPayer> Get(String qid)
        {
            if (_random.Next(1, 11) <= 3) // 30% chance to return 503
            {
                return StatusCode(503, "Service Unavailable. Please try again later.");
            }
            TaxPayer taxPayer = new TaxPayer();
            taxPayer.QID = qid;
            taxPayer.TaxId = "TID-3252-3224-55422";
            taxPayer.Name = "Khalid Al Ansari";
            taxPayer.Address = "123, Barwa City";
            taxPayer.IsVerified = false;

            return taxPayer;
        }
    }
}
    
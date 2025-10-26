using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyVerification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SAPPaymentController : ControllerBase
    {
       

        // POST api/<SAPPaymentController>
        [HttpPost]
        public ActionResult Post([FromBody] SAPPayment value)
        {
            value.Status = "SAP000000";
            //print the json object to the console
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(value));

            return Ok(value);   
        }

    }
}

using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CompanyVerification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class XPIController : ControllerBase
    {
        // POST api/<XPIController>
        [HttpPost]
        public ActionResult Post([FromBody] XPIPayment xpiPayment)
        {
            XPIPayment payment = new XPIPayment
            {
                PaymentId = xpiPayment.PaymentId,
                PayerName = xpiPayment.PayerName,
                Amount = xpiPayment.Amount,
                PaymentDate = xpiPayment.PaymentDate,
                PaymentType = xpiPayment.PaymentType,
                PayerEmail = xpiPayment.PayerEmail,
                mociAccountID = xpiPayment.mociAccountID,
                Remarks = xpiPayment.Remarks,
                taxPayerID = xpiPayment.taxPayerID,
                PaymentStatus = "Processed"
            };
            //print the json object to the console
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(payment));

            return Ok(payment);
        }

      
    }
}

using AddressBook.Helper;
using AddressBook.Modules;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllEmail(string id)
        {
            EmailHelper helper=new EmailHelper();
            return Ok(helper.GetDyanamic(id));
        }

        //[HttpGet("GetEmailByPersonId")]
        //public IActionResult GetEmailByPersonId(string id)
        //{
        //    EmailHelper helper = new EmailHelper();
            
        //    return Ok(helper.GetEmailAddressesByPersonId(id));
        //}

        [HttpPost]
        public IActionResult AddEmail(EmailAddress emailAddress)
        {
            EmailHelper helper = new EmailHelper();
            helper.AddEmailsByDictionary(emailAddress);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateEmail(EmailAddress EAddress)
        {
            EmailHelper helper = new EmailHelper();
            helper.UpdateEmailId(EAddress);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteEmail(string emailId)
        {
            EmailHelper helper = new EmailHelper();
            helper.deleteEmail(emailId);
            return Ok();

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Repository.IRepository;
using Response = Entities.ResponseClass.Response;

namespace RegistrationAndLoginApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegistrationController : Controller
    {
        private readonly IRegistration iregistration;

        public RegistrationController(IRegistration iregistration)
        {
            this.iregistration = iregistration;
        }

        [HttpGet("List_Of_Register_Accounts")]
        public async Task<IActionResult> GetList()
        {
            var GetListOfAcc = await iregistration.GetAllRegistertionAccounts();

            return Ok(GetListOfAcc);
        }


        [HttpPost("Login")]
        public async Task<IActionResult> GetLogin(string Name, string password)
        {
            Response res = new Response();

            try
            {
                res = await iregistration.Login(Name, password);

               // return Ok(res);

            }
            catch (Exception ex)
            {
                res.returnId = -1;
                res.returnCode = "0";
                res.returnStatus = "Error";
                res.returnText = ex.InnerException == null ? ex.Message.ToString() : ex.InnerException.ToString() + " " + ex.Message.ToString();
                res.returnObject = null;

            }
            return Ok(res);


        }

    }
}

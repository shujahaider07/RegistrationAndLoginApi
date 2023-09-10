using Microsoft.AspNetCore.Mvc;
using Repository.IRepository;

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
    }
}

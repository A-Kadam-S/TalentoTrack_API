
using Microsoft.AspNetCore.Mvc;
using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Common.Service;

namespace TalentoTrack_API.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class AccountController : ControllerBase
    {
        

        private readonly ILogger<AccountController> _logger;
        private readonly IAccountService _accountService;

        public AccountController(ILogger<AccountController> logger, IAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;

        }

        [HttpPost(Name = "Login")]

        public async Task<LoginResponse> Login([FromBody]LoginRequest request)
        {
           var response = await _accountService.VerifyLoginDetails(request);
           
            return response;
        }
    }
}

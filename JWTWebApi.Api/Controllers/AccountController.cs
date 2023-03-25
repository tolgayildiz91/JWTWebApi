using JWTWebApi.Domain.Entities.Concrete;
using JWTWebApi.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace JWTWebApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAppUserRepository _appUserRepository;

        public AccountController(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }

        [HttpPost]
        public IActionResult Authenticate([FromBody]AppUser appUser)
        {
            var user = _appUserRepository.Authentication(appUser.UserName, appUser.Password);
            return Ok(user.Result.Token);
          
        }





    }
}

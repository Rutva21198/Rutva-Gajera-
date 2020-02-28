using Microsoft.AspNetCore.Mvc;
using System.Linq;
using FBRxweb.Domain.FacebookUserModule;
using FBRxweb.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace FBRxweb.Api.Controllers.FacebookUserModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class FacebookUsersController : BaseDomainController<FacebookUser,FacebookUser>

    {
        public FacebookUsersController(IFacebookUserDomain domain):base(domain) {}

    }
}

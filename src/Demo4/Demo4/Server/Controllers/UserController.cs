using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo4.Server.Service;
using Demo4.Shared;
using Microsoft.Extensions.Logging;

namespace Demo4.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly ILogger logger;
        private readonly MyServer mySrv;

        public UserController(ILogger<TestController> _logger, MyServer _srv)
        {
            logger = _logger;
            mySrv = _srv;
        }

        [HttpPost]
        [Route("NewUser")]
        // Hvordan beskytte Rest API endpoints?
        // [Authorize(Users = "Alice,Bob")]
        // [Authorize(Roles = "Administrators")]
        public async Task<ActionResult> NewEmployee(AppUser appuser)
        {
            // Hvorfor er denne koden uten errorhandling? 
            // For å holde koden oversiktelig for demo.  
            // Hvordan burde man gjøre det? Se under

            // Hvordan gjøre Authorize i kode
            //if (User.IsInRole("Administrators"))
            //{ ..
            //}


            logger.LogInformation("New user {UserName}", appuser);
            int? usernumber = await mySrv.NewUser(appuser);
            return Ok(usernumber);
        }



        // Error handling på Rest API - Recommended
        // https://docs.microsoft.com/en-us/aspnet/core/web-api/handle-errors?view=aspnetcore-5.0

        // Hvorfor det ikke finnes egne return types types av typen ERROR, internal error, etc. 
        // https://github.com/dotnet/aspnetcore/issues/13579

        /*
         * INFO: Derived fra ObjectResultClass: 

            Microsoft.AspNetCore.Mvc.AcceptedAtActionResult
            Microsoft.AspNetCore.Mvc.AcceptedAtRouteResult
            Microsoft.AspNetCore.Mvc.AcceptedResult
            Microsoft.AspNetCore.Mvc.BadRequestObjectResult
            Microsoft.AspNetCore.Mvc.ConflictObjectResult
            Microsoft.AspNetCore.Mvc.CreatedAtActionResult
            Microsoft.AspNetCore.Mvc.CreatedAtRouteResult
            Microsoft.AspNetCore.Mvc.CreatedResult
            Microsoft.AspNetCore.Mvc.NotFoundObjectResult
            Microsoft.AspNetCore.Mvc.OkObjectResult
            Microsoft.AspNetCore.Mvc.UnauthorizedObjectResult
            Microsoft.AspNetCore.Mvc.UnprocessableEntityObjectResult
            System.Web.Http.BadRequestErrorMessageResult
            System.Web.Http.ExceptionResult
            System.Web.Http.InvalidModelStateResult
            System.Web.Http.NegotiatedContentResult<T>
            System.Web.Http.ResponseMessageResult
        */

        [HttpPost]
        [Route("SetUser")]
        public async Task<ActionResult> SetUser(AppUser appuser)
        {
            logger.LogInformation("Set User {UserName}", appuser);
            AppUser usr = await mySrv.SetUser(appuser);
            return Ok(usr);
        }
    }
}

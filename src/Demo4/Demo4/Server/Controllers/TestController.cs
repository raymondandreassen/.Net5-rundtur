using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo4.Server.Service;
using Demo4.Shared;

namespace Demo4.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ILogger logger;
        private readonly MyServer mySrv;


        public TestController(ILogger<TestController> _logger, MyServer _srv)
        {
            logger = _logger;
            mySrv = _srv;
        }


         
        [HttpGet]
        [Route("GetTheKey")]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult GetTheKey()
        {
            System.Threading.Thread.Sleep(200); // Bare så man ser at noe skjer
            return Ok(mySrv.GetTheKey());
        }


        /// <summary>
        /// Get a list of fake countries
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///        "Countries": 100,
        ///        "Pause": 100
        ///     }
        ///
        /// </remarks>
        /// <param name="Countries"></param>
        /// <param name="Pause"></param>
        /// <returns>A list of countries</returns>
        /// <response code="201">A list of countries</response>
        /// <response code="500">Internal error</response>    
  
        [HttpPost]
        [Route("GetCountries")]
        public ActionResult GetCountries(RequestContries req)
        {
            try
            {
                return Ok(mySrv.GetCountries(req));
            }
            catch (Exception exc)
            {
                logger.LogError(exc, "Error at GetCountries");
                return StatusCode(StatusCodes.Status500InternalServerError, "Intern feil ved GetCountries");
            }
        }
    }
}

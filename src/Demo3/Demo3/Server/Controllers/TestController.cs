using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo3.Shared;

namespace Demo3.Server.Controllers
{

    //[Authorize]
    //[Route("api/[controller]")] - Spesifiserer for hver enkelt
    [ApiController]
    public class TestController : ControllerBase
    {


        [Route("api/TestMessage")]
        [HttpPost]
        public IActionResult TestMessage(TestMessage melding)
        {
            TestMessageResponse tmr = new TestMessageResponse()
            {
                navn = $"{melding.fornavn} {melding.etternavn}",
                svar = $"Hello, {melding.fornavn}",
                noe = new string[] { melding.fornavn, melding.etternavn, "og det var navnene i et array" },
                baretull = new List<string>()
            };

            tmr.baretull.Add("En tekst");
            tmr.baretull.Add("Nok en tekst");
            tmr.baretull.Add("Mere tekst");
            tmr.baretull.Add("Siste tekst");
            return new OkObjectResult(tmr);
        }
    }





}

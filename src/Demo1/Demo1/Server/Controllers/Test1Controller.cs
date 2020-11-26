using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo1.Server.Services;

namespace Demo1.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class Test1Controller : ControllerBase
    {
        private readonly ILogger<Test1Controller> _logger;
        private readonly SingeltonService _singletonservice;
        private readonly TransientService _transientservice;
        private readonly AppServer _appserver;


        internal Test1Controller(ILogger<Test1Controller> logger, SingeltonService singletonservice, TransientService transientservice, AppServer appserver)
        {
            _logger = logger;
            _singletonservice = singletonservice;
            _transientservice = transientservice;
            _appserver = appserver;
        }
    }
}

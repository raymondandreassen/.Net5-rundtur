using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo4.Server.Service;
using Demo4.Shared;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Demo4.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly ILogger logger;
        private readonly DatabaseContext db;

        public QuestionController(
            ILogger<QuestionController> logger,
            DatabaseContext db)
        {
            this.logger = logger;
            this.db = db;
        }

        [HttpGet]
        [Authorize Roles(Admin, SuperUser)]
        [Route("GetQuestion")]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult GetQuestion(int quizId)
        {
            logger.LogInformation("GetQuestion {quizId}");

            var obj = db.Questionares
                .Include(c => c.Questions)
                .ThenInclude(d => d.AnswerAlternatives)
                .Where(e => e.QuestId.Equals(quizId));

            logger.LogInformation("GetQuestion result", obj);

            return Ok(obj);
        }
    }
}

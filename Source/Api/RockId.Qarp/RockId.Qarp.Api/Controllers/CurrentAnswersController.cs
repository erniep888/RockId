using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RockId.Qarp.Api.Service;

namespace RockId.Qarp.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class CurrentAnswersController : ControllerBase
    {
        private readonly IQarpService _qarpService;

        public CurrentAnswersController(IQarpService qarpService)
        {
            _qarpService = qarpService;
        }

        // GET: api/currentanswers/1
        [HttpGet("{currentQuestionId}", Name = "GetCurrentAnswersByCurrentQuestionId")]
        public ICollection<DataMapper.Models.Qarp> Get(int currentQuestionId)
        {
            return _qarpService.GetCurrentAnswers(currentQuestionId);
        }

    }
}
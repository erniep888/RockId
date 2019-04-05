using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RockId.Qarp.Api.Service;

namespace RockId.Qarp.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]    
    public class NextQuestionController : ControllerBase
    {
        private readonly IQarpService _qarpService;

        public NextQuestionController(IQarpService qarpService)
        {
            _qarpService = qarpService;
        }

        // GET: api/nextquestion
        [HttpGet(Name = "GetNextQuestionByEmptyAnswerId")]
        public DataMapper.Models.Qarp Get()
        {
            return _qarpService.GetNextQuestion(null);
        }

        // GET: api/nextquestion/1
        [HttpGet("{selectedAnswerId}", Name = "GetNextQuestionBySelectedAnswerId")]
        public DataMapper.Models.Qarp Get(int? selectedAnswerId)
        {
            return _qarpService.GetNextQuestion(selectedAnswerId);
        }

    }
}

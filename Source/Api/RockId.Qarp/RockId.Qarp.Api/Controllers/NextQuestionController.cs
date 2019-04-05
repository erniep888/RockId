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

        // GET: api/NextQuestion
        [HttpGet]
        public DataMapper.Models.Qarp Get()
        {
            return _qarpService.GetNextQuestion(null);
        }

        // GET: api/NextQuestion/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/NextQuestion
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/NextQuestion/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

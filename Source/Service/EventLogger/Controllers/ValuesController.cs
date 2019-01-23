using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventLogger.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EventLogger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        IEventLoggerRepository _eventLoggerRepository;
        public ValuesController(IEventLoggerRepository eventLoggerRepository)
        {
            _eventLoggerRepository = eventLoggerRepository;
        }

        // GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(_eventLoggerRepository.FindAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

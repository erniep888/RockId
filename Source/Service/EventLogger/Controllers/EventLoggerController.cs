using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventLogger.Models;
using EventLogger.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventLogger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventLoggerController : ControllerBase
    {
        IEventLoggerRepository _eventLoggerRepository;

        public EventLoggerController(IEventLoggerRepository eventLoggerRepository)
        {
            _eventLoggerRepository = eventLoggerRepository;
        }

        // GET: api/EventLogger
        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(_eventLoggerRepository.FindAll());
        }

        // POST: api/EventLogger
        [HttpPost]
        public JsonResult Post([FromBody] RockIdEvent rockIdEvent)
        {
            rockIdEvent.EventStoredDateTimeUTC = DateTime.UtcNow;
            rockIdEvent = _eventLoggerRepository.Save(rockIdEvent);
            return new JsonResult(rockIdEvent);
        }

    }
}

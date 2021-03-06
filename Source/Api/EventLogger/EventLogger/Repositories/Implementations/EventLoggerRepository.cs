﻿using EventLogger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventLogger.Repositories;

namespace EventLogger.Repositories.Implementations
{
    public class EventLoggerRepository : IEventLoggerRepository
    {
        private EventLoggerContext _eventLoggerContext;
        public EventLoggerRepository(EventLoggerContext eventLoggerContext)
        {
            _eventLoggerContext = eventLoggerContext;
        }

        public List<RockIdEvent> FindAll()
        {
            return _eventLoggerContext.Events.ToList<RockIdEvent>();
        }

        public RockIdEvent Save(RockIdEvent rockIdEvent)
        {
            var savedEvent = _eventLoggerContext.Add(rockIdEvent);
            _eventLoggerContext.SaveChanges();
            return savedEvent.Entity;
        }
    }
}

using EventLogger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventLogger.Repositories
{
    public interface IEventLoggerRepository
    {
        List<RockIdEvent> FindAll();
        RockIdEvent Save(RockIdEvent rockIdEvent);
    }
}

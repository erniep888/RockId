using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventLogger.Models
{
    public class EventLoggerContext : DbContext
    {
        public EventLoggerContext(DbContextOptions<EventLoggerContext> options) : base(options)
        {

        }

        public DbSet<RockIdEvent> Events { get; set; }
    }
}

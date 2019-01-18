using Microsoft.EntityFrameworkCore;
using RockId.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockId.Domain.Repositories.Implementations
{
    public class RockIdDbContext : DbContext    
    {
        public RockIdDbContext()
        {
        }

        public RockIdDbContext(DbContextOptions<RockIdDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Rock> Rocks { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RockId.Domain.Models
{
    public class Rock : Updatable
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}

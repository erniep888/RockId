using System;
using System.Collections.Generic;
using System.Text;

namespace RockId.Domain.Models
{
    public class Rock : Updatable
    {
        public Guid Id { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }
    }
}

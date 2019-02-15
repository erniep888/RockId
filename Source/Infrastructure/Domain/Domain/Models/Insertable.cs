using System;
using System.Collections.Generic;
using System.Text;

namespace RockId.Domain.Models
{
    public abstract class Insertable
    {
        public DateTime CreateDateUtc { get; set; }
        public string CreatedBy { get; set; }

    }
}

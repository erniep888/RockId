using System;
using System.Collections.Generic;
using System.Text;

namespace RockId.Domain.Models
{
    public class RockIdEvent : Insertable
    {
        public Guid Guid { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
    }
}

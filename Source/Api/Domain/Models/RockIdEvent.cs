using System;
using System.Collections.Generic;
using System.Text;

namespace RockId.Domain.Models
{
    public class RockIdEvent : Insertable
    {
        public Guid Guid { get; set; }
        public String Type { get; set; }
        public String Description { get; set; }
    }
}

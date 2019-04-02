﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RockId.Common.Models
{
    public abstract class Updatable : Insertable
    {
        public DateTime UpdateDateUtc { get; set; }
        public string UpdatedBy { get; set; }
    }
}
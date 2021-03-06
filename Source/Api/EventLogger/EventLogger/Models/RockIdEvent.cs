﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventLogger.Models
{
    public class RockIdEvent
    {
        public int RockIdEventId { get; set; }
        public string EventTitle { get; set; }
        public string EventSource { get; set; }
        public  DateTime EventDateTimeUTC { get; set; }        
        public DateTime EventStoredDateTimeUTC { get; set; }
        public string User { get; set; }
    }
}

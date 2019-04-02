using RockId.Common.Models;
using System;
using System.Collections.Generic;

namespace RockId.Qarp.DataMapper.Models
{
    public partial class Qarp : Updatable
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public bool IsQuestion { get; set; }
        public string DisplayText { get; set; }
        public int DisplayOrder { get; set; }
        public string RockType { get; set; }
    }
}

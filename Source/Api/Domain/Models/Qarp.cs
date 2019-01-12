using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// QARP - Question, Answer, and Result Process.
/// Provides the data behind the bidirectional QA workflow.
/// </summary>
namespace RockId.Domain.Models
{
    public class Qarp : Updatable
    {
        public Guid Id { get; set; }

        public string Question { get; set; }

        public Guid Rock { get; set; }
        public List<Qarp> Choices { get; set; }
    }
}

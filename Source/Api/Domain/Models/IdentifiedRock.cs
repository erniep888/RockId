using System;

namespace RockId.Domain.Models
{
    public class IdentifiedRock : Updatable
    {
        public Guid Id { get; set; }

        public Guid Rock { get; set; }

    }
}
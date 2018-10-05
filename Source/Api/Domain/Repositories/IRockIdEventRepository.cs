using RockId.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockId.Domain.Repositories
{
    public interface IRockIdEventRepository
    {
        RockIdEvent Save(RockIdEvent rockIdEvent);
    }
}

using RockId.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockId.Domain.Repositories
{
    public interface IRockRepository
    {
        Rock FindByName(String name);
        Rock FindById(Guid id);
        Rock Save(Rock rock);
    }
}

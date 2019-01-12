using RockId.Domain.Models;
using System;

namespace RockId.Domain.Repositories
{
    public interface IRockRepository
    {
        Rock FindByName(string name);
        Rock FindById(Guid id);
        Rock Save(Rock rock);
    }
}

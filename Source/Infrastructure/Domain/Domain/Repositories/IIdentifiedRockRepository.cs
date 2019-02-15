using RockId.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockId.Domain.Repositories
{
    public interface IIdentifiedRockRepository
    {
        List<IdentifiedRock> FindAll();
        List<IdentifiedRock> FindByRock(Rock rock);
        IdentifiedRock FindById(Guid id);
        IdentifiedRock Save(IdentifiedRock identifiedRock);
    }
}

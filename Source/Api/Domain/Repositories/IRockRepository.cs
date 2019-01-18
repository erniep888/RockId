using RockId.Domain.Models;
using System;
using System.Threading.Tasks;

namespace RockId.Domain.Repositories
{
    public interface IRockRepository : IDisposable
    {
        Rock FindByName(string name);
        Task<Rock> FindById(Guid id);
        void InsertRock(Rock rock);
        void DeleteRock(Rock rock);
        void DeleteRock(Guid id);
        void UpdateRock(Rock rock);
        void Save(Rock rock);
    }
}

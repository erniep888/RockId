using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RockId.Domain.Models;

namespace RockId.Domain.Repositories.Implementations
{
    public class RockRepository : IRockRepository
    {
        private RockIdDbContext _rockIdDbContext;
        public RockRepository(RockIdDbContext rockIdDbContext)
        {
            _rockIdDbContext = rockIdDbContext;
        }        

        public async Task<Rock> FindById(Guid id)
        {
            return await _rockIdDbContext.Rocks.SingleOrDefaultAsync(rock => rock.Id == id);
        }

        public Rock FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public void InsertRock(Rock rock)
        {
            _rockIdDbContext.Rocks.Add(rock);
        }

        public void UpdateRock(Rock rock)
        {
            _rockIdDbContext.Entry(rock).State = EntityState.Modified;
        }
        public void DeleteRock(Rock rock)
        {
            _rockIdDbContext.Rocks.Remove(rock);
        }

        public void DeleteRock(Guid id)
        {
            Rock rock = _rockIdDbContext.Rocks.Find(id);
            this.DeleteRock(rock);
        }
        public void Save(Rock rock)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using RockId.Qarp.DataMapper.Models;
using System.Linq;

namespace RockId.Qarp.DataMapper.Repositories.Implementations
{
    public class QarpRepository : IQarpRepository
    {
        private RockIdQarpContext _context;

        public QarpRepository(RockIdQarpContext rockIdQarpContext)
        {
            this._context = rockIdQarpContext;
        }

        public Models.Qarp FindById(int id)
        {
            return this._context.Qarps.Find(id);
        }

        public IList<Models.Qarp> FindByParentId(int? parentId)
        {
            return (from q in _context.Qarps
                    where q.ParentId == parentId
                    select q).ToList<Models.Qarp>();            
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

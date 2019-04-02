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

        public ICollection<Models.Qarp> FindByParentId(int? parentId)
        {
            var results = (from q in _context.Qarps
                           select q).ToList();
            throw new NotImplementedException();
        }

        public Models.Qarp Save(Models.Qarp qarp)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace RockId.Qarp.DataMapper.Repositories
{
    public interface IQarpRepository
    {
        Models.Qarp FindById(int id);

        IList<Models.Qarp> FindByParentId(int? parentId);

        void Save();
    }
}

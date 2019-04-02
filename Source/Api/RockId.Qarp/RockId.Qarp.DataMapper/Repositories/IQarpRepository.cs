using System;
using System.Collections.Generic;
using System.Text;

namespace RockId.Qarp.DataMapper.Repositories
{
    interface IQarpRepository
    {
        Models.Qarp FindById(int id); 
        
        ICollection<Models.Qarp> FindByParentId(int? parentId);

        Models.Qarp Save(Models.Qarp qarp);
    }
}

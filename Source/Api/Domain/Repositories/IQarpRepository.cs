using RockId.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockId.Domain.Repositories
{
    public interface IQarpRepository
    {
        Qarp FindById(Guid id);
        Qarp FindRoot();
        Qarp FindNext(Qarp choice);
        Qarp FindParentOf(Qarp current);
    }
}

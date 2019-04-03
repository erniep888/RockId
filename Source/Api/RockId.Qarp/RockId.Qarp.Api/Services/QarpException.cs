using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockId.Qarp.Api.Services
{
    public class QarpException : Exception
    {
        public QarpException(string message) 
            : base(message)
        {
        }
    }
}

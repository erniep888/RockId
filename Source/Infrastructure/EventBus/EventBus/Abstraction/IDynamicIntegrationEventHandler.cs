using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RockId.EventBus.Abstraction
{
    public interface IDynamicIntegrationEventHandler
    {
        Task Handle(dynamic eventData);
    }
}

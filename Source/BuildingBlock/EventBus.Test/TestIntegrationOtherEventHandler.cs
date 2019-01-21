﻿using RockId.EventBus.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RockId.EventBus.Test
{
    public class TestIntegrationOtherEventHandler : IIntegrationEventHandler<TestIntegrationEvent>
    {
        public bool Handled { get; private set; }

        public TestIntegrationOtherEventHandler()
        {
            Handled = false;
        }

#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public async Task Handle(TestIntegrationEvent @event)
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {
            Handled = true;
        }
    }
}

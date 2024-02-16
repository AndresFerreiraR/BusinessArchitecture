using MassTransit;
using Pacagroup.Ecommerce.Application.Interface.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacagroup.Ecommerce.Interface.EventBus
{
    public class EventBusRabbitMq : IEventBus
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public EventBusRabbitMq(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        public async void Publish<T>(T @entity)
        {
            await _publishEndpoint.Publish(@entity);
        }
    }
}

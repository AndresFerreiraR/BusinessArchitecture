
namespace Pacagroup.Ecommerce.Interface
{
    using MassTransit;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Options;
    using Pacagroup.Ecommerce.Application.Interface.Infraestructure;
    using Pacagroup.Ecommerce.Interface.EventBus;
    using Pacagroup.Ecommerce.Interface.EventBus.Options;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public static class ConfigureServices
    {
        public static IServiceCollection AddInfraestructureServices(this IServiceCollection services) 
        {
            services.ConfigureOptions<RabbitMqOptionsSetup>();

            services.AddScoped<IEventBus, EventBusRabbitMq>();

            services.AddMassTransit(x =>
            {
                x.UsingRabbitMq((context, config) =>
                {
                    RabbitMqOptions? opt = services.BuildServiceProvider()
                    .GetRequiredService<IOptions<RabbitMqOptions>>()
                    .Value;

                    config.Host(opt.HostName, opt.VirtualHost, h =>
                    {
                        h.Username(opt.UserName);
                        h.Password(opt.Password);
                    });

                    config.ConfigureEndpoints(context);
                });
            });


            return services;
        }
    }
}

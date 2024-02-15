
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json.Serialization;

namespace Pacagroup.Ecommerce.Services.WebApi.Modules.Feature
{
    public static class FeatureExtensions
    {
        public static IServiceCollection AddFeature(this IServiceCollection services, IConfiguration configuration)
        {

            string myPolicy = "PolicyApiEcommerce";

            services.AddCors(options => options.AddPolicy(myPolicy, builder => builder.WithOrigins(configuration["Config:OriginCors"])
                                                                                           .AllowAnyHeader()
                                                                                           .AllowAnyMethod()));
            services.AddControllers().AddJsonOptions(opt =>
            {
                var enumConverter = new JsonStringEnumConverter();
                opt.JsonSerializerOptions.Converters.Add(enumConverter);
            });
            services.AddMvc();


            return services;
        }
    }
}

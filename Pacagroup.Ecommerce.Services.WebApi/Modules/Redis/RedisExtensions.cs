namespace Pacagroup.Ecommerce.Services.WebApi.Modules.Redis
{
    public static class RedisExtensions
    {
        public static IServiceCollection AddRedis(this IServiceCollection services, IConfiguration _configuration)
        {
            services.AddStackExchangeRedisCache(opt =>
            {
                opt.Configuration = _configuration.GetConnectionString("RedisConnectionString");
            });
            return services;
        }
    }
}

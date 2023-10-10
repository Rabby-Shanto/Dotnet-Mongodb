using Microsoft.Extensions.DependencyInjection;
using MongoDbSharp.Abstractions.BLL;
using MongoDbSharp.Abstractions.Repository;
using MongoDbSharp.BLL;
using MongoDbSharp.Repository;

namespace MongoDbSharp.Configurations
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddConfiguration(this IServiceCollection services)
        {
            #region Entity
            services.AddScoped<IEntity, EntityManager>();
            services.AddScoped<IEntityRepository,EntityRepository>();
            #endregion
            
            return services;
        }
    }
}

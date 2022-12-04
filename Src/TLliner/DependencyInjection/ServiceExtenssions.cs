using TLiner.Data;
using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using TLiner.Services;

namespace TLliner.DependencyInjection
{
    internal static class ServiceExtenssions
    {
        public static IServiceCollection AddConfiguration(this IServiceCollection services, string basePath)
        {
            return services
                .AddSingleton<IConfigurationProvider>(s => new ConfigurationProvider(basePath));
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddSingleton<IAppState, AppState>()
                .AddScoped<IAttributeModelService, AttributeModelService>()
                .AddScoped<IAttributeService, AttributeService>()
                .AddScoped<IEntityModelService, EntityModelService>()
                .AddScoped<IEntityService, EntityService>()
                .AddScoped<IProjectService, ProjectService>()
                .AddScoped<IRelationModelService, RelationModelService>()
                .AddScoped<IRelationService, RelationService>()
                .AddScoped<ITimeUnitModelService, TimeUnitModelService>()
                .AddScoped<IServiceAggregator>(s => new ServiceAggregator
                {
                    AttributeModelService = s.GetService<IAttributeModelService>(),
                    AttributeService = s.GetService<IAttributeService>(),
                    EntityModelService = s.GetService<IEntityModelService>(),
                    EntityService = s.GetService<IEntityService>(),
                    ProjectService = s.GetService<IProjectService>(),
                    RelationModelService = s.GetService<IRelationModelService>(),
                    RelationService = s.GetService<IRelationService>(),
                    TimeUnitModelService = s.GetService<ITimeUnitModelService>()
                })
                .AddScoped<ITLinerService, TLinerService>();
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped<IAttributeModelRepository, AttributeModelRepository>()
                .AddScoped<IAttributeRepository, AttributeRepository>()
                .AddScoped<IEntityModelRepository, EntityModelRepository>()
                .AddScoped<IEntityRepository, EntityRepository>()
                .AddScoped<IProjectRepository, ProjectRepository>()
                .AddScoped<IRelationModelRepository, RelationModelRepository>()
                .AddScoped<IRelationRepository, RelationRepository>()
                .AddScoped<ITimeUnitModelRepository, TimeUnitModelRepository>();
        }
    }
}
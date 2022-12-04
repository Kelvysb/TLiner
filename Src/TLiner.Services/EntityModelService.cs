using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using TLiner.Domain.Entities;

namespace TLiner.Services
{
    public class EntityModelService : ServiceBase<EntityModel>, IEntityModelService
    {
        public EntityModelService(IAppState appState, IConfigurationProvider configuration, IEntityModelRepository repository)
            : base(appState, configuration, repository)
        {
        }
    }
}
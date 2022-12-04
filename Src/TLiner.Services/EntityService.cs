using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using TLiner.Domain.Entitites;

namespace TLiner.Services
{
    public class EntityService : ServiceBase<Entity>, IEntityService
    {
        public EntityService(IAppState appState, IConfigurationProvider configuration, IEntityRepository repository)
            : base(appState, configuration, repository)
        {
        }
    }
}
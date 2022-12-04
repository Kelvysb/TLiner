using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using TLiner.Domain.Entitites;

namespace TLiner.Services
{
    public class RelationService : ServiceBase<Relation>, IRelationService
    {
        public RelationService(IAppState appState, IConfigurationProvider configuration, IRelationRepository repository)
            : base(appState, configuration, repository)
        {
        }
    }
}
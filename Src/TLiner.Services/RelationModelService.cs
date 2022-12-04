using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using TLiner.Domain.Entitites.Models;

namespace TLiner.Services
{
    public class RelationModelService : ServiceBase<RelationModel>, IRelationModelService
    {
        public RelationModelService(IAppState appState, IConfigurationProvider configuration, IRelationModelRepository repository)
            : base(appState, configuration, repository)
        {
        }
    }
}
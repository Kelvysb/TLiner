using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using TLiner.Domain.Entities;

namespace TLiner.Data
{
    public class EntityModelRepository : RepositoryBase<EntityModel>, IEntityModelRepository
    {
        public EntityModelRepository(IAppState appState) : base("entity_models", appState)
        {
        }

        protected override void CreateIndexes()
        {
            Collection.EnsureIndex(e => e.ProjectId);
        }
    }
}
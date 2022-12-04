using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using TLiner.Domain.Entitites;

namespace TLiner.Data
{
    public class EntityRepository : RepositoryBase<Entity>, IEntityRepository
    {
        public EntityRepository(IAppState appState) : base("entities", appState)
        {
        }

        protected override void CreateIndexes()
        {
            Collection.EnsureIndex(e => e.ProjectId);
            Collection.EnsureIndex(e => e.ModelId);
        }
    }
}
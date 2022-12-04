using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using TLiner.Domain.Entitites;

namespace TLiner.Data
{
    public class RelationRepository : RepositoryBase<Relation>, IRelationRepository
    {
        public RelationRepository(IAppState appState) : base("relations", appState)
        {
        }

        protected override void CreateIndexes()
        {
            Collection.EnsureIndex(e => e.ProjectId);
            Collection.EnsureIndex(e => e.ModelId);
        }
    }
}
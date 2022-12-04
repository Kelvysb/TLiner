using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using TLiner.Domain.Entitites.Models;

namespace TLiner.Data
{
    public class RelationModelRepository : RepositoryBase<RelationModel>, IRelationModelRepository
    {
        public RelationModelRepository(IAppState appState) : base("relation_models", appState)
        {
        }

        protected override void CreateIndexes()
        {
            Collection.EnsureIndex(e => e.ProjectId);
        }
    }
}
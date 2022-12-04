using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using TLiner.Domain.Entities;

namespace TLiner.Data
{
    public class AttributeModelRepository : RepositoryBase<AttributeModel>, IAttributeModelRepository
    {
        public AttributeModelRepository(IAppState appState) : base("attribute_models", appState)
        {
        }

        protected override void CreateIndexes()
        {
            Collection.EnsureIndex(e => e.ProjectId);
        }
    }
}
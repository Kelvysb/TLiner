using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using Attribute = TLiner.Domain.Entitites.Attribute;

namespace TLiner.Data
{
    public class AttributeRepository : RepositoryBase<Attribute>, IAttributeRepository
    {
        public AttributeRepository(IAppState appState) : base("attributes", appState)
        {
        }

        protected override void CreateIndexes()
        {
            Collection.EnsureIndex(e => e.ProjectId);
            Collection.EnsureIndex(e => e.ModelId);
        }
    }
}
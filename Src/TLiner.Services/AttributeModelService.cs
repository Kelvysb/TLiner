using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using TLiner.Domain.Entities;

namespace TLiner.Services
{
    public class AttributeModelService : ServiceBase<AttributeModel>, IAttributeModelService
    {
        public AttributeModelService(IAppState appState, IConfigurationProvider configuration, IAttributeModelRepository repository)
            : base(appState, configuration, repository)
        {
        }
    }
}
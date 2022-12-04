using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using Attribute = TLiner.Domain.Entitites.Attribute;

namespace TLiner.Services
{
    public class AttributeService : ServiceBase<Attribute>, IAttributeService
    {
        public AttributeService(IAppState appState, IConfigurationProvider configuration, IAttributeRepository repository)
            : base(appState, configuration, repository)
        {
        }
    }
}
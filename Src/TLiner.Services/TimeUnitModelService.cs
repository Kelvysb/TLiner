using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using TLiner.Domain.Entitites.Models;

namespace TLiner.Services
{
    public class TimeUnitModelService : ServiceBase<TimeUnitModel>, ITimeUnitModelService
    {
        public TimeUnitModelService(IAppState appState, IConfigurationProvider configuration, ITimeUnitModelRepository repository)
            : base(appState, configuration, repository)
        {
        }
    }
}
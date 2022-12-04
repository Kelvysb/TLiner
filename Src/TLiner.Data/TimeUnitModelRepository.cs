using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using TLiner.Domain.Entitites.Models;

namespace TLiner.Data
{
    public class TimeUnitModelRepository : RepositoryBase<TimeUnitModel>, ITimeUnitModelRepository
    {
        public TimeUnitModelRepository(IAppState appState) : base("time_unit_models", appState)
        {
        }

        protected override void CreateIndexes()
        {
            Collection.EnsureIndex(e => e.ProjectId);
            Collection.EnsureIndex(e => e.IsBaseUnit);
            Collection.EnsureIndex(e => e.Multiplier);
        }
    }
}
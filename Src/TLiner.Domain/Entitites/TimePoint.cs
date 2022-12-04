using TLiner.Domain.Entitites.Models;

namespace TLiner.Domain.Entities
{
    public class TimePoint
    {
        public long Value { get; set; }

        public TimeUnitModel TimeUnit { get; set; }
    }
}
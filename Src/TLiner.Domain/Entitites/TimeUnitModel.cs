using TLiner.Domain.Entitites.Bases;

namespace TLiner.Domain.Entitites.Models
{
    public class TimeUnitModel : ModelBase
    {
        public long Multiplier { get; set; }

        public string BaseTimeUnitId { get; set; }

        public bool IsBaseUnit { get; set; }
    }
}
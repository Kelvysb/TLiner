using TLiner.Domain.Entities;
using TLiner.Domain.Entitites.Bases;

namespace TLiner.Domain.Entitites
{
    public class Entity : InstanceBase
    {
        public TimePoint InitialTime { get; set; }

        public TimePoint FinalTime { get; set; }
    }
}
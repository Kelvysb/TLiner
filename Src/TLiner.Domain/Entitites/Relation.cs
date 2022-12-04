using TLiner.Domain.Entities;
using TLiner.Domain.Entitites.Bases;

namespace TLiner.Domain.Entitites
{
    public class Relation : InstanceBase
    {
        public string FirstElementId { get; set; }

        public string SecondElementId { get; set; }

        public TimePoint InitialTime { get; set; }

        public TimePoint FinalTime { get; set; }
    }
}
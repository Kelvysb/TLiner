using TLiner.Domain.Entities;
using TLiner.Domain.Entitites.Bases;
using TLiner.Domain.Entitites.Enums;

namespace TLiner.Domain.Entitites
{
    public class Attribute : InstanceBase
    {
        public string Value { get; set; }

        public TimePoint TimeValue { get; set; }

        public int Sequence { get; set; }

        public AttributeType Type { get; set; }

        public bool IsMultiline { get; set; }
    }
}
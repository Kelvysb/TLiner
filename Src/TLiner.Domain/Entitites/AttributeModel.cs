using TLiner.Domain.Entitites.Bases;
using TLiner.Domain.Entitites.Enums;

namespace TLiner.Domain.Entities
{
    public class AttributeModel : ModelBase
    {
        public int Sequence { get; set; }

        public AttributeType Type { get; set; }

        public bool IsMultiline { get; set; }
    }
}
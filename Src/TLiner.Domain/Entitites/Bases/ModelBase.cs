using TLiner.Domain.Entities;

namespace TLiner.Domain.Entitites.Bases
{
    public abstract class ModelBase : Base
    {
        public string ProjectId { get; set; }

        public List<AttributeModel> Attributes { get; set; }
    }
}
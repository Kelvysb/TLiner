namespace TLiner.Domain.Entitites.Bases
{
    public class InstanceBase : Base
    {
        public string ModelId { get; set; }

        public string ProjectId { get; set; }

        public List<Attribute> Attributes { get; set; }
    }
}
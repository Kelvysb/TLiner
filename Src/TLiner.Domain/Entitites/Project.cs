using TLiner.Domain.Entitites.Bases;

namespace TLiner.Domain.Entities
{
    public class Project : Base
    {
        public string Author { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
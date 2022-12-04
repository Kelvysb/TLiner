using TLiner.Domain.Entitites.Bases;

namespace TLiner.Domain.Abstractions.Services
{
    public interface IServiceBase<TEntity>
        where TEntity : Base, new()
    {
        public TEntity GetById(string id);

        public List<TEntity> GetAll();

        public string Save(TEntity entity);

        public bool DeleteById(string id);

        public List<TEntity> FindByName(string name);

        public List<TEntity> FindByDescription(string description);
    }
}
using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using TLiner.Domain.Entitites.Bases;

namespace TLiner.Services
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity>
        where TEntity : Base, new()
    {
        protected readonly IAppState appState;
        protected readonly IConfigurationProvider configuration;
        protected readonly IRepositoryBase<TEntity> repository;

        protected ServiceBase(
            IAppState appState,
            IConfigurationProvider configuration,
            IRepositoryBase<TEntity> repository)
        {
            this.appState = appState;
            this.configuration = configuration;
            this.repository = repository;
        }

        public virtual bool DeleteById(string id)
        {
            return repository.DeleteById(id);
        }

        public virtual List<TEntity> FindByDescription(string description)
        {
            return repository.FindByDescription(description);
        }

        public virtual List<TEntity> FindByName(string name)
        {
            return repository.FindByName(name);
        }

        public virtual List<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public virtual TEntity GetById(string id)
        {
            return repository.GetById(id);
        }

        public virtual string Save(TEntity entity)
        {
            return repository.Save(entity);
        }
    }
}
using LiteDB;
using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using TLiner.Domain.Entitites.Bases;
using TLiner.Domain.Exceptions;

namespace TLiner.Data
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
        where TEntity : Base, new()
    {
        private readonly string collectionName;
        private readonly IAppState appState;
        private string currentDataBase;
        private LiteDatabase? database;
        private ILiteCollection<TEntity>? collection;

        protected RepositoryBase(string collectionName, IAppState appState)
        {
            this.appState = appState;
            this.collectionName = collectionName;
            currentDataBase = string.Empty;
        }

        protected ILiteCollection<TEntity> Collection { get => GetCollection() ?? throw new UnselectedProjectException(); }

        public virtual bool DeleteById(string id)
        {
            return Collection.Delete(id);
        }

        public virtual List<TEntity> FindByDescription(string description)
        {
            return Collection
                .Find(e => e.Description.Contains(description))
                .ToList();
        }

        public virtual List<TEntity> FindByName(string name)
        {
            return Collection
                .Find(e => e.Name.Contains(name))
                .ToList();
        }

        public virtual List<TEntity> GetAll()
        {
            return Collection
                .FindAll()
                .ToList();
        }

        public virtual TEntity GetById(string id)
        {
            return Collection.FindById(id);
        }

        public virtual string Save(TEntity entity)
        {
            if (string.IsNullOrEmpty(entity.Id))
            {
                entity.Id = Guid.NewGuid().ToString();
            }
            Collection.Upsert(entity);
            return entity.Id;
        }

        protected abstract void CreateIndexes();

        private ILiteCollection<TEntity>? GetCollection()
        {
            if (!appState.IsProjectSelected) throw new UnselectedProjectException();
            if (database == null || currentDataBase != appState.SelectProjectFile)
            {
                database = new LiteDatabase(appState.SelectProjectFile);
                collection = database.GetCollection<TEntity>(collectionName);
            }
            CreateBaseIndexes();
            return collection;
        }

        private void CreateBaseIndexes()
        {
            Collection.EnsureIndex(e => e.Id);
            Collection.EnsureIndex(e => e.Name);
            Collection.EnsureIndex(e => e.Description);
        }
    }
}
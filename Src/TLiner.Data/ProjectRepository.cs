using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using TLiner.Domain.Entities;

namespace TLiner.Data
{
    public class ProjectRepository : RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(IAppState appState) : base("projects", appState)
        {
        }

        protected override void CreateIndexes()
        {
        }
    }
}
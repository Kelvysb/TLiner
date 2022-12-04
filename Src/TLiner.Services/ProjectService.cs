using TLiner.Domain.Abstractions.Data;
using TLiner.Domain.Abstractions.Services;
using TLiner.Domain.Entities;

namespace TLiner.Services
{
    public class ProjectService : ServiceBase<Project>, IProjectService
    {
        public ProjectService(IAppState appState, IConfigurationProvider configuration, IProjectRepository repository)
            : base(appState, configuration, repository)
        {
        }
    }
}
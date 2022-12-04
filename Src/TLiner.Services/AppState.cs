using TLiner.Domain.Abstractions.Services;

namespace TLiner.Services
{
    public class AppState : IAppState
    {
        public string? SelectProjectFile { get; set; }

        public bool IsProjectSelected { get => !string.IsNullOrWhiteSpace(SelectProjectFile); }
    }
}
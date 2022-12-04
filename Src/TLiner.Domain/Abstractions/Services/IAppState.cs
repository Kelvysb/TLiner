namespace TLiner.Domain.Abstractions.Services
{
    public interface IAppState
    {
        string? SelectProjectFile { get; set; }

        bool IsProjectSelected { get; }
    }
}
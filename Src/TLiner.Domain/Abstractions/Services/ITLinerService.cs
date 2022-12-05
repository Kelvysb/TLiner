namespace TLiner.Domain.Abstractions.Services
{
    public interface ITLinerService
    {
        IAppState? AppState { get; }
    }
}
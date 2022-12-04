namespace TLiner.Domain.Abstractions.Services
{
    public interface IConfigurationProvider
    {
        void Save();

        void Load();

        string DataBaseFilePath();
    }
}
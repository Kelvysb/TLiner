using System.Text.Json;
using TLiner.Domain.Abstractions.Models;
using TLiner.Domain.Abstractions.Services;

namespace TLiner.Services
{
    public class ConfigurationProvider : IConfigurationProvider
    {
        private readonly string basePath;
        private readonly string? projectsFolder;
        private readonly string configurationPath;
        private ConfigModel? configModel;

        public ConfigurationProvider(string basePath)
        {
            this.basePath = basePath;
            projectsFolder = EnsureProjectsFolder(basePath);
            configurationPath = Path.Join(basePath, "config.json");
            Load();
        }

        public string DataBaseFilePath() => configModel?.AppFilesPath ?? string.Empty;

        public void Save()
        {
            var file = JsonSerializer.Serialize(configModel);
            File.WriteAllText(configurationPath, file);
        }

        public void Load()
        {
            if (File.Exists(configurationPath))
            {
                var file = File.ReadAllText(configurationPath);
                configModel = JsonSerializer.Deserialize<ConfigModel>(file);
            }
            else
            {
                configModel = DefaultConfig();
                Save();
            }
        }

        private string? EnsureProjectsFolder(string projectsFolderPath)
        {
            var path = Path.Combine(projectsFolderPath, "Projects");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        private ConfigModel DefaultConfig()
        {
            return new ConfigModel
            {
                AppFilesPath = basePath,
                ProjectsFolderPath = projectsFolder
            };
        }
    }
}
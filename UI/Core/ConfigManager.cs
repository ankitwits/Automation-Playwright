using System.Text.Json;

public static class ConfigManager
{
    private static TestSettings? _settings;

    public static TestSettings Settings
    {
        get
        {
            if (_settings == null)
            {
                var json = File.ReadAllText("appsettings.json");
                _settings = JsonSerializer.Deserialize<TestSettings>(json);
            }
            return _settings;
        }
    }
    
}
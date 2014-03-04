namespace StringResourceDemo.Services
{
    using Windows.Storage;

    public class LocalKeyValueStore : IKeyValueStore
    {
        public T GetValue<T>(string key, T defaultValue)
        {
            var settings = ApplicationData.Current.LocalSettings.Values;
            return settings.ContainsKey(key) ? (T)settings[key] : defaultValue;
        }

        public void SetValue<T>(string key, T value)
        {
            var settings = ApplicationData.Current.LocalSettings.Values;
            settings[key] = value;
        }
    }
}

namespace StringResourceDemo.Services
{
    public interface IKeyValueStore
    {
        T GetValue<T>(string key, T defaultValue);
        void SetValue<T>(string key, T value);
    }
}
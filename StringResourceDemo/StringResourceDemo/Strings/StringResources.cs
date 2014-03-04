namespace StringResourceDemo.Strings
{
    using Windows.ApplicationModel.Resources;

    public class StringResources : IStringResources
    {
        public string HelloAgain { get { return GetString("HelloAgain"); } }
        public string Welcome { get { return GetString("Welcome"); } }

        private string GetString(string key)
        {
            return ResourceLoader.GetForCurrentView().GetString(key);
        }
    }
}
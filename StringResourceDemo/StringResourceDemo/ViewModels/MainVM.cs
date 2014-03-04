namespace StringResourceDemo.ViewModels
{
    using Services;
    using Strings;

    public class MainVM
    {
        // Parameterless constructor used at design-time
        public MainVM()
        {
            Message = "SampleText";
        }

        // Constructor used at run-time
        public MainVM(IStringResources stringResources, IKeyValueStore keyValueStore)
        {
            Message = FirstTime(keyValueStore)
                ? stringResources.Welcome
                : stringResources.HelloAgain;
        }

        public string Message { get; set; }

        public bool FirstTime(IKeyValueStore keyValueStore)
        {
            var firstTime = keyValueStore.GetValue("FirstTime", true);
            keyValueStore.SetValue("FirstTime", false);
            return firstTime;
        }
    }
}
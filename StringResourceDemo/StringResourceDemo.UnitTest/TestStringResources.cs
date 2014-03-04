namespace StringResourceDemo.UnitTest
{
    using Strings;

    public class TestStringResources : IStringResources
    {
        public string HelloAgain { get { return "HelloAgain"; } }
        public string Welcome { get { return "Welcome"; } }
    }
}
namespace Framework
{
    public class _framework_config
    {
        public DriverSettings Driver { get; set; }
        public TestSettings Test { get; set; }
    }

    public class DriverSettings
    {
        public string Browser { get; set; }
    }

    public class TestSettings
    {
        public string URL { get; set; }
    }
}

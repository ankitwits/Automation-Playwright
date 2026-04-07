public class DriverFactory
{
    public static IDriverManager GetDriver(string browser)
    {
        return browser switch
        {
            "chrome" => new ChromeDriverManager(),
            "firefox" => new FirefoxDriverManager(),
            _ => throw new Exception("Invalid browser")
        };
    }
}
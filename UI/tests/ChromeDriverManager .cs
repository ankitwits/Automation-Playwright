using Microsoft.Playwright;

public class ChromeDriverManager : IDriverManager
{
    public async Task<IBrowser> GetDriver()
    {
        var playwright = await Playwright.CreateAsync();
        return await playwright.Chromium.LaunchAsync();
    }
}
using Microsoft.Playwright;

public class FirefoxBrowser : IBrowserFactory
{
    public async Task<IBrowser> LaunchBrowserAsync(IPlaywright playwright)
    {
        return await playwright.Firefox.LaunchAsync();
    }
}
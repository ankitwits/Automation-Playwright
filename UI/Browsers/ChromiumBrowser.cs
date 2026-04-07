using Microsoft.Playwright;

public class ChromiumBrowser : IBrowserFactory
{
    public async Task<IBrowser> LaunchBrowserAsync(IPlaywright playwright)
    {
        return await playwright.Chromium.LaunchAsync();
    }
}
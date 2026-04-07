using Microsoft.Playwright;
public static class BrowserFactory
{
    public static async Task<IBrowser> CreateBrowser(IPlaywright playwright, string browserName)
    {
        return browserName.ToLower() switch
        {
            "chromium" => await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{Headless = false }),            
            "firefox"  => await playwright.Firefox.LaunchAsync(new BrowserTypeLaunchOptions{Headless = false }),
            "webkit"   => await playwright.Webkit.LaunchAsync(new BrowserTypeLaunchOptions{Headless = false }),
            _ => throw new ArgumentException($"Unsupported browser: {browserName}")
        };
    }
}
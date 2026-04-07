using Microsoft.Playwright;

using NUnit.Framework;


public class TestSetup
{
    [Test]
    public async Task Testtwo()
  {
    var settings = ConfigManager.Settings;

    var playwright = await Playwright.CreateAsync();

    var browser = await BrowserFactory.CreateBrowser(playwright, settings.Browser);

    var context = await browser.NewContextAsync();
    var page = await context.NewPageAsync();

    await page.GotoAsync(settings.BaseUrl);

   await page.PauseAsync();
}
    



} 
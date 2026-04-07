using Microsoft.Playwright;


public class Browsertest
{
   [Test]
    public  async Task BaseTes()
    {
        
     var playwright = await Playwright.CreateAsync();
     var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
    {
        Headless = false
    });;
     var context = await browser.NewContextAsync();
     var page = await context.NewPageAsync();

     await page.GotoAsync("https://www.youtube.com/");
     await page.PauseAsync();

    }


}
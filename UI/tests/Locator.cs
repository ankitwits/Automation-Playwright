using  Microsoft.Playwright;
using NUnit.Framework;

public  class  Locator
{
    [Test]
    public async Task SelectLocator()
    {

        var playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync( new BrowserTypeLaunchOptions { Headless=false});

        var context= await browser.NewContextAsync();
        var page = await context.NewPageAsync();

        await page.GotoAsync("https://books-pwakit.appspot.com/");
        //await page.PauseAsync();
        await page.Locator("book-app[apptitle='BOOKS'] #input").FillAsync("Example");
        await page.PauseAsync();







        




    }



}
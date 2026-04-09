using Microsoft.Playwright;
using NUnit.Framework;


public class ShadowDom
{
    [Test]
    public async Task TestShadow()
    {

        var playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });

        var context = await browser.NewContextAsync();

        var page = await context.NewPageAsync();
        await page.GotoAsync("https://books-pwakit.appspot.com/");
        //await page.PauseAsync();

        // find the text box in shadow dom and fill it
         await page.Locator("book-app[apptitle='BOOKS'] #input").FillAsync("Example");
         await page.PauseAsync();

        // get the text from the page and do assertion 

        // string text = await page.Locator("book-app[apptitle='BOOKS'] .books-desc").TextContentAsync();
       // await Assertions.Expect(page.Locator("book-app[apptitle='BOOKS'] .books-desc")).ToContainTextAsync("Search the world's most comprehensive index of full-text books.");

         //below codes are example for Xpath locator 

         await page.Locator("//input[@id='1' and @name='test']").FillAsync("name");

         






    }


}
using System.Security.Cryptography.X509Certificates;
using Microsoft.Playwright;
using NUnit.Framework;

public class HandleHiddenAutoSuggestions
{
    [Test]

    public async Task AutoSuggestion()
    {
        var playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{Headless=false});
        var contex = await browser.NewContextAsync();
        var page = await contex.NewPageAsync();

        await page.GotoAsync("https://legacy.reactjs.org/docs/optimizing-performance.html#profiling-components-with-the-devtools-profiler");
         await page.WaitForTimeoutAsync(5000);
        await page.Locator("//input[@id='algolia-doc-search']").FillAsync("dev tool");

        await page.WaitForTimeoutAsync(5000);

        await page.Locator("//div[@class='algolia-docsearch-suggestion--wrapper']//div[text()='Profiling Components with the ']").ClickAsync();
         
         await page.WaitForTimeoutAsync(3000);





        
        
        
    }
    






}
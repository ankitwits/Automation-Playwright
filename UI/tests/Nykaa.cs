using Microsoft.Playwright;
using NUnit.Framework;


public class Nykaa
{
    [Test]
    public async Task Hoverandnavigate()
    {


        var playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
        var contex = await browser.NewContextAsync();
        var page = await contex.NewPageAsync();

        await page.GotoAsync("https://www.nykaa.com/");
        await page.WaitForTimeoutAsync(1000);
        //await page.HoverAsync("//a[text()='Health & Wellness']");
        await page.Locator("//a[text()='Health & Wellness']").HoverAsync();
        await page.WaitForTimeoutAsync(1000);

        var newPageTask = contex.WaitForPageAsync();

        await page.ClickAsync("//a[contains(normalize-space(),'Fitness Equipments')]");

        var newPage = await newPageTask;
        //await newPage.WaitForLoadStateAsync(LoadState.NetworkIdle);

        Console.WriteLine("New Tab Title: " + await newPage.TitleAsync());

        // Wait for products to load
        await newPage.WaitForTimeoutAsync(3000);

        // Get all product names
        var productCount = await newPage.Locator("//div[@id='product-list-wrap']//div[contains(@class,'productWrapper')]").CountAsync();

        Console.WriteLine("------ Product List ------");

        for (int i = 0; i < productCount; i++)
        {
            Console.WriteLine($"{i + 1}. Product {i + 1}");
        }

        Console.WriteLine("Execution Completed.");
       // Console.ReadLine();
       await contex.CloseAsync();
       await browser.CloseAsync();


    }



}
using Microsoft.Playwright;
using NUnit.Framework;


public class ProductCount
{


   [Test]
    public async Task Count()
    {
        var playwright =  await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{ Headless= false});
        var context =  await browser.NewContextAsync();
        var page = await context.NewPageAsync();

        await page.GotoAsync("https://www.flipkart.com/clothing-and-accessories/bottomwear/cargo/men-cargo/pr?sid=clo%2Cvua%2Crqy%2Cnli&p%5B%5D=facets.brand%255B%255D%3DJexPuti&p%5B%5D=facets.discount_range_v1%255B%255D%3D60%2525%2Bor%2Bmore&ctx=eyJjYXJkQ29udGV4dCI6eyJhdHRyaWJ1dGVzIjp7InNvdXJjZUNvbnRlbnRUeXBlIjp7InNpbmdsZVZhbHVlQXR0cmlidXRlIjp7ImtleSI6InNvdXJjZUNvbnRlbnRUeXBlIiwiaW5mZXJlbmNlVHlwZSI6IlNDVCIsInZhbHVlIjoiQUQiLCJ2YWx1ZVR5cGUiOiJTSU5HTEVfVkFMVUVEIn19fX19&nnc=OBRL3IJTJA8T_AD");

        var prodcuct =  page.Locator("//div[@data-id]");
        await prodcuct.First.WaitForAsync();
        await page.WaitForTimeoutAsync(20000);

        int count = await prodcuct.CountAsync();

        Console.WriteLine(count);






    }
    




}

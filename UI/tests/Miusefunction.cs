using Microsoft.Playwright;
using NUnit.Framework;


public class MouseFunction
{

    [Test]
    public async Task DoubleClick()
    {

        var playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{Headless=false});
        var context = await browser.NewContextAsync();
        var page = await context.NewPageAsync();

        await page.GotoAsync("https://www.flipkart.com/new-elec-clp-march-at-store");

        await page.GetByText("Smart devices").ClickAsync(new() { Button = MouseButton.Right });

        await page.PauseAsync();     



    } 


    [Test]    

    public async Task Hover()
    {
        
        var playright =  await Playwright.CreateAsync();
        var browser = await playright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{Headless= false});
        var context = await browser.NewContextAsync();


        var page =  await context.NewPageAsync();
        await page.GotoAsync("https://www.flipkart.com/clothing-and-accessories/bottomwear/~cs-e0ydeyuk36/pr?sid=clo%2Cvua&offer=nb%3Amp%3A02c5885027&ctx=eyJjYXJkQ29udGV4dCI6eyJhdHRyaWJ1dGVzIjp7InRpdGxlIjp7Im11bHRpVmFsdWVkQXR0cmlidXRlIjp7ImtleSI6InRpdGxlIiwiaW5mZXJlbmNlVHlwZSI6IlRJVExFIiwidmFsdWVzIjpbIkplYW5zIl0sInZhbHVlVHlwZSI6Ik1VTFRJX1ZBTFVFRCJ9fX19fQ%3D%3D");
        await page.WaitForTimeoutAsync(2000);
        await page.Locator("//span[@class='OqYNhN' and text()='Men']").HoverAsync();
        await page.PauseAsync();  

    }



    [Test]

    public async Task Keyshortcut()
    {
        var playright =  await Playwright.CreateAsync();
        var browser = await playright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{Headless= false});
        var context = await browser.NewContextAsync();


        var page =  await context.NewPageAsync();
        await page.GotoAsync("https://www.flipkart.com/clothing-and-accessories/topwear/tshirt/men-tshirt/pr?sid=clo,ash,ank,edy&otracker=categorytree&otracker=nmenu_sub_Men_0_T-Shirts");
        await page.WaitForTimeoutAsync(2000);
        await page.Locator("//div[@class='DjsUBA']//input [@title='Search for products, brands and more']").FillAsync("men Jeans");
        await page.WaitForTimeoutAsync(2000);
        await page.Keyboard.PressAsync("Enter");
        await page.WaitForTimeoutAsync(5000);

        //await page.GetByText("Submit").PressAsync("Enter");

    }
    
    [Test]
    public async Task Check_checkbox()
    {
        var playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{ Headless=false});
        var contex  = await browser.NewContextAsync();
        var page = await contex.NewPageAsync();
        await page.GotoAsync("https://in.bookmyshow.com/movies/bengaluru/dhurandhar-the-revenge/buytickets/ET00478890/20260413");
        await page.WaitForTimeoutAsync(2000);
        await page.Locator("//div[@class='sc-1sufx7s-2 kDmgZX']//div[text()='Special Formats']").ClickAsync();
        await page.WaitForTimeoutAsync(5000);
        //await page.GetByLabel("4K").SetCheckedAsync(true);
        await page.GetByText("4K", new() { Exact = true }).ClickAsync();
        await page.WaitForTimeoutAsync(5000);



        
        



    }



}
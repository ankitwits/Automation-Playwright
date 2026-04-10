<<<<<<< HEAD
using  Microsoft.Playwright;
using NUnit.Framework;
=======
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;


>>>>>>> basic-feature

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
<<<<<<< HEAD
        await page.Locator("book-app[apptitle='BOOKS'] #input").FillAsync("Example");
        await page.PauseAsync();







        
=======

        // find the text box in shadow dom and fill it
        await page.Locator("book-app[apptitle='BOOKS'] #input").FillAsync("Example");
        await page.PauseAsync();

        // get the text from the page and do assertion 

       // string text = await page.Locator("book-app[apptitle='BOOKS'] .books-desc").TextContentAsync();
       
 
>>>>>>> basic-feature




    }



}
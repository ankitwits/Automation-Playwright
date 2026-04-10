using System.Net;
using System.Reflection.Metadata;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.Playwright;

using NUnit.Framework;


public class MovingScrollbar
{
<<<<<<< HEAD
    
  [Test]
  public async Task Scroll()

    {
     var playwright = await Playwright.CreateAsync();
     var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
    {
        Headless = false
    });
     var context = await browser.NewContextAsync();
     var page = await context.NewPageAsync();

     await page.GotoAsync("https://www.youtube.com/watch?v=VULTd5_SZ5Q");
     await page.PauseAsync();
     // this 
     //EvaluateAsync method used for scroll
     /*await page.EvaluateAsync("window.scrollTo(0, 300)");
     await page.PauseAsync();*/
     //
     await page.Locator("").ScrollIntoViewIfNeededAsync();
     await page.GetByText("Sort by").ClickAsync();




    }
   
=======

  [Test]
  public async Task Scroll()

  {
    var playwright = await Playwright.CreateAsync();
    var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
    {
      Headless = false
    }); var context = await browser.NewContextAsync();
    var page = await context.NewPageAsync();

    await page.GotoAsync("https://www.youtube.com/watch?v=VULTd5_SZ5Q");
    await page.PauseAsync();
    // this 
    //EvaluateAsync method used for scroll
    /*await page.EvaluateAsync("window.scrollTo(0, 300)");
    await page.PauseAsync();*/
    //
    await page.Locator("").ScrollIntoViewIfNeededAsync();
    await page.GetByText("Sort by").ClickAsync();


  }
>>>>>>> basic-feature


}

public class async
{
}
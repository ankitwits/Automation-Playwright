using Microsoft.Playwright;
using NUnit.Framework;
namespace UI.Core;

public class BaseClass
{
   protected IBrowser browser;
   protected IPlaywright playwright;
    protected IBrowserContext context;
   protected IPage page;

    [SetUp]
    public  async Task SetUp()
    {
        playwright = await Playwright.CreateAsync();

        browser = await BrowserFactory.CreateBrowser(playwright,"chromium");

        context =  await browser.NewContextAsync();

        page = await context.NewPageAsync();      



    }






}

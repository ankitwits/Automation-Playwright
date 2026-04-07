using System.Collections;
using Microsoft.Playwright;
using NUnit.Framework;

public class TestProgram
{

    [Test]
    public void TestRun()
    {
        var driverManager = DriverFactory.GetDriver("chrome");
        Console.WriteLine(driverManager);
        // IBrowser driver = (IBrowser)driverManager.GetDriver();
    }

    [Test]

    public void reversestring()
    {
        string str = "jaihind";

        Stack<char> stk = new Stack<char>();

        foreach (var item in str)
        {
            stk.Push(item);
            Console.WriteLine(item);
            
        }
        string result="";
        while(stk.Count>0)
        {
            
            result+=stk.Pop();
            Console.WriteLine(result);
        }



    }


    [Test]
    
    public async Task Testone()
  {
    var settings = ConfigManager.Settings;

    var playwright = await Playwright.CreateAsync();

    var browser = await BrowserFactory.CreateBrowser(playwright, settings.Browser);

    var context = await browser.NewContextAsync();
    var page = await context.NewPageAsync();

    await page.GotoAsync(settings.BaseUrl);

   await page.PauseAsync();
}
}
using System.Runtime.CompilerServices;
using  Microsoft.Playwright;
using NUnit.Framework;
namespace UI.Core;


public class HandleNewPage : BaseClassTest
{
    [Test]
    public async Task Handlenew()
    {
        await page.GotoAsync("https://www.airtel.in/");
        await page.Locator("//label[text()='Account']").HoverAsync();
        await page.WaitForTimeoutAsync(2000);
       
       // var newpage = await context.NewPageAsync();
    //    var newpage = await page.RunAndWaitForPopupAsync(async() =>
    //     {
            await page.Locator("//label[text()='Login']").ClickAsync();
            

        // });
        // await page.WaitForTimeoutAsync(20000);
        // await newpage.Locator("//input[@placeholder='Enter your mobile number']").FillAsync("9037366366");
        //   await page.WaitForTimeoutAsync(20000);
        

        //  await newpage.WaitForLoadStateAsync();

        await page.Locator("//input[@placeholder='Enter your mobile number']").FillAsync("9038387465");
          await page.WaitForTimeoutAsync(20000);






        



    }   






}

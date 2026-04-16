using Microsoft;
using Microsoft.Playwright;
using NUnit.Framework;
using UI.Core;

namespace UI.tests;


public class DynamicDropDown: BaseClassTest
{
    [Test]
    public async Task Selectitem()
    {

        await page.GotoAsync("https://www.yatra.com/");
         await page.WaitForTimeoutAsync(1000);

        await page.Locator("//span[contains(@class,'style_cross')]//img[@alt='cross']").First.ClickAsync();
        await page.WaitForTimeoutAsync(1000);
        // var newpage = await page.RunAndWaitForPopupAsync(async() =>
        // {
        //    // await page.Locator("//span[@class='style_cross__q1ZoV']").ClickAsync();
        //    await page.GotoAsync("https://www.yatra.com/");
            

        //  });


        //await page.Locator("//Span[@class='style_cross__q1ZoV']//img[@src='/react-home/_next/static/media/close.e57bf4bf.svg']").ClearAsync();

        

        await page.Locator("//label[contains(text(),'Departure From')]/following::input[1]").PressSequentiallyAsync("Ban", new(){Delay=200});
        await page.Locator("/div[@class='MuiBox-root css-134xwrj']/Ul").GetByRole(AriaRole.Listitem).Filter(new()
         { HasTextString = "Bangalore" }).ClickAsync();
         await page.WaitForTimeoutAsync(2000);

        ////div[@class='MuiBox-root css-134xwrj']/Ul




        



    }


}
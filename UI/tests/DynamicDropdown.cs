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
        var popup =  page.Locator("//span[contains(@class,'style_cross')]//img[@alt='cross']").First;

        if (await popup.IsVisibleAsync())
        {
            await popup.ClickAsync();
            

        }

        await page.WaitForTimeoutAsync(5000); 
        
       //// await page.Locator("//Span[@class='style_cross__q1ZoV']//img[@src='/react-home/_next/static/media/close.e57bf4bf.svg']").ClearAsync();

       // await page.PauseAsync();
       await page.Locator("//*[contains(text(),'Departure From')]/following::div[@role='Combobox']").First.ClickAsync();
        await page.WaitForTimeoutAsync(5000);
        await page.Locator("//div[@class='MuiBox-root css-8hsq1d']").ClickAsync();
        await page.Locator("//input[@id='input-with-icon-adornment']").ClickAsync();
        // PressSequentiallyAsync("Ban", new(){Delay=200});
        await page.Locator("/div[@class='MuiBox-root css-134xwrj']/Ul").GetByRole(AriaRole.Listitem).Filter(new()
          { HasTextString = "Bangalore" }).ClickAsync();
          await page.WaitForTimeoutAsync(2000);

        ////div[@class='MuiBox-root css-134xwrj']/Ul




        



    }


}
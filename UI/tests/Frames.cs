using Microsoft.Playwright;
using NUnit.Framework;
using UI.Core;

namespace UI.tests;

public class Frames :BaseClassTest 
{
    [Test]
    public async Task HandleFrame()
    {
        await page.GotoAsync("https://practice.expandtesting.com/iframe?utm_source=chatgpt.com");

         await page.FrameLocator("//iframe[@id='iframe-youtube']").GetByLabel("Watch on YouTube").ClickAsync();
         await page.WaitForTimeoutAsync(5000);
       // await page.FrameLocator("//iframe[@name='google_ads_iframe_/23037861279/ETIMES_WEB/ETIMES_WEB_ENTERTAINMENT/ETIMES_WEB_ENTERTAINMENT_AS/ETIMES_WEB_ENTERTAINMENT_AS_ATF_P1_1']").getby
    }
}
using Microsoft.Playwright;
using NUnit.Framework;
using UI.Core;


public class ShadowDom :BaseClassTest
{
    [Test]
    public async Task TestShadow()
    {

      
        await page.GotoAsync("https://books-pwakit.appspot.com/");
        //await page.PauseAsync();

        // find the text box in shadow dom and fill it
         await page.Locator("book-app[apptitle='BOOKS'] #input").FillAsync("Example");
         //await page.WaitForTimeoutAsync(2000);

        // get the text from the page and do assertion 

        // string text = await page.Locator("book-app[apptitle='BOOKS'] .books-desc").TextContentAsync();
       // await Assertions.Expect(page.Locator("book-app[apptitle='BOOKS'] .books-desc")).ToContainTextAsync("Search the world's most comprehensive index of full-text books.");

         //below codes are example for Xpath locator 

         //await page.Locator("//input[@id='1' and @name='test']").FillAsync("name");
         await page.WaitForTimeoutAsync(2000);



    }


}
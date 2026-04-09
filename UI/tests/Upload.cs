using Microsoft.Playwright;
using NUnit.Framework;


public class Upload
{
    [Test]
    public async Task Fileupload()
    {

        var playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });

        var context = await browser.NewContextAsync();

        var page = await context.NewPageAsync();
        await page.GotoAsync("https://commitquality.com/practice-file-upload");
        // await page.GetByLabel("Choose a file").SetInputFilesAsync("C:/Users/ankit/Downloads/Resume.dock");

        // code for an option to chose file using event listner

        var fileChooser = await page.RunAndWaitForFileChooserAsync(async () =>
        {
             await page.ClickAsync("input[type='file']");
        });

        await fileChooser.SetFilesAsync("C:/Users/ankit/Downloads/Resume.doc");


















    }


}
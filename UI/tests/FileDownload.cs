using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;



public  class  FileDownload
{
    [Test]
    public async Task Download()
    {

        var playwright = await Playwright.CreateAsync();
        var browser = await playwright.Chromium.LaunchAsync( new BrowserTypeLaunchOptions { Headless=false});

        var context= await browser.NewContextAsync();
        var page = await context.NewPageAsync();

        await page.GotoAsync("https://commitquality.com/practice-file-download");
        //await page.PauseAsync();
           var download = await page.RunAndWaitForDownloadAsync(async () =>{
             await page.GetByRole(AriaRole.Button, new() { Name = "Download File" }).ClickAsync();;
             });// Save file
            await download.SaveAsAsync("C:\\Users\\Ankit\\Downloads\\"+ "sample.pdf");
            await page.PauseAsync();



       
 




    }



}
using Microsoft.Playwright;
using NUnit.Framework;
using UI.core;



public class Useconfig 
{

    [Test]
    public async Task Geturl()
    {

        var playwright = await  Playwright.CreateAsync();

        var browser =  await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{Headless=false});

        var contetext =  await browser.NewContextAsync();

        var page = await contetext.NewPageAsync();

        await page.GotoAsync(ConfigManager.Settings.BaseUrl);

        await page.PauseAsync();

        


    }




}
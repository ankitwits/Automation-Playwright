using Microsoft.Playwright;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using NUnit.Framework;

namespace API;

public class APIBasic
{
    public async Task Get()
    {
        var playwright = await Playwright.CreateAsync();
        var apicontext = await playwright.APIRequest.NewContextAsync(new APIRequestNewContextOptions()
        {
            BaseURL = "",
            IgnoreHTTPSErrors= true

        });

        var response = await apicontext.GetAsync("");

        var responsedata =  await  response.JsonAsync();


    }


    public async Task Post()
    {
        var playwright=  await Playwright.CreateAsync();
        var apicontext = await playwright.APIRequest.NewContextAsync(new APIRequestNewContextOptions()
        {
            BaseURL="",
            IgnoreHTTPSErrors= true
        });


        var response1 =  await apicontext.PostAsync("url", new APIRequestContextOptions(){

            DataObject = new
            {
                username="",
                pasword =""

            }
            

        });

        var jsonString = await response1.JsonAsync();


    }




}
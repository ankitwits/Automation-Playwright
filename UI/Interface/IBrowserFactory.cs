using Microsoft.Playwright;


public interface IBrowserFactory
{
    Task<IBrowser> LaunchBrowserAsync(IPlaywright playwright);
   
}
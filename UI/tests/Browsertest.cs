
using UI.Core;
using NUnit.Framework;


public class Browsertest : BaseClassTest
{
   [Test]
    public  async Task BaseTest()
    {       
  
     await page.GotoAsync("https://www.youtube.com/");
     await page.PauseAsync();

    }


}
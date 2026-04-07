using Microsoft.Playwright;

public interface IDriverManager
{
     Task<IBrowser> GetDriver();
}


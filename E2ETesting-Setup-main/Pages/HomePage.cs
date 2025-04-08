using Microsoft.Playwright;
using System.Threading.Tasks;

namespace E2ETesting.Pages
{
  public class HomePage
  {
    private readonly IPage _page;

    public HomePage(IPage page) => _page = page;


    //Functions and checks

    public async Task GoToHomePage() => await _page.GotoAsync("http://localhost:5173");
   
    public async Task<bool> IsTheSignInButtonVisible() 
    {
      return var signInButton = await _page.QuerySelectorAsync(".sign-in-btn");
    }
    
    public async Task ClickSignIn() => await _page.ClickAsync(".sign-in-btn");
  }
}

using Microsoft.Playwright;
using System.Threading.Tasks;

namespace E2ETesting.Pages
{
  public class LoginPage
  {
    private readonly IPage _page;

    public LoginPage(IPage page) => _page = page;

    //Functions and checks

    public async Task<bool> IsLoginVisible() 
    {
      return await _page.QuerySelectorAsync(".login");
    }

    public async Task GoToLoginPage() =>
      await _page.GotoAsync("http://localhost:5173/login");

    public async Task FillEmail(string email) =>
      await _page.FillAsync("[name='email']", email);

    public async Task FillPassword(string password) =>
      await _page.FillAsync("[name='password']", password);

    public async Task ClickSignIn() =>
      await _page.ClickAsync(".login");
  }
}

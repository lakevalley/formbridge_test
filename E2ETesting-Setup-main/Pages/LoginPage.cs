using Microsoft.Playwright;
using System.Threading.Tasks;

namespace E2ETesting.Pages
{
  public class LoginPage
  {
    private readonly IPage _page;

    public LoginPage(IPage page) => _page = page;

    //Functions and checks

    public async Task<bool> IsLoginVisible() => await _page.WaitForSelectorAsync(".login") != null;

    public async Task GoToLoginPage() =>
      await _page.GotoAsync("http://localhost:5120/login");

    public async Task FillInSupportCredentials()
    {
      await _page.FillAsync("[name='email']", "support1");
      await _page.FillAsync("[name='password']", "a");
    }
    public async Task FillInAdminCredentials()
    {
      await _page.FillAsync("[name='email']", "admin1");
      await _page.FillAsync("[name='password']", "a");
    }
    

    public async Task FillPassword(string password) =>
      await _page.FillAsync("[name='password']", password);

    public async Task ClickSignIn() =>
      await _page.ClickAsync(".login");
  }
}

using Microsoft.Playwright;
using System.Threading.Tasks;

namespace E2ETesting.Pages
{
  public class AdminDashboard
  {
    private readonly IPage _page;

    public AdminDashboard(IPage page) => _page = page;
    
    public async Task<bool> IsAdminDashboardVisible() =>
      await _page.QuerySelectorAsync(":has-text('Admin Dashboard')") != null;

    public async Task ClickLogout()
    {
      var logoutButton = await _page.QuerySelectorAsync("#logout");
      logoutButton.ClickAsync();
    }

    public async Task ClickAddUserButton()
    {
      //var addUserButton = await _page.QuerySelectorAsync(":has-text('Add User')");
      var addUserButton = await _page.QuerySelectorAsync("#add-user");

      if (addUserButton is not null)
      {
        await addUserButton.ClickAsync();
      }
      else
      {
        Console.WriteLine("❌ 'Add User' button not found.");
      }
    }
    
    public async Task FillOutUserFields()
    {
      await _page.FillAsync("[placeholder='First name']", "Test");
      await _page.FillAsync("[placeholder='Last name']", "Testsson");
      await _page.FillAsync("[placeholder='Email']", "test@testsson.com");
    }

    public async Task SaveUser()
    {
      var addUserButton = await _page.QuerySelectorAsync(".add-user-btn");
      await addUserButton.ClickAsync();
    }

    public async Task SearchForNewUser()
    {
      await _page.QuerySelectorAsync(":has-text('test@testsson.com')");
      await _page.PauseAsync();
    }
  }
}
using Microsoft.Playwright;
using System.Threading.Tasks;

namespace E2ETesting.Pages
{
  public class AdminDashboard
  {
    private readonly IPage _page;

    public AdminDashboard(IPage page) => _page = page;

    //Functions and checks

    public async Task<bool> IsAdminDashboardVisible() =>
      await _page.QuerySelectorAsync(":has-text('Admin Dashboard')") != null;

    public async Task ClickLogout()
    {
      var logoutButton = await _page.QuerySelectorAsync("#logout");
      logoutButton.ClickAsync();
    }
  }
}
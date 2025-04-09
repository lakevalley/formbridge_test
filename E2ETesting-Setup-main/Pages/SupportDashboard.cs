using Microsoft.Playwright;
using System.Threading.Tasks;

namespace E2ETesting.Pages
{
  public class SupportDashboard
  {
    private readonly IPage _page;

    public SupportDashboard(IPage page) => _page = page;
    
    public async Task<bool> IsSupportDashboardVisible() =>
      await _page.QuerySelectorAsync(":has-text('Support Dashboard')") != null;

    public async Task ClickLogout()
    {
      var logoutButton = await _page.QuerySelectorAsync("#logout");
      logoutButton.ClickAsync();
    }
  }
}
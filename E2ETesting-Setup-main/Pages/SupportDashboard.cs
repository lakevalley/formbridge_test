using Microsoft.Playwright;
using System.Threading.Tasks;

namespace E2ETesting.Pages
{
  public class SupportDashboard
  {
    private readonly IPage _page;

    public SupportDashboard(IPage page) => _page = page;

    //Functions and checks

    public async Task<bool> IsSupportDashboardVisible() =>
      await _page.QuerySelectorAsync(":has-text('Support Dashboard')") != null;
  }
}
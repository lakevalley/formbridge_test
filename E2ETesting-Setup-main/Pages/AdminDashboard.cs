using Microsoft.Playwright;
using System.Threading.Tasks;

namespace E2ETesting.Pages
{
  public class AdminDashboard
  {
    private readonly IPage _page;

    public AdminDashboard(IPage page) => _page = page;
    
    public async Task<bool> IsAdminDashboardVisible() =>
      await _page.WaitForSelectorAsync(":has-text('Admin Dashboard')") != null;

    public async Task ClickLogout()
    {
      var logoutButton = await _page.QuerySelectorAsync("#logout");
      logoutButton.ClickAsync();
    }

    public async Task ClickAddUserButton()
    {
      var addUserButton = await _page.QuerySelectorAsync("#add-user");
      await addUserButton.ClickAsync();
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
      var element = await _page.WaitForSelectorAsync(":has-text('test@testsson.com')");
      Assert.True(element is not null, "No element found");
    }

    public async Task ClickTheAiChatBotButton()
    {
      var aiChatBotButton = await _page.QuerySelectorAsync("#edit-ai");
      await aiChatBotButton.ClickAsync();
    }

    public async Task GiveAiNewPersonality()
    {
      await _page.FillAsync("#message", "Test Personality");
    }

    public async Task ClickOnTheAiSubmitButton()
    {
      var aiSubmitButton = await _page.QuerySelectorAsync("[value='Submit']");
      await aiSubmitButton.ClickAsync();
    }

    public async Task IsSettingUpdated()
    {
      var element = await _page.QuerySelectorAsync(":has-text('Test Personality')");
      Assert.True(element is not null, "'Test Personality' is not null");
    }
  }
}
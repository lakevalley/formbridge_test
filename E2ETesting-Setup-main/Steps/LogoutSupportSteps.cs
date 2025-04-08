using E2ETesting.Pages;
using Microsoft.Playwright;
using TechTalk.SpecFlow;
using Xunit;
using System.Threading.Tasks;

namespace E2ETesting.Steps
{
  [Binding]
  public class LogoutSupportSteps
  {
    //Instancing pages needed:
    private readonly LoginPage _loginPage;
    private readonly SupportDashboard _supportDashboard;

    public LogoutSupportSteps(ScenarioContext scenarioContext)
    {
      // Retrieve page instance from ScenarioContext
      var page = scenarioContext["Page"] as IPage;
      _loginPage = new LoginPage(page);
      _supportDashboard = new SupportDashboard(page);
    }
    
    [Given(@"I am on the Support dashboard page")]
    public async Task GivenIAmOnTheSupportDashboardPage()
    {
      await _loginPage.GoToLoginPage();
      await _loginPage.FillInSupportCredentials();
      await _loginPage.ClickSignIn();
      Assert.True(await _supportDashboard.IsSupportDashboardVisible());
    }
    
    [When(@"I click the logout button")]
    public async Task WhenIClickTheLogoutButton()
    {
      await _supportDashboard.ClickLogout();
    }
    
    [Then(@"I am redirected to the login page")]
    public async Task ThenIAmRedirectedToTheLoginPage()
    {
      
      Assert.True(await _loginPage.IsLoginVisible());
    }
    
  }
}
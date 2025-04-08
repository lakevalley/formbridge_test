using E2ETesting.Pages;
using Microsoft.Playwright;
using TechTalk.SpecFlow;
using Xunit;
using System.Threading.Tasks;

namespace E2ETesting.Steps
{
  [Binding]
  public class LoginAsAdminSteps
  {
    //Instancing pages needed:
    private readonly LoginPage _loginPage;
    private readonly AdminDashboard _adminDashboard;

    public LoginAsAdminSteps(ScenarioContext scenarioContext)
    {
      // Retrieve page instance from ScenarioContext
      var page = scenarioContext["Page"] as IPage;
      _loginPage = new LoginPage(page);
      _adminDashboard = new AdminDashboard(page);
    }
    
    [Given(@"I am on the page for Login")]
    public async Task GivenIAmOnThePageForLogin()
    {
      await _loginPage.GoToLoginPage();
    }

    [Given(@"I have entered my admin credentials")]
    public async Task GivenIHaveEnteredMyAdminCredentials()
    {
      await _loginPage.FillInAdminCredentials();
    }

    [When(@"I click on the login button")]
    public async Task WhenIClickOnTheLoginButton()
    {
      await _loginPage.ClickSignIn();
    }

    [Then(@"I am redirected to the admin dashboard")]
    public async Task ThenIAmRedirectedToTheAdminDashboard()
    {
      Assert.True(await _adminDashboard.IsAdminDashboardVisible());
    }
  }
}
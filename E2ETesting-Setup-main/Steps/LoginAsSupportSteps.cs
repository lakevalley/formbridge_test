using E2ETesting.Pages;
using Microsoft.Playwright;
using TechTalk.SpecFlow;
using Xunit;
using System.Threading.Tasks;

namespace E2ETesting.Steps
{
  [Binding]
  public class LoginAsSupportSteps
  {
    //Instancing pages needed:
    private readonly LoginPage _loginPage;
    private readonly SupportDashboard _supportDashboard;

    public LoginAsSupportSteps(ScenarioContext scenarioContext)
    {
      // Retrieve page instance from ScenarioContext
      var page = scenarioContext["Page"] as IPage;
      _loginPage = new LoginPage(page);
      _supportDashboard = new SupportDashboard(page);
    }

    [Given(@"I am on the Login page")]
    public async Task GivenIAmOnTheLoginPage()
    {
      await _loginPage.GoToLoginPage();
    }

    [Given(@"I have entered my credentials")]
    public async Task IHaveEnteredMyCredentials()
    {
      await _loginPage.FillInSupportCredentials();
    }

    [When(@"I click the login button")]
    public async Task IClickTheLoginButton()
    {
      await _loginPage.ClickSignIn();
    }

    [Then(@"I am redirected to the support dashboard")]
    public async Task IAmRedirectedToTheSupportDashboard()
    {
      Assert.True(await _supportDashboard.IsSupportDashboardVisible());
    }
  }
}
    
    
    
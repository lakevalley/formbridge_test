using E2ETesting.Pages;
using Microsoft.Playwright;
using TechTalk.SpecFlow;
using Xunit;
using System.Threading.Tasks;

namespace E2ETesting.Steps
{
  [Binding]
  public class NavigateLoginSteps
  {
    //Instancing pages needed:
    private readonly HomePage _homePage;
    private readonly LoginPage _loginPage;

    public NavigateLoginSteps(ScenarioContext scenarioContext)
    {
      // Retrieve page instance from ScenarioContext
      var page = scenarioContext["Page"] as IPage;
      _homePage = new HomePage(page);
      _loginPage = new LoginPage(page);
    }


    //Ghirkin logic from instanced pages:
    [Given(@"I am on the FormBridge homepage")]
    public async Task GivenIAmOnTheFormBridgeHomepage()
    {
      await _homePage.GoToHomePage();
    }

    [Given(@"I see the Sign in-button")]
    public async Task GivenISeeTheSignInButton() 
    {
      Assert.True(await _homePage.IsTheSignInButtonVisible());
    }

    [When(@"I click on Sign in")]
    public async Task WhenIClickOnTheSignInButton()
    {
      await _homePage.ClickSignIn();
    }

    [Then(@"I am redirected to a Login-page")]
    public async Task ThenIAmRedirectedToLogin()
    {
      Assert.True(await _loginPage.IsLoginVisible());
    }
  }
}

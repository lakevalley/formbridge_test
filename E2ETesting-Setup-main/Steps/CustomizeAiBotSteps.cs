using E2ETesting.Pages;
using Microsoft.Playwright;
using TechTalk.SpecFlow;
using Xunit;
using System.Threading.Tasks;

namespace E2ETesting.Steps
{
  [Binding]
  public class CustomizeAiBotSteps
  {
    private readonly LoginPage _loginPage;
    private readonly AdminDashboard _adminDashboard;

    public CustomizeAiBotSteps(ScenarioContext scenarioContext)
    {
      var page = scenarioContext["Page"] as IPage;
      _loginPage = new LoginPage(page);
      _adminDashboard = new AdminDashboard(page);
    }
    
    [Given(@"I am on the dashboard for Admins")]
    public async Task GivenIAmOnTheDashboardForAdmins()
    {
      await _loginPage.GoToLoginPage();
      await _loginPage.FillInAdminCredentials();
      await _loginPage.ClickSignIn();
      Assert.True(await _adminDashboard.IsAdminDashboardVisible());
    }
    
    [When(@"I click on the AI ChatBot button")]
    public async Task WhenIClickOnTheAIChatBotButton()
    {
      await _adminDashboard.ClickTheAiChatBotButton();
    }
    
    [When(@"I give the AI a new personality")]
    public async Task WhenIGiveTheAIANewPersonality()
    {
      await _adminDashboard.GiveAiNewPersonality();
    }
    
    [When(@"I click on the AI Submit button")]
    public async Task WhenIClickOnTheAiSubmitButton()
    {
      await _adminDashboard.ClickOnTheAiSubmitButton();
    }
    
    [Then(@"the Current setting is updated")]
    public async Task ThenTheCurrentSettingIsUpdated()
    {
      await _adminDashboard.IsSettingUpdated();
    }
  }
}
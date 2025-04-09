using E2ETesting.Pages;
using Microsoft.Playwright;
using TechTalk.SpecFlow;
using Xunit;
using System.Threading.Tasks;

namespace E2ETesting.Steps
{
  [Binding]
  public class AddUserSteps
  {
    //Instancing pages needed:
    private readonly LoginPage _loginPage;
    private readonly AdminDashboard _adminDashboard;

    public AddUserSteps(ScenarioContext scenarioContext)
    {
      // Retrieve page instance from ScenarioContext
      var page = scenarioContext["Page"] as IPage;
      _loginPage = new LoginPage(page);
      _adminDashboard = new AdminDashboard(page);
    }
    
    [Given(@"I am on the Admin dashboard")]
    public async Task GivenIAmOnTheAdminDashboard()
    {
      await _loginPage.GoToLoginPage();
      await _loginPage.FillInAdminCredentials();
      await _loginPage.ClickSignIn();
      Assert.True(await _adminDashboard.IsAdminDashboardVisible());
    }
    
    [When(@"I click on the Add User button")]
    public async Task WhenIClickOnTheAddUserButton()
    {
      await _adminDashboard.ClickAddUserButton();
    }
    
    [When(@"I fill out the user fields")]
    public async Task WhenIFillOutTheUserFields()
    {
      await _adminDashboard.FillOutUserFields();
    }
    
    [When(@"I click the Add User button")]
    public async Task WhenIClickTheAddUserButton()
    {
      await _adminDashboard.SaveUser();
    }
    
    [Then(@"the new user is saved")]
    public async Task ThenTheNewUserIsSaved()
    {
      await _adminDashboard.SearchForNewUser();
    }
  }
}
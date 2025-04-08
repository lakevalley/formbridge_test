using E2ETesting.Pages;
using Microsoft.Playwright;
using TechTalk.SpecFlow;
using Xunit;
using System.Threading.Tasks;

namespace E2ETesting.Steps
{
  [Binding]
  public class PostTicketSteps
  {
    //Instancing pages needed:
    private readonly FormPage _formPage;
    private readonly HomePage _homePage;


    public PostTicketSteps(ScenarioContext scenarioContext)
    {
      // Retrieve page instance from ScenarioContext
      var page = scenarioContext["Page"] as IPage;
      _formPage = new FormPage(page);
      _homePage = new HomePage(page);
    }
    
    [Given(@"I am on the Inet Form page")]
    public async Task GivenIAmOnTheInetFormPage()
    {
      await _formPage.GoToInetFormPage();
    }
    
    [Given(@"I fill out the form")]
    public async Task WhenIFillOutTheForm()
    {
      await _formPage.FillOutTheForm();
    }
    
    [When(@"I click the Submit button")]
    public async Task AndIClickTheSubmitButton()
    {
      await _formPage.ClickSubmitButton();
    }
    
    [Then(@"I am redirected to the HomePage")]
    public async Task ThenIAmRedirectedToTheHomePage()
    {
      await _homePage.IsTheSignInButtonVisible();
    }
    
  }
}
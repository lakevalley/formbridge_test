using Microsoft.Playwright;
using TechTalk.SpecFlow;

namespace E2ETesting.Hooks
{
  [Binding]
  public class PlaywrightHooks
  {
    private readonly ScenarioContext _scenarioContext;
    private IPlaywright _playwright;
    private IBrowser _browser;
    private IBrowserContext _context;
    private IPage _page;

    public PlaywrightHooks(ScenarioContext scenarioContext)
    {
      _scenarioContext = scenarioContext;
    }

    [BeforeScenario]
    public async Task Setup()
    {
      _playwright = await Playwright.CreateAsync();
      _browser = await _playwright.Chromium.LaunchAsync(new() { Headless = true, SlowMo = 800 });
      _context = await _browser.NewContextAsync();
      _page = await _context.NewPageAsync();

      _scenarioContext["Page"] = _page; //Store page-instance
    }

    [AfterScenario]
    public async Task Teardown()
    {
      await _browser.CloseAsync();
      _playwright.Dispose();
    }
  }
}

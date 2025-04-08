using Microsoft.Playwright;
using System.Threading.Tasks;
using Xunit;

namespace E2ETesting.Pages
{
  public class FormPage
  {
    private readonly IPage _page;
    public FormPage(IPage page) => _page = page;

    public async Task GoToInetFormPage() => await _page.GotoAsync("http://localhost:5173/form/1");

    public async Task FillOutTheForm()
    {
      await _page.FillAsync("[id='firstname']", "Test");
      await _page.FillAsync("[id='lastname']", "Testsson");
      await _page.FillAsync("[id='email']", "test@test.com");
      await _page.FillAsync("[id='message']", "TESTING");
    }

    public async Task ClickSubmitButton()
    {
      await _page.ClickAsync("[type='submit']");
    }
  }
}
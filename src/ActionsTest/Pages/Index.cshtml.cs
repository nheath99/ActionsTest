using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ActionsTest.Pages
{
	public class IndexModel : PageModel
	{
		public IActionResult OnGet()
		{
			return Page();
		}
	}
}

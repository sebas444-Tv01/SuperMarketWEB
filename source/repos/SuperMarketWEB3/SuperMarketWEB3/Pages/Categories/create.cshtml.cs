using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperMarketWEB3.Data;
using SuperMarketWEB3.Models;

namespace SuperMarketWEB3.Pages.Categories
{
    public class createModel : PageModel
    {
		private readonly SupermarketContext _context;

		public createModel(SupermarketContext context)
		{
			_context = context;
		}
		public IActionResult OnGet()
		{
			return Page();
		}

		[BindProperty]
		public Category Category { get; set; } = default!;

		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid || _context.Categories == null || Category == null)
			{
				var errors = ModelState.Values.SelectMany(m => m.Errors);
				foreach (var error in errors)
				{
					Console.WriteLine(error.ErrorMessage);
				}
				return Page();
			}

			_context.Categories.Add(Category);
			await _context.SaveChangesAsync();

			return RedirectToPage("./Index");
		}
        
        }
    }


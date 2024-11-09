using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SuperMarketWEB3.Data;
using SuperMarketWEB3.Models;

namespace SuperMarketWEB3.Pages.Categories
{
    public class IndexModel : PageModel
    {
		private readonly SupermarketContext _context;

		public IndexModel(SupermarketContext context)
		{
			_context = context;
		}

		public IList<Category> Categories { get; set; } = default!;

		public async Task OnGetAsync()
		{
			if (_context.Categories != null)
			{
				Categories = await _context.Categories.ToListAsync();
			}
		}
        

        }
    }


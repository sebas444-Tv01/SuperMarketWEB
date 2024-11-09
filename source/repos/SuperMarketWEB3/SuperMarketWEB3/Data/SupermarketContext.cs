using Microsoft.EntityFrameworkCore;
using SuperMarketWEB3.Models;

namespace SuperMarketWEB3.Data
{
	public class SupermarketContext:DbContext
	{
		public DbSet<Product> Product { get; set; }
		public DbSet<Category> Categories { get; set; }
		public SupermarketContext(DbContextOptions options) : base(options)
		{

		}
	}
}

using Microsoft.EntityFrameworkCore;

namespace ArtAnisaDiellzaTest.Data
{
	public class AppDbContext : DbContext
	{

		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{


		}

	}
}

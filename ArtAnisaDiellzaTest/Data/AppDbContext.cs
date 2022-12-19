using ArtAnisaDiellzaTest.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtAnisaDiellzaTest.Data
{
	public class AppDbContext : DbContext
	{


		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

		{


		}


		public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
    }
}

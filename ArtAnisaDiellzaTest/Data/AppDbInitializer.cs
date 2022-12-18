using ArtAnisaDiellzaTest.Models;
namespace ArtAnisaDiellzaTest.Data.Enum

{
	public class AppDbInitializer
	{

		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{

				var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

				context.Database.EnsureCreated();

				//Filmat

				if (!context.Movies.Any())
				{

					context.Movies.AddRange(new List<Movie>()
					{
						new Movie()
						{
							Name = "The Dictator",
							Description = " MovieDesc1",
							ImageURL = "https://play.google.com/store/movies/details/The_Dictator?id=fng0XmcoEHA",
							Duration = 1,
							ReleaseDate = DateTime.Now,
							MovieCategory = Controllers.MovieCategory.Comedy


						},
						new Movie()
						{
							Name = "Scooby-Doo",
							Description = " MovieDesc2",
							ImageURL = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.facebook.com%2Fscoobydoo%2F&psig=AOvVaw019dEfRTdvKDPnhs2qhRBn&ust=1671389645884000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCLCIkOSpgfwCFQAAAAAdAAAAABADA",
							Duration = 2,
							ReleaseDate = DateTime.Now,
							MovieCategory = Controllers.MovieCategory.Cartoon


						},
						new Movie()
						{
							Name = "Wednesday",
							Description = " MovieDesc3",
							ImageURL = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.imdb.com%2Ftitle%2Ftt13443470%2F&psig=AOvVaw3bnhup3Ln22-5Rl_6FlM8b&ust=1671389588882000&source=images&cd=vfe&ved=0CBAQjRxqFwoTCPD9nMypgfwCFQAAAAAdAAAAABAI",
							Duration = 3,
							ReleaseDate = DateTime.Now,
							MovieCategory = Controllers.MovieCategory.Horror


						},


					});
					context.SaveChanges();

					}
				}

			}

		}
	}


using ArtAnisaDiellzaTest.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
namespace ArtAnisaDiellzaTest.Data.Enum

{
	public class AppDbInitializer
	{

		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
			{

				    var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

				//context.Database.EnsureCreated();

				//Filmatttttttttttttttttttttttttttttttttttttttttt

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

                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://www.google.com/search?q=jim+carrey&sxsrf=ALiCzsbh_NwHSAEPvYwWCJeoQEXfqQDPDg:1671491033310&source=lnms&tbm=isch&sa=X&ved=2ahUKEwi4kqSq5Yb8AhXGQ_EDHeYbC0IQ_AUoAXoECAEQAw&biw=1536&bih=754&dpr=1.25#imgrc=rzc5r_BFfh0ZwM"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://www.google.com/search?q=tom+ellis&tbm=isch&ved=2ahUKEwjeh9qr5Yb8AhXTn_0HHf38CjUQ2-cCegQIABAA&oq=tom+ell&gs_lcp=CgNpbWcQARgAMggIABCABBCxAzIFCAAQgAQyCAgAEIAEELEDMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgUIABCABDoECCMQJzoKCAAQsQMQgwEQQzoLCAAQgAQQsQMQgwE6CAgAELEDEIMBOgcIIxDqAhAnOgQIABBDOgcIABCxAxBDUMkGWKEQYJAaaAFwAHgAgAGLAYgBoQeSAQMyLjaYAQCgAQGqAQtnd3Mtd2l6LWltZ7ABCsABAQ&sclient=img&ei=3O2gY96pEdO_9u8P_fmrqAM&bih=754&biw=1536#imgrc=uME6wpc6hIKQuM"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://www.google.com/search?q=jenna+ortega&tbm=isch&ved=2ahUKEwjz-ou45Yb8AhV09bsIHcU5AzIQ2-cCegQIABAA&oq=jenna+ortega&gs_lcp=CgNpbWcQAzIECAAQAzIECAAQAzIECAAQAzIECAAQAzIECAAQAzIECAAQAzIECAAQAzIECAAQAzIECAAQAzIICAAQsQMQgwE6BAgjECc6BQgAEIAEOgcIIxDqAhAnOgQIABBDOgcIABCxAxBDOgoIABCxAxCDARBDUIUGWPArYPQsaAFwAHgAgAFiiAGZCZIBAjEzmAEAoAEBqgELZ3dzLXdpei1pbWewAQrAAQE&sclient=img&ei=9u2gY_OnEPTq7_UPxfOMkAM&bih=754&biw=1536#imgrc=al8oKSk6_hqUVM"
                        }

                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://www.google.com/search?tbm=isch&q=Shelton+J.+Lee#imgrc=QoV8ifZUs1N6CM"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://www.google.com/search?tbm=isch&q=Michael+Bay#imgrc=QST7-6Sw5jH5XM"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://www.google.com/search?tbm=isch&q=Nina+Jacobson#imgrc=dl12Cpd8XZDLuM"
                        }
                        
                    });
                    context.SaveChanges();
                }

                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        
                    });
                    context.SaveChanges();
                }
            }

			}

		}
	}


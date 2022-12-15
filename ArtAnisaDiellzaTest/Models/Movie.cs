
namespace ArtAnisaDiellzaTest.Models;

using ArtAnisaDiellzaTest.Controllers;
using System.Windows;



public class Movie
{

	public int MovieID { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public string ImageURL { get; set; }

	public int Duration { get; set; }

	public DateTime ReleaseDate { get; set; }

	public MovieCategory MovieCategory { get; set; }







}

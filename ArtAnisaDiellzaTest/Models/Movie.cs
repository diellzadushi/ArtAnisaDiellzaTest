
namespace ArtAnisaDiellzaTest.Models;

using ArtAnisaDiellzaTest.Controllers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows;



public class Movie
{
    [Key]

    public int MovieID { get; set; }

    [Display(Name = "Name")]
    public string ?Name { get; set; }

    [Display(Name = "Description")]
    public string ?Description { get; set; }

    [Display(Name = "ImageURL")]
    public string ?ImageURL { get; set; }

    [Display(Name = "Duration")]
    public int Duration { get; set; }

    [Display(Name = "ReleaseDate")]
    public DateTime ReleaseDate { get; set; }

    [Display(Name = "MovieCategory")]
    public MovieCategory MovieCategory { get; set; }

    //Relationships

    public List<Actor_Movie> ?Actors_Movies { get; set; }


    //Producer
    
    public int? ProducerId { get; set; }
    [ForeignKey("ProducerId")]
    public Producer Producer { get; set; }
}

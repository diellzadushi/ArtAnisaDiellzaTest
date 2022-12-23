
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
    [Required(ErrorMessage = "Name is required")]
    public string ?Name { get; set; }

    [Display(Name = "Description")]
    [Required(ErrorMessage = "Description is required")]
    public string ?Description { get; set; }

    [Display(Name = "ImageURL")]
    [Required(ErrorMessage = "ImageURL is required")]
    public string ?ImageURL { get; set; }

    [Display(Name = "Duration")]
    [Required(ErrorMessage = "Duration is required")]
    public int Duration { get; set; }

    [Display(Name = "ReleaseDate")]
    [Required(ErrorMessage = "ReleaseDate is required")]
    public DateTime ReleaseDate { get; set; }

    [Display(Name = "MovieCategory")]
    [Required(ErrorMessage = "MovieCategory is required")]
    public MovieCategory MovieCategory { get; set; }

    //Relationships

    public List<Actor_Movie> ?Actors_Movies { get; set; }


    //Producer
    
    public int? ProducerId { get; set; }
    [ForeignKey("ProducerId")]
    public Producer Producer { get; set; }
}

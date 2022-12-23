using ArtAnisaDiellzaTest.Data;
using ArtAnisaDiellzaTest.Data.Services;
using ArtAnisaDiellzaTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArtAnisaDiellzaTest.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Movies/Create

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Description,ImageURL,Duration,ReleaseDate,MovieCategory")]Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }
            await _service.AddAsync(movie);
            return RedirectToAction(nameof(Index));
        }

        //Get: Movies/Details/id of the movie
        public async Task<IActionResult> Details(int id)
        {
            var movieDetails = await _service.GetByIdAsync(id);
            if (movieDetails == null) return View("Not found");
            return View(movieDetails);
        }

        //Get: Actors/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var movieDetails = await _service.GetByIdAsync(id);
            if (movieDetails == null) return View("Not found");
            return View(movieDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,Name,Description,ImageURL,Duration,ReleaseDate,MovieCategory")] Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }
            await _service.UpdateAsync(id,movie);
            return RedirectToAction(nameof(Index));
        }

    }
}

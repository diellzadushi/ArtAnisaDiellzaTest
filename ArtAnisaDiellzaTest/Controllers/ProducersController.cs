using ArtAnisaDiellzaTest.Data;
using ArtAnisaDiellzaTest.Data.Services;
using ArtAnisaDiellzaTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ArtAnisaDiellzaTest.Controllers
{
    public class ProducersController : Controller
    {

        private readonly IProducersServices _service;
    
        public ProducersController( IProducersServices service)
        {
            _service = service;
        }

        public async  Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);

        }
        //get producers/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _service.AddAsync(producer);
            return RedirectToAction(nameof(Index));

        }

        //Get:Producers/Details/id of the rpducer

        public async Task<IActionResult> Details(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("Not found");
            return View(producerDetails);
        }

        //Get:Producers/Edit

        public async Task<IActionResult> Edit(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("Not found");
            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return View(producer);
            }
            await _service.UpdateAsync(id, producer);
            return RedirectToAction(nameof(Index));

        }

        //Get:Prodicers/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id);
            if (producerDetails == null) return View("Not found");
            return View(producerDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = _service.GetByIdAsync(id);
            if (producerDetails == null) return View("Not found");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));

        }
    }
}

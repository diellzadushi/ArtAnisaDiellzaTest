using ArtAnisaDiellzaTest.Data.Base;
using ArtAnisaDiellzaTest.Data.Services;
using ArtAnisaDiellzaTest.Data;
using ArtAnisaDiellzaTest.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtAnisaDiellzaTest.Data.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly AppDbContext _context;

        public MoviesService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            var result =await _context.Movies.ToListAsync();
            return result;
        }

        public async Task<Movie> GetByIdAsync(int id)
        {
            var result = await _context.Movies.FirstOrDefaultAsync(n => n.MovieID == id);
            return result;
        }

        public async Task<Movie> UpdateAsync(int id, Movie newMovie)
        {
            _context.Update(newMovie);
            await _context.SaveChangesAsync();
            return newMovie;
        }
    }
}


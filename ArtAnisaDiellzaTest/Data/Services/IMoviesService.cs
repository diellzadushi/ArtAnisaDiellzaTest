using ArtAnisaDiellzaTest.Data.Base;
using ArtAnisaDiellzaTest.Data;
using ArtAnisaDiellzaTest.Models;

namespace ArtAnisaDiellzaTest.Data.Services
{
    public interface IMoviesService
    {
        Task<IEnumerable<Movie>> GetAllAsync();
        Task<Movie> GetByIdAsync(int id);
        Task AddAsync(Movie movie);
        
        Task<Movie> UpdateAsync(int id, Movie newMovie);

        void Delete(int id);
    }
}

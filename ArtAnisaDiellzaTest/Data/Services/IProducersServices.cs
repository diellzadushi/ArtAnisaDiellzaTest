using ArtAnisaDiellzaTest.Models;

namespace ArtAnisaDiellzaTest.Data.Services
{
    public interface IProducersServices
    {
        Task<IEnumerable<Producer>> GetAllAsync();  

        Task<Producer> GetByIdAsync(int id);

        Task AddAsync(Producer producer);

        Task<Producer> UpdateAsync(int id, Producer newProducer);

         Task DeleteAsync(int id);    




    }
}

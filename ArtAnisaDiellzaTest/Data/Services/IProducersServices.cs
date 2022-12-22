using ArtAnisaDiellzaTest.Models;

namespace ArtAnisaDiellzaTest.Data.Services
{
    public interface IProducersServices
    {
        Task<IEnumerable<Producer>> GetAllAsync();  

        Task<Producer> GetByIdAsync(int id);

        Task AddAsync(Producer producer);

        Producer Update(int id, Producer newProducer);

        void Delete(int id);    




    }
}

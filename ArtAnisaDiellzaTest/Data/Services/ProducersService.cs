using ArtAnisaDiellzaTest.Models;
using Microsoft.EntityFrameworkCore;

namespace ArtAnisaDiellzaTest.Data.Services
{
    public class ProducersService : IProducersServices
    {
        private readonly AppDbContext _context;

        public ProducersService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Producer producer)
        {
            await _context.Producers.AddAsync(producer);
            await _context.SaveChangesAsync();

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Producer>> GetAllAsync()
        {
            var result = await _context.Producers.ToListAsync();
            return result;
        }

        public async Task<Producer> GetByIdAsync(int id)
        {
            var result = await _context.Producers.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public Producer Update(int id, Producer newProducer)
        {
            throw new NotImplementedException();
        }
    }
}

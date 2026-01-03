using Application;
using Data;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class Repository : IRepository
    {

        private readonly AppDbContext _dbContext; 

        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task AddAsync(Beer beer)
        {
            await _dbContext.Beers.AddAsync(beer);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Beer>> GetBeersAsync()
        {
            return await _dbContext.Beers.ToListAsync();
        }

        public async Task<Beer> GetByIdAsync(int id)
        {
            return await _dbContext.Beers.FindAsync(id); 
        }
    }
}

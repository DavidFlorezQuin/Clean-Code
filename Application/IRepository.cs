using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public interface IRepository
    {
        Task<Beer> GetByIdAsync(int  id);
        Task<IEnumerable<Beer>> GetBeersAsync();  
        Task AddAsync (Beer beer);
    }
}

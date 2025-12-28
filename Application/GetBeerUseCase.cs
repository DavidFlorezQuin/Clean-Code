using Entities;

namespace Application
{
    public class GetBeerUseCase
    {
        private readonly IRepository _beerRespository; 

        public GetBeerUseCase (IRepository beerRespository)
        {
            _beerRespository = beerRespository;
        }

        public async Task<IEnumerable<Beer>> ExecuteAsync()
        {
            return await _beerRespository.GetBeersAsync();
        }
    }
}

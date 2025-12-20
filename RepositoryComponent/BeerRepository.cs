using BusinessComponents;

namespace RepositoryComponent
{
    public class BeerRepository : IRepository
    {

        private List<String> _list; 
        public BeerRepository()
        {
            _list = new List<String>();
        }

        public void Add(String name) =>
            _list.Add(name);

        public string Get() =>
            _list.Aggregate("", (acc, beer) => acc + beer + ", ");
    }
}

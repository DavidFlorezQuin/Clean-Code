using System.Reflection.Metadata;

namespace BusinessComponents
{
    public class BeerManager
    {
        private IRepository _repository; 

        public BeerManager(IRepository repository)
        {
            _repository = repository;
        }

        public void Add(string Name)
        {
            if (String.IsNullOrEmpty(Name)) throw new ArgumentNullException("name");

            _repository.Add(Name);
        }

        public string Get()
            => "Las servezas son: " + _repository.Get();
    }
}

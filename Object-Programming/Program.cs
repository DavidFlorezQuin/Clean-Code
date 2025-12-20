

using BusinessComponents;
using RepositoryComponent;

var beerManager = new BeerManager(new BeerRepository());

beerManager.Add("Costeña");
beerManager.Add("Corona");
Console.WriteLine(beerManager.Get());
public class DefaultRepository : IRepository
{
    public void Add(string name)
    {

    }
    public string Get() =>
        "Algo";
}
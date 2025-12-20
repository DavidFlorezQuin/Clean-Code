

using BusinessComponents;
using Microsoft.Extensions.DependencyInjection;
using RepositoryComponent;

var container = new ServiceCollection()
    .AddSingleton<IRepository, BeerRepository>()
    .AddTransient<BeerManager>()
    .BuildServiceProvider(); 


var beerManager = container.GetService<BeerManager>();

public class DefaultRepository : IRepository
{
    public void Add(string name)
    {

    }
    public string Get() =>
        "Algo";
}
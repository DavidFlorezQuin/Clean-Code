
namespace Object_Programming.Business
{
    public class ExpiringBeer : Beer
    {

        public DateTime Expiration { get; set; }
        public ExpiringBeer(string name, decimal alcohol, decimal balance, DateTime experation, int quantity) 
            : base (name, alcohol, balance, quantity){ 
        Expiration = experation;
        }

        public override string getInfo()
        {
            return "La cerveza " + Name + "ml de alcohol" + Alcohol;

        }

        public override int getPrice()
        {
            return (int)(Alcohol * 3); 
        }
    }
}

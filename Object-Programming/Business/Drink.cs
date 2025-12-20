
namespace Object_Programming.Business
{
    public abstract class Drink
    {
        public int quantity { get; set; }

        public Drink(int quantity)
        {
            this.quantity = quantity;
        }

        public abstract string getDetail();

    }
}

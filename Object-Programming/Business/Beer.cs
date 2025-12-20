
using System.Timers;

namespace Object_Programming.Business
{
    public class Beer : Drink, ISalable
    {
        public Beer(string name, decimal alcohol, decimal balance, int quantity) : base (quantity)
        {
            Name = name; 
            Alcohol = alcohol;
            Balance = balance;
        }


        private decimal _alcohol;
        private const string Category = "Cerveza"; 
        public string Name { get; set; }

        public decimal Alcohol
        {
            get
            {
                return _alcohol;
            }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _alcohol = value;
            }
        }

        public decimal Balance { get; set; }

        public string SAlcohol
        {
            get
            {
                return "La cerveza tiene: " + Alcohol + "ml de alcohol";
            }
        }

        public virtual string getInfo()
        { 
            return "La cerveza " + Name  + "ml de alcohol" + Alcohol ;

        }

        public string getInfo(string text)
        {
            return "Lo que quiero decir es: " + text;
        }

        public string getInfo(int index)
        {
            return "El numero que almacené fue: " + index; 
        }

        public override string getDetail() =>
            Category;

        public virtual int getPrice()
        {
            return (int)(_alcohol * 4);

        }
    }   

}

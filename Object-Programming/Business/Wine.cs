using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Programming.Business
{
    public class Wine : Drink
    {
        public const string Category = "Vino";
        public Wine (int quantity) : base(quantity)
        {
            
        }

        public override string getDetail() =>
            Category; 
    }
}

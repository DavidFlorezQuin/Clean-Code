using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Programming.Business
{
    public class Services : ISalable
    {

        private int _price;
        private int _taxes;
        public Services(int price, int taxes) { 
        
        _price = price;
            _taxes = taxes;
         }
        public int getPrice()
        {
            return _price * _taxes; 
        }

    }
}

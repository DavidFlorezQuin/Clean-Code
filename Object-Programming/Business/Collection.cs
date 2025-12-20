using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Programming.Business
{
    public class Collection<T>
    {

        private int _index;
        private int _limit;
        private T[] _elements;

        public Collection(int limit)
        {
            _index = 0; 
            _limit = limit;
            _elements = new T[_limit]; 
        }


        public void Add(T element)
        {
            if (_index < _limit)
            {
                _elements[_index] = element;
                _index++;
            }
        }
        public T[] GetValues() =>
            _elements;
    }
}

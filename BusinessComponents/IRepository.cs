using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessComponents
{
    public interface IRepository
    {
        void Add(string beer);
        string Get();
    }
}

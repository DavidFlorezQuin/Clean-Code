using System;
using System.Collections.Generic;
using System.Text;

namespace StructureProgramming
{
    public class Person : ILivingBeings
    {
        public void Breath()
        {
            Console.WriteLine("The person is breathing"); 
        }

        public void Comunicate()
        {
            Console.WriteLine("The person is talking");
        }

        public void Walk()
        {
            Console.WriteLine("The person is walking");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;


namespace StructureProgramming
{
    public class Dog : ILivingBeings
    {
        Action<string> print = message => Console.WriteLine(message); 
        public void Breath()
        {
            print("The dog is breathing");     
        }

        public void Comunicate()
        {
            print("The dog is barking");
        }

        public void Walk()
        {
            print("The dog is running");
        }
    }
}

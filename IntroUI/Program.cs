using System;
using IntroLibrary;

namespace IntroUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel p = new PersonModel {
                FirstName = "Anderson",
                LastName = "Silva",
                Age = 32
            };

            Console.WriteLine("${ p.FirstName } ${ p.LastName } is ${p.Age} years old ");
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is a test");
        }
    }
}

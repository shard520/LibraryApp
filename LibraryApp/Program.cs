using LibraryApp.Library;
using LibraryApp.People;
using System;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student Stephen = new Student("Stephen Doyle", "13/04/2002", 1001);
            Console.WriteLine(Stephen.Name);
            Console.WriteLine(Stephen.Age);
            Console.WriteLine(Stephen.CourseId);
            Stephen.Greeting();

            var troy = new Book("The Mask of Troy") 
            {
                Genre = "History" 
            };
        }
    }
}

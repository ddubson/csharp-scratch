using Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exploring_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteStatement();
            ExampleOfNamespace();
        }

        private static void ExampleOfNamespace()
        {
            TypicalPerson person = new TypicalPerson();
            person.name = "You!";

            Console.WriteLine(person.name);
        }

        private static void WriteStatement()
        {
            var FirstName = "James";
            var LastName = "Bond";
            var FullName = $"{FirstName} {LastName}"; // String Interpolation goodness in C#

            Console.WriteLine($"My Name is {FullName}");
        }
    }
}

namespace Person
{
    class TypicalPerson
    {
        public String name { get; set; } 
    }
}
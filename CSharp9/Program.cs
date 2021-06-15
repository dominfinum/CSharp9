using System;
using System.Collections.Generic;

namespace CSharp9
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonRec personRec = new("Marko", "Nikolic");
            PersonRec personRec1 = new("Marko", "Nikolic");
            PersonRec personRec2 = new("Marko", "Dosen");

            PersonClass personCl = new("Dona", "Pejnovic");
            PersonClass personCl1 = new("Dona", "Pejnovic");
            PersonClass personCl2 = new("Vedran", "Perkovic");

            //Console.WriteLine("Record Type:");
            //Console.WriteLine($"To string: { personRec }");
            //Console.WriteLine($"Equals: { Equals(personRec, personRec1) }");
            //Console.WriteLine($"Reference Equals: { ReferenceEquals(personRec, personRec1) }");
            //Console.WriteLine($"==: { personRec == personRec1 }");
            //Console.WriteLine($"Hash code: { personRec.GetHashCode() }");
            //Console.WriteLine($"Hash code: { personRec1.GetHashCode() }");
            //Console.WriteLine($"Hash code: { personRec2.GetHashCode() }");

            //Console.WriteLine("****************");
            //Console.WriteLine("Class Type:");
            //Console.WriteLine($"To string: { personCl }");
            //Console.WriteLine($"Equals: { Equals(personCl, personCl1) }");
            //Console.WriteLine($"Reference Equals: { ReferenceEquals(personCl, personCl1) }");
            //Console.WriteLine($"==: { personCl == personCl1 }");
            //Console.WriteLine($"Hash code: { personCl.GetHashCode() }");
            //Console.WriteLine($"Hash code: { personCl1.GetHashCode() }");

            //PersonRec personRec4 = personRec with
            //{
            //    LastName = "Dosen"
            //};

            //Console.WriteLine($"To string: { personRec4 }");

            //var (fn, ln) = personRec4;
            //Console.WriteLine($"First name: { fn } Last name: { ln }");

            //PersonRec personRec5 = new Developer("Dominik", "Blazic", "C#");
            //Console.WriteLine($"To string: { personRec5 }");

            //List<PersonClass> people = new() { personCl, personCl2 };

            //foreach (var person in people)
            //{
            //    person.Summary = person.FirstName.Length switch
            //    {
            //        < 4 => "very short name",
            //        4 => "short name",
            //        //> 4 => "Long name",
            //        _ => "unkown"
            //    };

            //    Console.WriteLine($"{person.FirstName} has a {person.Summary}");
            //}

        }
    }

    
}

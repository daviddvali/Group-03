using Fauna.Classes.AnimalClasses;
using MyArrayHelperLibary;

namespace Fauna;

class Program
{
    static void Main()
    {
        Dog[] dogs = new Dog[]
        {
            new Dog("Buddy")   { Weight = 30 },
            new Dog("Max")     { Weight = 25 },
            new Dog("Rocky")   { Weight = 35 },
            new Dog("Charlie") { Weight = 20 },
            new Dog("Cooper")  { Weight = 40 },
            new Dog("Duke")    { Weight = 28 },
            new Dog("Bear")    { Weight = 32 },
            new Dog("Toby")    { Weight = 22 },
            new Dog("Riley")   { Weight = 38 },
            new Dog("Zeus")    { Weight = 26 }
        };

        MyArray.PrintArray(dogs);
        Console.WriteLine("- - - - - - - - - - - - - - - -");
        MyArray.Sort(dogs);
        MyArray.PrintArray(dogs);
    }
}
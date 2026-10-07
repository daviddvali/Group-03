namespace Fauna;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal("Animal");
        Console.WriteLine();
        Dog dog = new Dog("Grafi");
        Console.WriteLine();
        Cat cat = new Cat("Garfildi");
        Console.WriteLine();
        Shark shark = new Shark();
        Console.WriteLine();
        SuperDog superDog = new SuperDog();
    }
}
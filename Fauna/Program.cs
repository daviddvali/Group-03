namespace Fauna;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal("Animal");
        animal.Move();
        Console.WriteLine();
        Dog dog = new Dog("Grafi");
        dog.Move();
        Console.WriteLine();
        Cat cat = new Cat("Garfildi");
        cat.Move();
        Console.WriteLine();
        Shark shark = new Shark();
        shark.Move();
        Console.WriteLine();
        SuperDog superDog = new SuperDog();
        superDog.Move();
    }
}
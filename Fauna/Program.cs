namespace Fauna;

class Program
{
    static void Main()
    {
        IMyComparable[] items =
        {
            new Dog() { Name = "Dog1", Weight = 30 },
            new Dog() { Name = "Dog2", Weight = 15 },
            new Bird() { Name = "Bird", Weight = 1 },
            new Bee() { Name = "Bee", Weight = 0.1 },
            new SuperDog() { Name = "SuperDog", Weight = 30 },
            new Cat() { Name = "Cat", Weight = 7 },
            new Shark() { Name = "Shark", Weight = 100 },
            new Car() { Name = "Car", Weight = 1500 },
            new Plane() { Weight = 2000 }
        };

        Console.Clear();
        MyArray.Sort(items);
        Console.WriteLine("\n__ Sort by Weight __\n");
        foreach (var item in items) Console.WriteLine(item);
        
        MyArray.Sort(items, new NameComparer());
        Console.WriteLine("\n__ Sort by Name __\n");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}
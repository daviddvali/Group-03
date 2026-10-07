namespace Fauna;

public class Cat : Animal
{
    public Cat() : base("Cat")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Cat was created!");
        Console.ResetColor();
    }

    public Cat(string name) : base(name)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Cat with name {name} was created!");
        Console.ResetColor();
    }

    public void Meow()
    {
        Console.WriteLine("Cat is meowing");
    }
}
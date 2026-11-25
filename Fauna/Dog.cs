namespace Fauna;

public class Dog : Animal, Comparable
{
    public Dog() : base()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Dog was created!");
        Console.ResetColor();
    }

    public Dog(string name) : base(name)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Dog with name {name} was created!");
        Console.ResetColor();
    }

    public int CompareTo(object? item)
    {
        if (item == null) return 1;
        if (item is Dog dog)
        {
            if (this.Weight > dog.Weight) return 1;
            if (this.Weight < dog.Weight) return -1;
            return 0;
        }
        throw new ArgumentException("Object is not a Dog");
    }

    public void Bark()
    {
        Console.WriteLine("Dog is barking");
    }

    //public sealed override void Move()
    //{
    //    base.Move();
    //} 

    protected override void Breath()
    {
        base.Breath();
        Console.WriteLine("Dog is breathing with lungs");
    }
}

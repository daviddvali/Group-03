using MyArrayHelperLibary;

namespace Fauna.Classes.Base;

public abstract class Creature : MyComparable
{
    public Creature()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Creature was created!");
        Console.ResetColor();
        Breath();
    }

    public string Name { get; set; }

    public double Weight { get; set; }

    public virtual void Move() 
    {
        Console.WriteLine("Creature is moving");
    }

    protected abstract void Breath();

    public override int CompareTo(object? item)
    {
        if (item == null) return 1;
        Creature? otherCreature = item as Creature;
        if (otherCreature == null) throw new ArgumentException("Object is not a Creature");
        if (this.Weight < otherCreature.Weight) return -1;
        else if (this.Weight > otherCreature.Weight) return 1;
        else return 0;
    }
}

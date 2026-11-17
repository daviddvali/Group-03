namespace Fauna;

public abstract class Creature : Comparable
{
    public Creature()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Creature was created!");
        Console.ResetColor();
        Console.WriteLine();
        Breath();
    }

    public string? Name { get; set; }

    public double Weight { get; set; }

    public virtual void Move() 
    {
        Console.WriteLine("Creature is moving");
    }

    protected abstract void Breath();

    public override int CompareTo(object? item)
    {
        if (item is Creature otherCreature)
        {
            if (this.Weight > otherCreature.Weight) return 1;
            if (this.Weight < otherCreature.Weight) return -1;
            return 0;
        }
        throw new ArgumentException("Object is not a Creature");
    }
    public override string ToString()
    {
        return $"{GetType().Name}: {Name?? "Unnamed"}, Weight: {Weight} kg";
    }
}

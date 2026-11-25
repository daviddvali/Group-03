namespace Fauna;

public class Creature : IMyComparable
{
    public Creature()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Creature was created!");
        Console.ResetColor();
        Breath();
    }

    public string? Name { get; set; }
    public double Weight { get; set; }

    public virtual void Move()
    {
        Console.WriteLine("Creature is moving");
    }

    protected virtual void Breath()
    {
        Console.WriteLine("Creature is breathing");
    }

    public int CompareTo(object? item)
    {
        double otherWeight = item switch
        {
            Creature c => c.Weight,
            Vehicle v => v.Weight,
            _ => throw new ArgumentException("Object cannot be compared by weight")
        };

        if (this.Weight > otherWeight) return 1;
        if (this.Weight < otherWeight) return -1;
        return 0;
    }

    public override string ToString()
    {
        return $"{GetType().Name}: {Name ?? "Unnamed"}, Weight: {Weight} kg";
    }
}
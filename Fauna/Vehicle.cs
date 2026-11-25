namespace Fauna;

public class Vehicle : IMyComparable
{
    public string? Name { get; set; }
    public double Weight { get; set; }

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
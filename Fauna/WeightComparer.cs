namespace Fauna;

public class WeightComparer : IMyComparer
{
    public int Compare(object? x, object? y)
    {
        double w1 = GetWeight(x);
        double w2 = GetWeight(y);

        if (w1 > w2) return 1;
        if (w1 < w2) return -1;
        return 0;
    }

    private double GetWeight(object? obj) => obj switch
    {
        Creature c => c.Weight,
        Vehicle v => v.Weight,
        _ => throw new ArgumentException("Object must be Creature or Vehicle")
    };
}
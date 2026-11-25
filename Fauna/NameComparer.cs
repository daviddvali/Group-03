namespace Fauna;

public class NameComparer : IMyComparer
{
    public int Compare(object? x, object? y)
    {
        string? n1 = GetName(x);
        string? n2 = GetName(y);

        return string.Compare(n1, n2, StringComparison.Ordinal);
    }

    private string? GetName(object? obj) => obj switch
    {
        Creature c => c.Name,
        Vehicle v => v.Name,
        _ => throw new ArgumentException("Object must be Creature or Vehicle")
    };
}
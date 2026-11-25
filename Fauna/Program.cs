namespace Fauna;

class Program
{
    static void Main()
    {
        Dog[] dog =
            {
            new Dog("Max") { Weight = 25 },
            new Dog("Hask") { Weight = 20 },
            new Dog("Bondo") { Weight = 5 },
            new Dog("Hans") { Weight = 15 }
            };
        MyArray.Sort(dog);
        for (int i = 0; i < dog.Length; i++)
        {
            Console.WriteLine($"Dog {i + 1} weight: {dog[i].Weight}");
        }
    }
}
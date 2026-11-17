using Fauna.Classes.Base;

namespace Fauna.Classes.InsectClasses;

public class Insect : Creature
{
    public Insect()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Insect was created!");
        Console.ResetColor();
    }

    public void Crawl()
    {
        Console.WriteLine("Insect is crawling");
    }

    protected override void Breath()
    {
        Console.WriteLine("Insect is breathing with spiracles");
    }
}
namespace Fauna;

class Program
{
    static void Main()
    {
        Creature[] creatures =
        {
            new Dog() { Name = "Dog1", Weight = 10 },
            new Dog() { Name = "Dog2", Weight = 15 },
            new Dog() { Name = "Dog3", Weight = 25 },
            new Dog() { Name = "Dog4", Weight = 20 },
            new Dog() { Name = "Dog5", Weight = 5 },
            new Bird() { Name = "Bird1", Weight = 1 },
            new Bee { Name = "Bee1", Weight = 0.1 },
            new SuperDog() { Name = "SuperDog1", Weight = 30 },
            new Cat() { Name = "Cat1", Weight = 7 },
            new Shark() { Name = "Shark1", Weight = 100 }
        };

        Console.Clear();

        MyArray.Sort(creatures);

        for (int i = 0; i < creatures.Length; i++)
        {
            Console.WriteLine(creatures[i]);
            //CallMove(creatures[i]);
            Console.WriteLine();
        }
    }

    static void CallMove(Creature creature)
    {
        creature.Move();

        if (creature is Dog dog)
        {
            //dog.Bark();
            //dog.Bark();
            //dog.Bark();
        }
    }
}
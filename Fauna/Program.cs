namespace Fauna;

class Program
{
    static void Main()
    {
        Dog dog1 = new Dog() { Weight = 10 };
        Dog dog2 = new Dog() { Weight = 15 };
        Dog dog3 = new Dog() { Weight = 25 };
        SuperDog superDog1 = new SuperDog() { Weight = 30 };
        Cat cat1 = new Cat() { Weight = 7 };
        Shark shark1 = new Shark() { Weight = 100 };

        Console.Clear();

        CallMove(dog1);
        CallMove(dog2);
        CallMove(dog3);
        CallMove(superDog1);
        CallMove(cat1);
        CallMove(shark1);
    }

    static void CallMove(Creature creature)
    {
        if (creature.Weight > 5)
            creature.Move();
    }
}
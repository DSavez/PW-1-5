List<IAnimal> myAnimals = new List<IAnimal>();
myAnimals.Add(new Dog());
myAnimals.Add(new Cat());
myAnimals.Add(new Pig());
myAnimals.Add(new Parrot());
myAnimals.Add(new Hamster());



foreach (IAnimal animal in myAnimals)
{
    PetAnimal(animal);
}



Console.ReadKey(true);



static void PetAnimal(IAnimal animal)
{
    Console.WriteLine("Животинка делает :");
    animal.Voice();
}
interface IAnimal
{
    void Voice();
}
class Dog : IAnimal { public void Voice() { Console.WriteLine("Гав!"); } }
class Cat : IAnimal { public void Voice() { Console.WriteLine("Мяу!"); } }
class Pig : IAnimal
{
    private int GetCurrentTime()
    {
        try { return Convert.ToInt32(File.ReadAllText("current_time.txt")); }
        catch { return 0; }
    }
    public void Voice()
    {
        int currentTime = GetCurrentTime();
        if ((currentTime >= 8) && (currentTime <= 21))
        {
            Console.WriteLine("Я СПЛЮ");
        }
        else { Console.WriteLine("УХАЕТ"); }
    }



}
class Parrot : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Чирик-чирик!");
    }
}
class Hamster : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("*пищит* Мы сдадим все праки вовремя!");
    }
}
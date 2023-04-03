

List<IHello> Greetings = new List<IHello>();

Greetings.Add(new Rus());

Greetings.Add(new Eng());

Greetings.Add(new Deu());

foreach (IHello lang in Greetings)

{

    lang.SayHello();

}

Console.ReadKey(true);

interface IHello

{

    void SayHello();

}



class Rus : IHello { public void SayHello() { Console.WriteLine("Привет!"); } }

class Eng : IHello { public void SayHello() { Console.WriteLine("Hello!"); } }

class Deu : IHello { public void SayHello() { Console.WriteLine("Guten Tag!"); } }



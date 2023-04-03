List<IShare> Draft= new List<IShare>();
Draft.Add(new VerticalLine());
Draft.Add(new HorizontalLine());
Draft.Add(new Square());
Console.WriteLine("Введите размер фигур");
int size = Convert.ToInt16(Console.ReadLine());
foreach (IShare sketch in Draft)
{
    sketch.Draw(size);
    Console.WriteLine();
}
Console.WriteLine();

Console.ReadKey(true);

interface IShare
{
    void Draw(int size);
}
class VerticalLine : IShare { 
    public void Draw(int size) 
    { 
        for (int i = 0; i<=size; i++)
        {
            Console.Write("-");
        }
          
    } 
}
class HorizontalLine : IShare
{
    public void Draw(int size)
    {
        for (int i = 0; i<=size; i++){
        Console.WriteLine("|"); }
    }
}
 class Square : IShare
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
            
        for (int q = 0; q < size; q++)
            {  
            Console.Write("|");
            for (int i = 0; i < (size - 2); i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            Console.WriteLine();
            }
            for (int i = 0; i<size; i++)
        {
            Console.Write("-");
        }
    }
}
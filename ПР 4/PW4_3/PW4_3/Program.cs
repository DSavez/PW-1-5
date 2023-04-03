Orcs army = new Orcs(0, 0);
for (int i = 1; i < 11; i++)
{
    army.Boostarmy();
}
Console.ReadKey(true);

class Orcs
{
    public int Gold { get; set; }
    public int OrcsCount { get; set; }
    public Orcs(int gold, int quantity)
    {
        Gold = gold;
        OrcsCount = quantity;
    }
    public void Boostarmy() 
    {
        OrcsCount++;
        Gold += 2;
        if (OrcsCount > 5 )
        {

            Console.WriteLine("Колличество переносимого золота - " + (Gold-2) + " единиц золота " + "Ожидалось: "+Gold + " Орк номер - "+OrcsCount);
        }
        else
        {
            Console.WriteLine("Колличество переносимого золота - " + Gold + " единиц золота "+"Ожидалось: " + Gold + " Орк номер - " + OrcsCount);
        }
        
       
    }

}
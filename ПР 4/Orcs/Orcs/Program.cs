Orc army = new Orc(0,1);
for (int i=1; i<20; i++)//увеличение от отдного до 20 орков
{
    army.inc();
}
Console.ReadKey(true);

class Orc
{
    public int Gold { get; set; }//кол-во золота
    public int Quantity { get; set; }//кол-во орков
    public Orc(int gold, int quantity) 
        {
        Gold = gold;
        Quantity = quantity;
}
    public void inc() //функция увеличения кол-ва орков
    {
        Quantity++;
        Gold += 2;
        if (Quantity > 5) { Gold += 2*(Quantity-5);//если в отряде есть 5 орков,
                                             //то каждый новый подворовывает по 2 ед. золота
        }
        Console.WriteLine("Получено "+Gold+" единиц золота");
    }

}

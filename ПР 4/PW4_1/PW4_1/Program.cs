Spell ondyzi = new Spell(20, "Отпирание ондузи","ondyzi");
Spell levitation = new Spell(100, "Левитация", "levitation");
Magician nerevar = new Magician("nerevar", 100);

nerevar.CastSpell(ondyzi);//удалить для того чтобы хватило манны
nerevar.CastSpell(levitation);
Console.ReadKey(true);
class Spell
{
    public int Mana { get; private set; }
    private string Effect { get; set; }
    public string Spellname { get; set; }
    public Spell(int mana, string effect,string spellname)
    {
        Mana = mana;
        Effect = effect;
        Spellname = spellname;
    }
    public void Use() { Console.WriteLine(Effect); }
}
class Magician
{
    public string Name { get; private set; }
    public int Mana { get; private set; }
    public Magician(string name, int mana)
    {
        Name = name;
        Mana = mana;
    }
    public void CastSpell(Spell spell)
    {
        if (Mana >= spell.Mana)
        {
            Console.WriteLine(Name + " Использует способность!");
            spell.Use(); Mana -= spell.Mana;
        }
        else
        {
            
            Console.WriteLine("Для испольования " + "заклинания " + spell.Spellname + " не хватает " + (Math.Abs(spell.Mana - Mana)) + " единиц маны." +
            " Хлебните зелья!");
        }
    }
}





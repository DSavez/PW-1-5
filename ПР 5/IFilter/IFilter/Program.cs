Console.Write("Enter the text : ");
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
string textLine=Convert.ToString(value: Console.ReadLine());
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
Console.WriteLine("Choose your filter:1-digit, 2-letter ");
int f = Convert.ToInt16(Console.ReadLine());


Oper(textLine, f);
//if (f == 1) { Dig.Execute(text); }
//if (f==2) { Let.Execute(text); }

Console.WriteLine(textLine);
Console.ReadKey(true);
static string Oper(string textLine, int methN){
    DigitFilter Dig = new DigitFilter();
    LetterFilter Let = new LetterFilter();
    if (methN == 1) { textLine = Dig.Execute(textLine); }
    else {textLine= Let.Execute(textLine); }
    return textLine;
}

interface IFilter
    {
    string Execute(string textLine);
}
//Deleting digit class
class DigitFilter : IFilter { public string Execute(string textLine){
     textLine.Replace("(0123456789)", "");
            //string.Join(null, System.Text.RegularExpressions.Regex.Split(textLine, "[\\d]"));
            //Regex.Replace(textLine,@"[0-9]", "") ;
        return textLine;               //s = string.Join(null, System.Text.RegularExpressions.Regex.Split(s, "[\\d]"))
    } }
//Deleting letters class
class LetterFilter : IFilter { public string Execute(string textLine) { textLine.Replace("(?i)[qwertyuiopasdfghjklmnbvcxz]", "");
        return textLine;
    } }
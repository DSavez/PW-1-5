Mail Onlinetrade = new Mail("GTX750TI", 300);
Mail Ebai = new Mail("RTX3060", 800);
MailService Express = new MailService("Express", 1000);

Express.Send_Mailing(Ebai);
Express.Send_Mailing(Onlinetrade);
Console.ReadKey(true);
class Mail
{
    public string Text { get; private set; }
    public int Weight { get; set; }
    public Mail(string text, int weight)
    {
        Text = text;
        Weight = weight;
    }
    public void Use() { Console.WriteLine(Weight); }
}
class MailService
{
    public string Name { get; private set; }
    private int Limit { get; set; }
    public MailService(string name, int limit)
    {
        Name = name;
        Limit = limit;
    }
    public void Send_Mailing(Mail mail)
    {
        
        if (mail.Weight<Limit)
        {
            Console.WriteLine("Посылка " + mail.Text);
            Limit -= mail.Weight;
        }
        else { Console.WriteLine("Лминит веса превышен"); }
    }
}
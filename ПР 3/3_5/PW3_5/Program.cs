namespace PW3_2
{
    class programm
    {
        static void Main()
        {

            Console.WriteLine("Введите текст");
            string sms = Console.ReadLine();
            Console.WriteLine("Введите Цену");
            double Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Макс длинну");
            double MaxLenght = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите Цену за символ");
            double Charprice = Convert.ToDouble(Console.ReadLine());
            SmsMessage message = new SmsMessage(sms,Price,MaxLenght,Charprice);
            message.Displayinfo();


        }
    }
    class SmsMessage
    {
        private string Messagetext;
        public double Price;
        public double MaxLenght;
        public double Charprice;





        public SmsMessage(string smstext,double Price,double MaxLenght,double Charprice)
        {
            Messagetext = smstext;
            this.Price = Price;
            this.Charprice = Charprice;
            this.MaxLenght=MaxLenght;

        }
        public string smstext
        {
            get { return smstext; }
            set { smstext = Normalizesms(value); }
        }
       

        public string Normalizesms(string value)
        {
            string S = value;
            char[] A_S = new char[S.Length];
            for (int i = 0; i < A_S.Length; i++)
            {
                A_S[i] = S[i];
            }
            if (S.Length < 65)
            {

                Console.WriteLine("Цена1 : " + Price + " ");


            }
            else
            {
                if ((S.Length > 65) && (S.Length < MaxLenght))
                {
                    double n = 0;
                    for (int i = 0; i < A_S.Length - 65; i++)
                    {
                        n = n + Charprice;
                    }
                    Price = Price + n;
                    Console.WriteLine("Цена2 : " + Price + " ");


                }
                else
                {
                    value = "";
                    double n = 0;
                    
                    for (int i = 0; i < MaxLenght; i++)
                    {
                        value = value + Convert.ToString(A_S[i]);
                        n = n + Charprice;
                    }
                    Price = Price + n;
                    Console.WriteLine("Цена3 : " + Price + " ");
                }
            }

            return value;
        }
        public void Displayinfo()
        {
            Console.WriteLine($"{Normalizesms(Messagetext)}");
        }
    }
}
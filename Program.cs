using System;


namespace Matrix
{


    class Program
    {
        static void Main(string[] args)
        {

            Cikles raw = new Cikles();
            Variator ruf = new Variator();

            ruf.Question();


            string key = Console.ReadKey().Key.ToString();
            if (key.ToUpper() == "Y")
                Console.WriteLine("User typed 'Y'!");
            else
                Console.WriteLine("НУ И ЛАДНО");






            if (key.ToUpper() == "Y")
                raw.Matry();
            else
                Shelnax();




                static void Shelnax() 
            {
                Console.Write("НУ И ПОШЕЛ НА ХУЙ");
            }





        }
    }
}
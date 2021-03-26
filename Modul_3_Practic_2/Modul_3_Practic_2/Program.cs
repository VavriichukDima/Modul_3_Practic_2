using System;

namespace Modul_3_Practic_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------------- Delegate -------------");
            var resultDeleg = new Deleg();
            resultDeleg.Starter();
            Console.WriteLine("--------------- LINQ ---------------");
            var resultLinq = new ClassLINQ();
            resultLinq.Contacts();
        }
    }
}

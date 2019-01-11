using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AR_Watergun
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Watergun player1 = new Watergun();
            Watergun player2 = new Watergun();
            int Userinput;
            Console.WriteLine("****************************");
            Console.WriteLine("type 1 to shoot");
            Console.WriteLine("type 2 to refill manually");
            Console.WriteLine("****************************");
            Userinput = int.Parse(Console.ReadLine());
            if (Userinput == 1)
            {
                Userinput = int.Parse(Console.ReadLine());
                player1.shoot(Userinput);
            }
           else if (Userinput == 2)
            {
                Userinput = int.Parse(Console.ReadLine());
                player1.refill(Userinput);
            }
            else
            {
                Console.WriteLine("invalid answer");
                Userinput = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("****************************");
            Console.WriteLine("type 1 to shoot");
            Console.WriteLine("type 2 to refill manually");
            Console.WriteLine("****************************");
            Userinput = int.Parse(Console.ReadLine());
            if (Userinput == 1)
            {
                Userinput = int.Parse(Console.ReadLine());
                player2.shoot(Userinput);
            }
            else if (Userinput == 2)
            {
                Userinput = int.Parse(Console.ReadLine());
                player2.refill(Userinput);
            }
            else
            {
                Console.WriteLine("invalid answer");
                Userinput = int.Parse(Console.ReadLine());
            }
        }
    }
    
}


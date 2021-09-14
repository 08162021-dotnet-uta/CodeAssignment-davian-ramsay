using System;

namespace SweetnSaltyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterSnS =0;
            int sweet = 0;
            int salty = 0;

            for (int i = 1; i <= 1000; i++)
            {

               
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("sweet’nSalty ");
                    counterSnS++;
                }

                else if(i%3==0)
                    {
                    Console.Write("sweet ");
                    sweet++;
                    }
                else if(i%5==0)
                {
                    Console.Write("salty ");
                    salty++;
                }
                else { Console.Write(i + " "); }

                if (i % 10 == 0)
                { Console.WriteLine(); }
          



            }
            
            Console.WriteLine("\n\nTotal sweet’nSalty: " + counterSnS);
            Console.WriteLine("Total Sweet: "+sweet);
            Console.WriteLine("Total Salty: "+salty);
        }
    }//EOC
}//EON

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNos
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, end;
            int count = 0;
            Console.WriteLine("Enter the start number: ");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end number: ");
            end = int.Parse(Console.ReadLine());
            Console.WriteLine("\nThe prime nos. in the given range are:");

            for (int i = start; i <end; i++)
            {
                for (int j = 1; j < end; j++)
                {
                    if(i%j==0)
                    {
                        count++;
                        
                    }

                }
                if(count==2)
                    Console.WriteLine(i);

                count = 0;

            }
            Console.ReadLine();
        }
    }
}

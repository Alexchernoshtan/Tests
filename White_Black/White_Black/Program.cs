using System;
using System.Security.Cryptography.X509Certificates;

namespace White_Black
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                
                    
                Console.WriteLine("Input int x(1-8):");
                int x = Convert.ToInt16(Console.ReadLine());
                if (x < 1 || x > 8) throw new ArgumentOutOfRangeException("1<x<8");
                Console.WriteLine("Input int y(1-8):");
                int y = Convert.ToInt16(Console.ReadLine());
                if (y < 1 || y > 10) throw new ArgumentOutOfRangeException("1<y<8");

                if (x % 2 == 0)
                    if (y % 2 == 0)
                        Console.WriteLine("It's false");
                    else
                        Console.WriteLine("It's true");
                else
                if (x % 2 != 0)
                    if(y % 2 ==0)
                        Console.WriteLine("It's true");
                    else
                        Console.WriteLine("It's false");
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception " + ex.GetType().Name + " " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}

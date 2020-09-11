using System;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonachi(4));
        }
        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
    }
}

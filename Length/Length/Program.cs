using System;

namespace Length
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input x1:");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input x2:");
                double x2 = Convert.ToDouble(Console.ReadLine());
                double res = Math.Abs(x2 - x1);
                Console.WriteLine($"|x2-x1|={res}");
            }
            catch (Exception ex)

            {

                Console.WriteLine("Exception " + ex.GetType().Name + " " + ex.Message);

            }
            Console.ReadLine();

           
        }
    }
}

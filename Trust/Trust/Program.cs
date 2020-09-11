using System;

namespace Trust
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int flag = 0;
                int[] nums = new int[3];
                Console.WriteLine("Input int A:");
                int a = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Input int B: ");
                int b = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Input int C: ");
                int c = Convert.ToInt16(Console.ReadLine());


                nums[0] = a;
                nums[1] = b;
                nums[2] = c;


                foreach(int i in nums)
                    if (i < 0)
                    {
                        flag++;
                    }

                if (flag == 1)
                {
                    Console.WriteLine("\r\n"+"It's true");
                }
                else
                {
                    Console.WriteLine("\r\n"+"It's false");
                }
            }
            catch (Exception ex)

            {

                Console.WriteLine("Exception " + ex.GetType().Name + " " + ex.Message);

            }

            Console.ReadLine();

        }
    }
}

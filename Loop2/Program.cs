using System;

namespace Loop2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int temp = n;
            int num;
            int sum = 0;
            while (temp > 0)
            {
                num = temp % 10;
                temp /= 10;
                sum += num;

            }
            Console.WriteLine(sum);
        }
    }
}

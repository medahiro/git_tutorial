using System;

namespace work
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
            for (int i = 0; i < 10; i++) {
                sum += i + 1;
            }
            
            Console.WriteLine(sum);
        }
    }
}

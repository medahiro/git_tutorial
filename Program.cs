using System;

namespace work
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
            for (int i = 0; i < 100; i++) {
                sum += i + 1;
            }
            
            Console.WriteLine("Hello!");
            Console.WriteLine(sum);
            
        }
    }
}

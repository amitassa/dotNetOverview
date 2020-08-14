using System;

namespace Overview
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(1, 1, 1, 1);
            Time t2 = new Time(3, 4, 5, 6);
            Time t3 = new Time(20, 55, 59, 900);
            Time t4 = new Time(5, 10, 59, 999);
            Time t5 = new Time(1, 1, 1, 1);

            Time.SortTimes(t1, t2, t3, t4, t5);
            Console.WriteLine();

            Console.WriteLine($"t1 equals to t2: {t1.Equals(t2)}");
            Console.WriteLine($"t1 equals to t5: {t1.Equals(t5)}");
            Console.WriteLine();
            Console.WriteLine($"t1 + t2: {(t1 + t2).ShowTime()}");
            Console.WriteLine($"t1 + t2: {(t4 + t5).ShowTime()}");
            Console.WriteLine();
            Console.WriteLine($"t2 - t1: {(t2 - t1).ShowTime()}");
            Console.WriteLine($"t1 - t2: {(t1 - t2).ShowTime()}");
        }
    }
}

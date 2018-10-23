using System;
using Strategy.Format;
using Strategy.Order;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var formatStrategy = new DoubleFormatStrategy();
            var orderStrategy = new RandomOrderStrategy();

            var house = new House(formatStrategy, orderStrategy);

            house.ReciteWhole();

            Console.ReadKey();
        }
    }
}

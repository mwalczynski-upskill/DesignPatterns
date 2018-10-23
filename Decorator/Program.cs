using System;
using Decorator.Beverage;
using Decorator.Decorator;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseBeverage = new BlackCoffee();
            var withSugar = new SugarBeverageDecorator(baseBeverage);
            var withExtraEspresso = new EspressoBeverageDecorator(withSugar);

            var orderCost = withExtraEspresso.Cost();
            var orderDescription = withExtraEspresso.Description();

            Console.WriteLine($"{orderDescription}: {orderCost}$");

            Console.ReadKey();
        }
    }
}

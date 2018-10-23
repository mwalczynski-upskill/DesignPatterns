using System.Text;
using Decorator.Beverage;

namespace Decorator.Decorator
{
    public class EspressoBeverageDecorator : IBeverageDecorator
    {
        private readonly IBeverage _decoratedBeverage;

        public EspressoBeverageDecorator(IBeverage decoratedBeverage)
        {
            _decoratedBeverage = decoratedBeverage;
        }

        public int Cost()
        {
            return _decoratedBeverage.Cost() + 2;
        }

        public string Description()
        {
            return $"{_decoratedBeverage.Description()} + Espresso";
        }
    }
}

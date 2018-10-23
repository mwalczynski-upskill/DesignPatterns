using Decorator.Beverage;

namespace Decorator.Decorator
{
    public class SugarBeverageDecorator : IBeverageDecorator
    {
        private readonly IBeverage _decoratedBeverage;

        public SugarBeverageDecorator(IBeverage decoratedBeverage)
        {
            _decoratedBeverage = decoratedBeverage;
        }

        public int Cost()
        {
            return _decoratedBeverage.Cost() + 1;
        }

        public string Description()
        {
            return $"{_decoratedBeverage.Description()} + Sugar";
        }
    }
}

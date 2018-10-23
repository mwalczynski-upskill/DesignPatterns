namespace Decorator.Beverage
{
    public class BlackCoffee : IBeverage
    {
        public int Cost()
        {
            return 3;
        }

        public string Description()
        {
            return "Black Coffee";
        }
    }
}

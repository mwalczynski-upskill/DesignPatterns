namespace Decorator.Beverage
{
    public class DecafCoffee : IBeverage
    {
        public int Cost()
        {
            return 5;
        }

        public string Description()
        {
            return "Decaf Coffee";
        }
    }
}

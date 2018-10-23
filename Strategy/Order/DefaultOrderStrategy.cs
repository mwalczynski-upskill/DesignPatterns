using System.Collections.Generic;

namespace Strategy.Order
{
    public class DefaultOrderStrategy : IOrderStrategy
    {
        public IEnumerable<string> Order(IEnumerable<string> data)
        {
            return data;
        }
    }
}

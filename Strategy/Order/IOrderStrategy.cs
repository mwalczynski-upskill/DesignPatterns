using System.Collections.Generic;

namespace Strategy.Order
{
    public interface IOrderStrategy
    {
        IEnumerable<string> Order(IEnumerable<string> data);
    }
}

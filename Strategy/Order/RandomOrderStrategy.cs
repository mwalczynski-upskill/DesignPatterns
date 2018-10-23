using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy.Order
{
    public class RandomOrderStrategy : IOrderStrategy
    {
        public IEnumerable<string> Order(IEnumerable<string> data)
        {
            var random = new Random();
            var shuffledData = data.OrderBy(d => random.Next());
            return shuffledData;
        }
    }
}

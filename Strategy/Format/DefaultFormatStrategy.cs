using System.Collections.Generic;

namespace Strategy.Format
{
    public class DefaultFormatStrategy : IFormatStrategy
    {
        public IEnumerable<string> Format(IEnumerable<string> data)
        {
            return data;
        }
}
}

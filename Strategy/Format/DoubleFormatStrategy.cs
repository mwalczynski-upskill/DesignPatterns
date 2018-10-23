using System.Collections.Generic;
using System.Linq;

namespace Strategy.Format
{
    public class DoubleFormatStrategy : IFormatStrategy
    {
        public IEnumerable<string> Format(IEnumerable<string> data)
        {
            var enumerable = data as string[] ?? data.ToArray();
            var doubledData = enumerable.Zip(enumerable, (d1, d2) => $"{d1} {d2}");
            return doubledData;
        }
    }
}

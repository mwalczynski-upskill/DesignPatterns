using System.Collections.Generic;

namespace Strategy.Format
{
    public interface IFormatStrategy
    {
        IEnumerable<string> Format(IEnumerable<string> data);
    }
}

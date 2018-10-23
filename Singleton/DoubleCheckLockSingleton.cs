using System;

namespace Singleton
{
    // Double null check is used to lock only creating and not getting the instance.
    // It doesn't give huge performance benefits, but introduces some confusions in readability.
    public sealed class DoubleCheckLockSingleton
    {
        private static DoubleCheckLockSingleton _instance;
        private static readonly object Lock = new Object();

        private DoubleCheckLockSingleton()
        {
        }

        public static DoubleCheckLockSingleton GetInstance()
        {
            if (_instance is null)
            {
                lock (Lock)
                {
                    if (_instance is null)
                    {
                        _instance = new DoubleCheckLockSingleton();
                    }
                }
            }

            return _instance;
        }
    }
}

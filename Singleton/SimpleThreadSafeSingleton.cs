using System;

namespace Singleton
{
    // Simple thread safety provided.
    public sealed class SimpleThreadSafeSingleton
    {
        private static SimpleThreadSafeSingleton _instance;
        private static readonly object Lock = new Object();

        private SimpleThreadSafeSingleton()
        {
        }

        public static SimpleThreadSafeSingleton GetInstance()
        {
            lock (Lock)
            {
                if (_instance is null)
                {
                    _instance = new SimpleThreadSafeSingleton();
                }

                return _instance;
            }
        }
    }
}

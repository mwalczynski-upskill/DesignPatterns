using System;

namespace Singleton
{
    // It's simple and performs well.
    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> LazyInstance = new Lazy<LazySingleton>(() => new LazySingleton());
 
        private LazySingleton()
        {         
        }

        public static LazySingleton GetInstance() => LazyInstance.Value;
    }
}

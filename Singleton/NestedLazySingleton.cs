namespace Singleton
{
    // This implementation is fully lazy. The instance instantiation is triggered on first static member reference of the nested class, which happens only in GetInstance method.
    public sealed class NestedLazySingleton
    {
        private NestedLazySingleton()
        {
        }

        public static NestedLazySingleton GetInstance() => LazinessProvider.Instance;

        private sealed class LazinessProvider
        {
            static LazinessProvider()
            {
            }

            internal static readonly NestedLazySingleton Instance = new NestedLazySingleton();
        }
    }
}

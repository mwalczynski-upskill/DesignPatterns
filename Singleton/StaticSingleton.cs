namespace Singleton
{
    // This implementation is almost lazy, as static constructors in C# are executed only when an in instance of class is created or static member is referred.
    // Explicit static constructor tells compiler not to mark type as 'beforefieldinit'
    public sealed class StaticSingleton
    {
        public static readonly StaticSingleton Instance = new StaticSingleton();

        static StaticSingleton()
        {
        }

        private StaticSingleton()
        {
        }
    }
}

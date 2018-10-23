namespace Singleton
{
    // 'sealed' is used to prevent nested class from derive from it. 
    // It's not thread safe. Should not be used. 
    public sealed class NotThreadSafeSingleton
    {
        private static NotThreadSafeSingleton _instance;

        private NotThreadSafeSingleton()
        {
        }

        public static NotThreadSafeSingleton GetInstance()
        {
            if (_instance is null)
            {
                _instance = new NotThreadSafeSingleton();
            }

            return _instance;
        }
    }
}

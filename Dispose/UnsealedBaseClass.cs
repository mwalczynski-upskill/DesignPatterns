namespace Dispose
{
    using System;

    public class UnsealedBaseClass : IDisposable
    {
        // Flag: Has Dispose already been called?
        private bool _disposed = false;

        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                // get rid of managed resources:
                // * objects that implement IDisposable, eg. SafeHandles,
                // * objects that consume large amounts of memory or consume scarce resources
            }

            // get rid of unmanaged resources
            _disposed = true;
        }

        ~UnsealedBaseClass()
        {
            Dispose(false);
        }
    }
}
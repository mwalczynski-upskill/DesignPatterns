namespace Dispose
{
    using System;
    using System.Runtime.InteropServices;
    using Microsoft.Win32.SafeHandles;

    public class UnsealedDerivedClass : UnsealedBaseClass
    {
        private readonly IntPtr _memoryHandle;
        private readonly SafeHandle _safeHandle;

        // Flag: Has Dispose already been called?
        private bool _disposed = false;

        public UnsealedDerivedClass()
        {
            _memoryHandle = Marshal.AllocCoTaskMem(1);
            _safeHandle = new SafeFileHandle(IntPtr.Zero, true);
        }

        protected override void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                _safeHandle.Dispose();
                // Free any other managed objects here
            }

            Marshal.FreeCoTaskMem(_memoryHandle);
            // Free any other unmanaged objects here
            _disposed = true;
            // Call base class implementation.
            base.Dispose(disposing);
        }

        ~UnsealedDerivedClass()
        {
            // false prevents the finalizer from trying to release managed resources that may have already been reclaimed.
            Dispose(false);
        }
    }
}

namespace Dispose
{
    using System;
    using System.Runtime.InteropServices;

    public sealed class SealedClass : IDisposable
    {
        private readonly IntPtr _memoryHandle;

        public SealedClass()
        {
            _memoryHandle = Marshal.AllocCoTaskMem(1);
        }

        public void Dispose()
        {
            Marshal.FreeCoTaskMem(_memoryHandle);
        }
    }
}

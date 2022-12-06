using System;
using System.Runtime.InteropServices;

namespace Avalonia.Win32.Interop.Automation
{
    [ComVisible(true)]
    [Guid("2360c714-4bf1-4b26-ba65-9b21316127eb")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IScrollItemProvider
    {
        public readonly static Guid IID_IScrollItemProvider = new("2360c714-4bf1-4b26-ba65-9b21316127eb");
        void ScrollIntoView();
    }
}

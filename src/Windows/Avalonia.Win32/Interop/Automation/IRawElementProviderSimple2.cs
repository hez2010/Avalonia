using System;
using System.Runtime.InteropServices;

#nullable enable

namespace Avalonia.Win32.Interop.Automation
{
    [ComVisible(true)]
    [Guid("a0a839a9-8da1-4a82-806a-8e0d44e79f56")]
    public interface IRawElementProviderSimple2
    {
        public readonly static Guid IID_IRawElementProviderSimple2 = new("a0a839a9-8da1-4a82-806a-8e0d44e79f56");
        void ShowContextMenu();
    }
}

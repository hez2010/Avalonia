using System;
using System.Runtime.InteropServices;

namespace Avalonia.Win32.Interop.Automation
{
    [ComVisible(true)]
    [Guid("620ce2a5-ab8f-40a9-86cb-de3c75599b58")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IRawElementProviderFragmentRoot : IRawElementProviderFragment
    {
        public readonly static Guid IID_IRawElementProviderFragmentRoot = new("620ce2a5-ab8f-40a9-86cb-de3c75599b58");
        IRawElementProviderFragment ElementProviderFromPoint(double x, double y);
        IRawElementProviderFragment GetFocus();
    }
}

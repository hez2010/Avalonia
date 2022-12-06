using System;
using System.Runtime.InteropServices;
using Avalonia.Automation;

namespace Avalonia.Win32.Interop.Automation
{
    [ComVisible(true)]
    [Guid("d847d3a5-cab0-4a98-8c32-ecb45c59ad24")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IExpandCollapseProvider
    {
        public readonly static Guid IID_IExpandCollapseProvider = new("d847d3a5-cab0-4a98-8c32-ecb45c59ad24");
        void Expand();
        void Collapse();
        ExpandCollapseState ExpandCollapseState { get; }
    }
}

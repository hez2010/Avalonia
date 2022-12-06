using System;
using System.Runtime.InteropServices;

namespace Avalonia.Win32.Interop.Automation
{
    [ComVisible(true)]
    [Guid("d02541f1-fb81-4d64-ae32-f520f8a6dbd1")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IGridItemProvider
    {
        public readonly static Guid IID_IGridItemProvider = new("d02541f1-fb81-4d64-ae32-f520f8a6dbd1");
        int Row { get; }
        int Column { get; }
        int RowSpan { get; }
        int ColumnSpan { get; }
        IRawElementProviderSimple ContainingGrid { get; }
    }
}

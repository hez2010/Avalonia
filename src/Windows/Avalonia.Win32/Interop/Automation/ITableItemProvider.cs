using System;
using System.Runtime.InteropServices;

namespace Avalonia.Win32.Interop.Automation
{
    [ComVisible(true)]
    [Guid("b9734fa6-771f-4d78-9c90-2517999349cd")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ITableItemProvider : IGridItemProvider
    {
        public readonly static Guid IID_ITableItemProvider = new("b9734fa6-771f-4d78-9c90-2517999349cd");
        IRawElementProviderSimple [] GetRowHeaderItems();
        IRawElementProviderSimple [] GetColumnHeaderItems();
    }
}

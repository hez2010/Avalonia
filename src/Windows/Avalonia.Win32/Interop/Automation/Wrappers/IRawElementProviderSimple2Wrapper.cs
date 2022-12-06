using System;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.ComWrappers;
using static Avalonia.Win32.Interop.UnmanagedMethods;

#nullable enable

namespace Avalonia.Win32.Interop.Automation.Wrappers
{
    internal unsafe class IRawElementProviderSimple2Wrapper
    {
        [UnmanagedCallersOnly]
        public static int ShowContextMenu(IntPtr @this)
        {
            try
            {
                ComInterfaceDispatch.GetInstance<IRawElementProviderSimple2>((ComInterfaceDispatch*)@this).ShowContextMenu();
            }
            catch (Exception ex)
            {
                return ex.HResult;
            }
            return (int)HRESULT.S_OK;
        }
    }
}

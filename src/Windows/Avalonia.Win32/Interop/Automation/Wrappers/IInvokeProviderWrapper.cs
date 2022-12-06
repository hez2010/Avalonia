using System;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.ComWrappers;
using static Avalonia.Win32.Interop.UnmanagedMethods;

#nullable enable

namespace Avalonia.Win32.Interop.Automation.Wrappers
{
    internal sealed unsafe class IInvokeProviderWrapper
    {
        [UnmanagedCallersOnly]
        public static int Invoke(IntPtr @this)
        {
            try
            {
                ComInterfaceDispatch.GetInstance<IInvokeProvider>((ComInterfaceDispatch*)@this).Invoke();
            }
            catch (Exception ex)
            {
                return ex.HResult;
            }
            return (int)HRESULT.S_OK;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Avalonia.Win32.Interop.UnmanagedMethods;
using static System.Runtime.InteropServices.ComWrappers;

namespace Avalonia.Win32.Interop.Automation.Wrappers
{
    internal unsafe class IRawElementProviderFragmentRootWrapper : IRawElementProviderFragmentWrapper
    {
        [UnmanagedCallersOnly]
        public static int ElementProviderFromPoint(IntPtr @this, double x, double y, IntPtr* retValue)
        {
            try
            {
                var result = ComInterfaceDispatch.GetInstance<IRawElementProviderFragmentRoot>((ComInterfaceDispatch*)@this).ElementProviderFromPoint(x, y);
                // TODO: Marshal result into retValue
            }
            catch (Exception ex)
            {
                return ex.HResult;
            }
            return (int)HRESULT.S_OK;
        }

        [UnmanagedCallersOnly]
        public static int GetFocus(IntPtr @this, IntPtr* retValue)
        {
            try
            {
                var result = ComInterfaceDispatch.GetInstance<IRawElementProviderFragmentRoot>((ComInterfaceDispatch*)@this).GetFocus();
                // TODO: Marshal result into retValue
            }
            catch (Exception ex)
            {
                return ex.HResult;
            }
            return (int)HRESULT.S_OK;
        }
    }
}

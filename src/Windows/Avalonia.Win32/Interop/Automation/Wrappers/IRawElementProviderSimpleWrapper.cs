using System;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.ComWrappers;
using static Avalonia.Win32.Interop.UnmanagedMethods;

#nullable enable

namespace Avalonia.Win32.Interop.Automation.Wrappers
{
    internal unsafe class IRawElementProviderSimpleWrapper
    {
        [UnmanagedCallersOnly]
        public static int GetProviderOptions(IntPtr @this, IntPtr* retValue)
        {
            try
            {
                var result = ComInterfaceDispatch.GetInstance<IRawElementProviderSimple>((ComInterfaceDispatch*)@this).ProviderOptions;
                *(ProviderOptions*)retValue = result;
            }
            catch (Exception ex)
            {
                return ex.HResult;
            }
            return (int)HRESULT.S_OK;
        }

        [UnmanagedCallersOnly]
        public static int GetPatternProvider(IntPtr @this, int patternId, IntPtr* retValue)
        {
            try
            {
                var result = ComInterfaceDispatch.GetInstance<IRawElementProviderSimple>((ComInterfaceDispatch*)@this).GetPatternProvider(patternId);
                // TODO: Marshal result into retValue
            }
            catch (Exception ex)
            {
                return ex.HResult;
            }
            return (int)HRESULT.S_OK;
        }

        [UnmanagedCallersOnly]
        public static int GetPropertyValue(IntPtr @this, int propertyId, IntPtr* retValue)
        {
            try
            {
                var result = ComInterfaceDispatch.GetInstance<IRawElementProviderSimple>((ComInterfaceDispatch*)@this).GetPropertyValue(propertyId);
                // TODO: Marshal result into retValue
            }
            catch (Exception ex)
            {
                return ex.HResult;
            }
            return (int)HRESULT.S_OK;
        }

        [UnmanagedCallersOnly]
        public static int GetHostRawElementProvider(IntPtr @this, IntPtr* retVaue)
        {
            try
            {
                var result = ComInterfaceDispatch.GetInstance<IRawElementProviderSimple>((ComInterfaceDispatch*)@this).HostRawElementProvider;
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

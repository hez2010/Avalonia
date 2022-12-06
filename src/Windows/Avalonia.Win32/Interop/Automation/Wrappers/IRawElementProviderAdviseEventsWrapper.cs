using System;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.ComWrappers;
using static Avalonia.Win32.Interop.UnmanagedMethods;

#nullable enable

namespace Avalonia.Win32.Interop.Automation.Wrappers
{
    internal unsafe class IRawElementProviderAdviseEventsWrapper : IRawElementProviderSimpleWrapper
    {
        private static int[] GetSafeArray(int* pArray)
        {
            int lBound, uBound, hr;
            if ((hr = SafeArrayGetLBound(pArray, 1, &lBound)) < 0)
            {
                Marshal.ThrowExceptionForHR(hr);
            }
            if ((hr = SafeArrayGetUBound(pArray, 1, &uBound)) < 0)
            {
                Marshal.ThrowExceptionForHR(hr);
            }
            var array = new int[uBound - lBound + 1];
            var index = 0;
            for (var i = lBound; i <= uBound; i++)
            {
                int value;
                if ((hr = SafeArrayGetElement(pArray, &i, &value)) < 0)
                {
                    Marshal.ThrowExceptionForHR(hr);
                }
                array[index++] = value;
            }

            return array;
        }

        [UnmanagedCallersOnly]
        public static int AdviseEventAdded(IntPtr @this, int eventId, int* properties)
        {
            try
            {
                ComInterfaceDispatch.GetInstance<IRawElementProviderAdviseEvents>((ComInterfaceDispatch*)@this).AdviseEventAdded(eventId, GetSafeArray(properties));
            }
            catch (Exception ex)
            {
                return ex.HResult;
            }
            return (int)HRESULT.S_OK;
        }

        [UnmanagedCallersOnly]
        public static int AdviseEventRemoved(IntPtr @this, int eventId, int* properties)
        {
            try
            {
                ComInterfaceDispatch.GetInstance<IRawElementProviderAdviseEvents>((ComInterfaceDispatch*)@this).AdviseEventRemoved(eventId, GetSafeArray(properties));
            }
            catch (Exception ex)
            {
                return ex.HResult;
            }
            return (int)HRESULT.S_OK;
        }
    }
}

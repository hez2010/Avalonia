using System;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.ComWrappers;
using static Avalonia.Win32.Interop.UnmanagedMethods;

#nullable enable

namespace Avalonia.Win32.Interop.Automation.Wrappers
{
    internal unsafe class IRawElementProviderFragmentWrapper : IRawElementProviderSimpleWrapper
    {
        [UnmanagedCallersOnly]
        public static int Navigate(IntPtr @this, int direction, IntPtr* retValue)
        {
            try
            {
                var result = ComInterfaceDispatch.GetInstance<IRawElementProviderFragment>((ComInterfaceDispatch*)@this).Navigate((NavigateDirection)direction);
                // TODO: Marshal result into retValue
            }
            catch (Exception ex)
            {
                return ex.HResult;
            }
            return (int)HRESULT.S_OK;
        }

        [UnmanagedCallersOnly]
        public static int GetRuntimeId(IntPtr @this, IntPtr* retValue)
        {
            try
            {
                var result = ComInterfaceDispatch.GetInstance<IRawElementProviderFragment>((ComInterfaceDispatch*)@this).GetRuntimeId();
                if (result is not null)
                {
                    *retValue = Marshal.AllocCoTaskMem(sizeof(int) * result.Length);
                    for (var i = 0; i < result.Length; i++)
                    {
                        *(int*)*retValue = result[i];
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.HResult;
            }
            return (int)HRESULT.S_OK;
        }

        [UnmanagedCallersOnly]
        public static int GetBoundingRectangle(IntPtr @this, IntPtr retValue)
        {
            try
            {
                var result = ComInterfaceDispatch.GetInstance<IRawElementProviderFragment>((ComInterfaceDispatch*)@this).BoundingRectangle;
                Marshal.StructureToPtr(result, retValue, false);
            }
            catch (Exception ex)
            {
                return ex.HResult;
            }
            return (int)HRESULT.S_OK;
        }

        [UnmanagedCallersOnly]
        public static int GetEmbeddedFragmentRoots(IntPtr @this, IntPtr* retValue)
        {
            try
            {
                var result = ComInterfaceDispatch.GetInstance<IRawElementProviderFragment>((ComInterfaceDispatch*)@this).GetEmbeddedFragmentRoots();
                // TODO: Marshal result into retValue
            }
            catch (Exception ex)
            {
                return ex.HResult;
            }
            return (int)HRESULT.S_OK;
        }

        [UnmanagedCallersOnly]
        public static int SetFocus(IntPtr @this)
        {
            try
            {
                ComInterfaceDispatch.GetInstance<IRawElementProviderFragment>((ComInterfaceDispatch*)@this).SetFocus();
            }
            catch (Exception ex)
            {
                return ex.HResult;
            }
            return (int)HRESULT.S_OK;
        }

        [UnmanagedCallersOnly]
        public static int GetFragmentRoot(IntPtr @this, IntPtr* retValue)
        {
            try
            {
                var result = ComInterfaceDispatch.GetInstance<IRawElementProviderFragment>((ComInterfaceDispatch*)@this).FragmentRoot;
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

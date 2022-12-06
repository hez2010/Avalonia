using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Avalonia.Win32.Interop.Automation;
using Avalonia.Win32.Interop.Automation.Wrappers;

#nullable enable

namespace Avalonia.Win32.Automation.Wrappers
{
    internal unsafe class RootAutomationNodeComWrappers : AutomationNodeComWrappers
    {
        protected static readonly IntPtr s_IRawElementProviderFragmentRootVtable;
        protected static readonly ComInterfaceEntry* s_RootAutomationNodeEntries;
        protected static readonly int s_RootAutomationNodeEntriesLength;

        static RootAutomationNodeComWrappers()
        {
            GetIUnknownImpl(out IntPtr fpQueryInterface, out IntPtr fpAddRef, out IntPtr fpRelease);

            {
                var index = 0;
                var vtable = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(
                    typeof(AutomationNodeComWrappers),
                    IntPtr.Size * (3 + 4 + 6 + 2));
                vtable[index++] = fpQueryInterface;
                vtable[index++] = fpAddRef;
                vtable[index++] = fpRelease;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&IRawElementProviderFragmentRootWrapper.GetProviderOptions;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, int, IntPtr*, int>)&IRawElementProviderFragmentRootWrapper.GetPatternProvider;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, int, IntPtr*, int>)&IRawElementProviderFragmentRootWrapper.GetPropertyValue;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&IRawElementProviderFragmentRootWrapper.GetHostRawElementProvider;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, int, IntPtr*, int>)&IRawElementProviderFragmentRootWrapper.Navigate;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&IRawElementProviderFragmentRootWrapper.GetRuntimeId;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr, int>)&IRawElementProviderFragmentRootWrapper.GetBoundingRectangle;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&IRawElementProviderFragmentRootWrapper.GetEmbeddedFragmentRoots;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, int>)&IRawElementProviderFragmentRootWrapper.SetFocus;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&IRawElementProviderFragmentRootWrapper.GetFragmentRoot;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, double, double, IntPtr*, int>)&IRawElementProviderFragmentRootWrapper.ElementProviderFromPoint;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&IRawElementProviderFragmentRootWrapper.GetFocus;
                s_IRawElementProviderFragmentRootVtable = (IntPtr)vtable;
            }

            {
                int index = 0;
                s_RootAutomationNodeEntriesLength = 6;
                var entries = (ComInterfaceEntry*)RuntimeHelpers.AllocateTypeAssociatedMemory(
                    typeof(AutomationNodeComWrappers),
                    sizeof(ComInterfaceEntry) * s_RootAutomationNodeEntriesLength);
                entries[index].IID = IRawElementProviderSimple.IID_IRawElementProviderSimple;
                entries[index++].Vtable = s_IRawElementProviderSimpleVtable;
                entries[index].IID = IRawElementProviderSimple2.IID_IRawElementProviderSimple2;
                entries[index++].Vtable = s_IRawElementProviderSimple2Vtable;
                entries[index].IID = IRawElementProviderFragment.IID_IRawElementProviderFragment;
                entries[index++].Vtable = s_IRawElementProviderFragmentVtable;
                entries[index].IID = IRawElementProviderAdviseEvents.IID_IRawElementProviderAdviseEvents;
                entries[index++].Vtable = s_IRawElementProviderAdviseEventsVtable;
                entries[index].IID = IInvokeProvider.IID_IInvokeProvider;
                entries[index++].Vtable = s_IInvokeProviderVtable;
                entries[index].IID = IRawElementProviderFragmentRoot.IID_IRawElementProviderFragmentRoot;
                entries[index++].Vtable = s_IRawElementProviderFragmentRootVtable;
                s_RootAutomationNodeEntries = entries;
            }
        }
    }

    internal unsafe class AutomationNodeComWrappers : ComWrappers
    {
        protected static readonly IntPtr s_IRawElementProviderSimpleVtable;
        protected static readonly IntPtr s_IRawElementProviderSimple2Vtable;
        protected static readonly IntPtr s_IRawElementProviderFragmentVtable;
        protected static readonly IntPtr s_IRawElementProviderAdviseEventsVtable;
        protected static readonly IntPtr s_IInvokeProviderVtable;
        protected static readonly ComInterfaceEntry* s_AutomationNodeEntries;
        protected static readonly int s_AutomationNodeEntriesLength;

        static AutomationNodeComWrappers()
        {
            GetIUnknownImpl(out IntPtr fpQueryInterface, out IntPtr fpAddRef, out IntPtr fpRelease);

            {
                var index = 0;
                var vtable = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(
                    typeof(AutomationNodeComWrappers),
                    IntPtr.Size * (3 + 4));
                vtable[index++] = fpQueryInterface;
                vtable[index++] = fpAddRef;
                vtable[index++] = fpRelease;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&IRawElementProviderSimpleWrapper.GetProviderOptions;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, int, IntPtr*, int>)&IRawElementProviderSimpleWrapper.GetPatternProvider;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, int, IntPtr*, int>)&IRawElementProviderSimpleWrapper.GetPropertyValue;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&IRawElementProviderSimpleWrapper.GetHostRawElementProvider;
                s_IRawElementProviderSimpleVtable = (IntPtr)vtable;
            }

            {
                var index = 0;
                var vtable = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(
                    typeof(AutomationNodeComWrappers),
                    IntPtr.Size * (3 + 1));
                vtable[index++] = fpQueryInterface;
                vtable[index++] = fpAddRef;
                vtable[index++] = fpRelease;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, int>)&IRawElementProviderSimple2Wrapper.ShowContextMenu;
                s_IRawElementProviderSimple2Vtable = (IntPtr)vtable;
            }

            {
                var index = 0;
                var vtable = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(
                    typeof(AutomationNodeComWrappers),
                    IntPtr.Size * (3 + 4 + 6));
                vtable[index++] = fpQueryInterface;
                vtable[index++] = fpAddRef;
                vtable[index++] = fpRelease;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&IRawElementProviderFragmentWrapper.GetProviderOptions;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, int, IntPtr*, int>)&IRawElementProviderFragmentWrapper.GetPatternProvider;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, int, IntPtr*, int>)&IRawElementProviderFragmentWrapper.GetPropertyValue;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&IRawElementProviderFragmentWrapper.GetHostRawElementProvider;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, int, IntPtr*, int>)&IRawElementProviderFragmentWrapper.Navigate;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&IRawElementProviderFragmentWrapper.GetRuntimeId;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr, int>)&IRawElementProviderFragmentWrapper.GetBoundingRectangle;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&IRawElementProviderFragmentWrapper.GetEmbeddedFragmentRoots;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, int>)&IRawElementProviderFragmentWrapper.SetFocus;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&IRawElementProviderFragmentWrapper.GetFragmentRoot;
                s_IRawElementProviderFragmentVtable = (IntPtr)vtable;
            }

            {
                var index = 0;
                var vtable = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(
                    typeof(AutomationNodeComWrappers),
                    IntPtr.Size * (3 + 4 + 2));

                vtable[index++] = fpQueryInterface;
                vtable[index++] = fpAddRef;
                vtable[index++] = fpRelease;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&IRawElementProviderAdviseEventsWrapper.GetProviderOptions;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, int, IntPtr*, int>)&IRawElementProviderAdviseEventsWrapper.GetPatternProvider;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, int, IntPtr*, int>)&IRawElementProviderAdviseEventsWrapper.GetPropertyValue;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, IntPtr*, int>)&IRawElementProviderAdviseEventsWrapper.GetHostRawElementProvider;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, int, int*, int>)&IRawElementProviderAdviseEventsWrapper.AdviseEventAdded;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, int, int*, int>)&IRawElementProviderAdviseEventsWrapper.AdviseEventRemoved;
                s_IRawElementProviderAdviseEventsVtable = (IntPtr)vtable;
            }

            {
                var index = 0;
                var vtable = (IntPtr*)RuntimeHelpers.AllocateTypeAssociatedMemory(
                    typeof(AutomationNodeComWrappers),
                    IntPtr.Size * (3 + 1));
                vtable[index++] = fpQueryInterface;
                vtable[index++] = fpAddRef;
                vtable[index++] = fpRelease;
                vtable[index++] = (IntPtr)(delegate* unmanaged<IntPtr, int>)&IInvokeProviderWrapper.Invoke;
                s_IInvokeProviderVtable = (IntPtr)vtable;
            }

            {
                int index = 0;
                s_AutomationNodeEntriesLength = 5;
                var entries = (ComInterfaceEntry*)RuntimeHelpers.AllocateTypeAssociatedMemory(
                    typeof(AutomationNodeComWrappers),
                    sizeof(ComInterfaceEntry) * s_AutomationNodeEntriesLength);
                entries[index].IID = IRawElementProviderSimple.IID_IRawElementProviderSimple;
                entries[index++].Vtable = s_IRawElementProviderSimpleVtable;
                entries[index].IID = IRawElementProviderSimple2.IID_IRawElementProviderSimple2;
                entries[index++].Vtable = s_IRawElementProviderSimple2Vtable;
                entries[index].IID = IRawElementProviderFragment.IID_IRawElementProviderFragment;
                entries[index++].Vtable = s_IRawElementProviderFragmentVtable;
                entries[index].IID = IRawElementProviderAdviseEvents.IID_IRawElementProviderAdviseEvents;
                entries[index++].Vtable = s_IRawElementProviderAdviseEventsVtable;
                entries[index].IID = IInvokeProvider.IID_IInvokeProvider;
                entries[index++].Vtable = s_IInvokeProviderVtable;
                s_AutomationNodeEntries = entries;
            }
        }

        protected override unsafe ComInterfaceEntry* ComputeVtables(object obj, CreateComInterfaceFlags flags, out int count)
        {
            if (obj is AutomationNode)
            {
                count = s_AutomationNodeEntriesLength;
                return s_AutomationNodeEntries;
            }

            count = 0;
            return null;
        }

        protected override object? CreateObject(IntPtr externalComObject, CreateObjectFlags flags)
        {
            throw new NotImplementedException();
        }

        protected override void ReleaseObjects(IEnumerable objects)
        {
            throw new NotImplementedException();
        }
    }
}

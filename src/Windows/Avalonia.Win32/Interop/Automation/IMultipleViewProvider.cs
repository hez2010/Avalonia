using System;
using System.Runtime.InteropServices;

namespace Avalonia.Win32.Interop.Automation
{
    [ComVisible(true)]
    [Guid("6278cab1-b556-4a1a-b4e0-418acc523201")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMultipleViewProvider
    {
        public readonly static Guid IID_IMultipleViewProvider = new("6278cab1-b556-4a1a-b4e0-418acc523201");
        string GetViewName(int viewId);
        void SetCurrentView(int viewId);
        int CurrentView { get; }
        int[] GetSupportedViews();
    }
}

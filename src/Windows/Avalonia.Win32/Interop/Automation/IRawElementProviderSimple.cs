﻿using System;
using System.Runtime.InteropServices;

#nullable enable

namespace Avalonia.Win32.Interop.Automation
{
    [Flags]
    public enum ProviderOptions
    {
        ClientSideProvider = 0x0001,
        ServerSideProvider = 0x0002,
        NonClientAreaProvider = 0x0004,
        OverrideProvider = 0x0008,
        ProviderOwnsSetFocus = 0x0010,
        UseComThreading = 0x0020
    }

    internal enum UiaPropertyId
    {
        RuntimeId = 30000,
        BoundingRectangle,
        ProcessId,
        ControlType,
        LocalizedControlType,
        Name,
        AcceleratorKey,
        AccessKey,
        HasKeyboardFocus,
        IsKeyboardFocusable,
        IsEnabled,
        AutomationId,
        ClassName,
        HelpText,
        ClickablePoint,
        Culture,
        IsControlElement,
        IsContentElement,
        LabeledBy,
        IsPassword,
        NativeWindowHandle,
        ItemType,
        IsOffscreen,
        Orientation,
        FrameworkId,
        IsRequiredForForm,
        ItemStatus,
        IsDockPatternAvailable,
        IsExpandCollapsePatternAvailable,
        IsGridItemPatternAvailable,
        IsGridPatternAvailable,
        IsInvokePatternAvailable,
        IsMultipleViewPatternAvailable,
        IsRangeValuePatternAvailable,
        IsScrollPatternAvailable,
        IsScrollItemPatternAvailable,
        IsSelectionItemPatternAvailable,
        IsSelectionPatternAvailable,
        IsTablePatternAvailable,
        IsTableItemPatternAvailable,
        IsTextPatternAvailable,
        IsTogglePatternAvailable,
        IsTransformPatternAvailable,
        IsValuePatternAvailable,
        IsWindowPatternAvailable,
        ValueValue,
        ValueIsReadOnly,
        RangeValueValue,
        RangeValueIsReadOnly,
        RangeValueMinimum,
        RangeValueMaximum,
        RangeValueLargeChange,
        RangeValueSmallChange,
        ScrollHorizontalScrollPercent,
        ScrollHorizontalViewSize,
        ScrollVerticalScrollPercent,
        ScrollVerticalViewSize,
        ScrollHorizontallyScrollable,
        ScrollVerticallyScrollable,
        SelectionSelection,
        SelectionCanSelectMultiple,
        SelectionIsSelectionRequired,
        GridRowCount,
        GridColumnCount,
        GridItemRow,
        GridItemColumn,
        GridItemRowSpan,
        GridItemColumnSpan,
        GridItemContainingGrid,
        DockDockPosition,
        ExpandCollapseExpandCollapseState,
        MultipleViewCurrentView,
        MultipleViewSupportedViews,
        WindowCanMaximize,
        WindowCanMinimize,
        WindowWindowVisualState,
        WindowWindowInteractionState,
        WindowIsModal,
        WindowIsTopmost,
        SelectionItemIsSelected,
        SelectionItemSelectionContainer,
        TableRowHeaders,
        TableColumnHeaders,
        TableRowOrColumnMajor,
        TableItemRowHeaderItems,
        TableItemColumnHeaderItems,
        ToggleToggleState,
        TransformCanMove,
        TransformCanResize,
        TransformCanRotate,
        IsLegacyIAccessiblePatternAvailable,
        LegacyIAccessibleChildId,
        LegacyIAccessibleName,
        LegacyIAccessibleValue,
        LegacyIAccessibleDescription,
        LegacyIAccessibleRole,
        LegacyIAccessibleState,
        LegacyIAccessibleHelp,
        LegacyIAccessibleKeyboardShortcut,
        LegacyIAccessibleSelection,
        LegacyIAccessibleDefaultAction,
        AriaRole,
        AriaProperties,
        IsDataValidForForm,
        ControllerFor,
        DescribedBy,
        FlowsTo,
        ProviderDescription,
        IsItemContainerPatternAvailable,
        IsVirtualizedItemPatternAvailable,
        IsSynchronizedInputPatternAvailable,
        OptimizeForVisualContent,
        IsObjectModelPatternAvailable,
        AnnotationAnnotationTypeId,
        AnnotationAnnotationTypeName,
        AnnotationAuthor,
        AnnotationDateTime,
        AnnotationTarget,
        IsAnnotationPatternAvailable,
        IsTextPattern2Available,
        StylesStyleId,
        StylesStyleName,
        StylesFillColor,
        StylesFillPatternStyle,
        StylesShape,
        StylesFillPatternColor,
        StylesExtendedProperties,
        IsStylesPatternAvailable,
        IsSpreadsheetPatternAvailable,
        SpreadsheetItemFormula,
        SpreadsheetItemAnnotationObjects,
        SpreadsheetItemAnnotationTypes,
        IsSpreadsheetItemPatternAvailable,
        Transform2CanZoom,
        IsTransformPattern2Available,
        LiveSetting,
        IsTextChildPatternAvailable,
        IsDragPatternAvailable,
        DragIsGrabbed,
        DragDropEffect,
        DragDropEffects,
        IsDropTargetPatternAvailable,
        DropTargetDropTargetEffect,
        DropTargetDropTargetEffects,
        DragGrabbedItems,
        Transform2ZoomLevel,
        Transform2ZoomMinimum,
        Transform2ZoomMaximum,
        FlowsFrom,
        IsTextEditPatternAvailable,
        IsPeripheral,
        IsCustomNavigationPatternAvailable,
        PositionInSet,
        SizeOfSet,
        Level,
        AnnotationTypes,
        AnnotationObjects,
        LandmarkType,
        LocalizedLandmarkType,
        FullDescription,
        FillColor,
        OutlineColor,
        FillType,
        VisualEffects,
        OutlineThickness,
        CenterPoint,
        Rotatation,
        Size
    }

    internal enum UiaPatternId
    {
        Invoke = 10000,
        Selection,
        Value,
        RangeValue,
        Scroll,
        ExpandCollapse,
        Grid,
        GridItem,
        MultipleView,
        Window,
        SelectionItem,
        Dock,
        Table,
        TableItem,
        Text,
        Toggle,
        Transform,
        ScrollItem,
        LegacyIAccessible,
        ItemContainer,
        VirtualizedItem,
        SynchronizedInput,
        ObjectModel,
        Annotation,
        Text2,
        Styles,
        Spreadsheet,
        SpreadsheetItem,
        Transform2,
        TextChild,
        Drag,
        DropTarget,
        TextEdit,
        CustomNavigation
    };

    internal enum UiaControlTypeId
    {
        Button = 50000,
        Calendar,
        CheckBox,
        ComboBox,
        Edit,
        Hyperlink,
        Image,
        ListItem,
        List,
        Menu,
        MenuBar,
        MenuItem,
        ProgressBar,
        RadioButton,
        ScrollBar,
        Slider,
        Spinner,
        StatusBar,
        Tab,
        TabItem,
        Text,
        ToolBar,
        ToolTip,
        Tree,
        TreeItem,
        Custom,
        Group,
        Thumb,
        DataGrid,
        DataItem,
        Document,
        SplitButton,
        Window,
        Pane,
        Header,
        HeaderItem,
        Table,
        TitleBar,
        Separator,
        SemanticZoom,
        AppBar
    };

    [ComVisible(true)]
    [Guid("d6dd68d1-86fd-4332-8666-9abedea2d24c")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IRawElementProviderSimple
    {
        public readonly static Guid IID_IRawElementProviderSimple = new("d6dd68d1-86fd-4332-8666-9abedea2d24c");
        ProviderOptions ProviderOptions { get; }
        [return: MarshalAs(UnmanagedType.IUnknown)]
        object? GetPatternProvider(int patternId);
        object? GetPropertyValue(int propertyId);
        IRawElementProviderSimple? HostRawElementProvider { get; }
    }
}

﻿// -----------------------------------------------------------------------
// <copyright file="InputManager.cs" company="Steven Kirk">
// Copyright 2013 MIT Licence. See licence.md for more information.
// </copyright>
// -----------------------------------------------------------------------

namespace Perspex.Input
{
    using System.Collections.Generic;
    using System.Linq;
    using Perspex.Controls;
    using Perspex.Input.Raw;

    public class InputManager : IInputManager
    {
        List<Control> pointerOvers = new List<Control>();

        public void Process(RawInputEventArgs e)
        {
            RawMouseEventArgs mouse = e as RawMouseEventArgs;

            if (mouse != null)
            {
                this.ProcessMouse(mouse);
            }
        }

        private void ProcessMouse(RawMouseEventArgs e)
        {
            switch (e.Type)
            {
                case RawMouseEventType.Move:
                    this.MouseMove((IVisual)e.Root, e.Position);
                    break;
                case RawMouseEventType.LeftButtonDown:
                    this.MouseDown((IMouseDevice)e.Device, (IVisual)e.Root, e.Position);
                    break;
                case RawMouseEventType.LeftButtonUp:
                    this.MouseUp((IMouseDevice)e.Device, (IVisual)e.Root, e.Position);
                    break;
            }
        }

        private void MouseMove(IVisual visual, Point p)
        {
            IEnumerable<IVisual> hits = visual.GetVisualsAt(p);

            foreach (var control in this.pointerOvers.ToList().Except(hits).Cast<Control>())
            {
                this.pointerOvers.Remove(control);
                control.IsPointerOver = false;
            }

            foreach (var control in hits.Except(this.pointerOvers).Cast<Control>())
            {
                this.pointerOvers.Add(control);
                control.IsPointerOver = true;
            }
        }

        private void MouseDown(IMouseDevice device, IVisual visual, Point p)
        {
            IVisual hit = visual.GetVisualAt(p);

            if (hit != null)
            {
                Interactive source = (hit as Interactive) ?? hit.GetVisualAncestor<Interactive>();

                if (source != null)
                {
                    source.RaiseEvent(new PointerEventArgs
                    {
                        Device = device,
                        RoutedEvent = Control.PointerPressedEvent,
                        OriginalSource = source,
                        Source = source,
                    });
                }
            }
        }

        private void MouseUp(IMouseDevice device, IVisual visual, Point p)
        {
            IVisual hit = visual.GetVisualAt(p);

            if (hit != null)
            {
                Interactive source = (hit as Interactive) ?? hit.GetVisualAncestor<Interactive>();

                if (source != null)
                {
                    source.RaiseEvent(new PointerEventArgs
                    {
                        Device = device,
                        RoutedEvent = Control.PointerReleasedEvent,
                        OriginalSource = source,
                        Source = source,
                    });
                }
            }
        }
    }
}

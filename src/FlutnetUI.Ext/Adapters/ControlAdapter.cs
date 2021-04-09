using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.VisualTree;
using FlutnetUI.Ext.Controls;
using FlutnetUI.Ext.Utilities;
using TheArtOfDev.HtmlRenderer.Adapters;
using TheArtOfDev.HtmlRenderer.Adapters.Entities;
using TheArtOfDev.HtmlRenderer.Core.Utils;

namespace FlutnetUI.Ext.Adapters
{
    /// <summary>
    /// Adapter for Avalonia controls.
    /// </summary>
    internal sealed class ControlAdapter : RControl
    {
        public ControlAdapter(Control control) : base(AvaloniaAdapter.Instance)
        {
            ArgChecker.AssertArgNotNull(control, "control");
            Control = control;
        }

        /// <summary>
        /// The underlying Avalonia control
        /// </summary>
        public Control Control { get; }

        public override RPoint MouseLocation
        {
            get
            {
                IInputRoot inputRoot = Control.GetVisualRoot() as IInputRoot;
                PixelPoint? position = inputRoot?.MouseDevice?.Position;
                PixelPoint point = position.GetValueOrDefault();
                return HtmlUtil.Convert(point);
            }
        }

        private bool _leftMouseButton;
        public override bool LeftMouseButton => (Control as HtmlControl)?.LeftMouseButton ?? false;

        public override bool RightMouseButton
        {
            get
            {
                return false;
                //TODO: Implement right mouse click
                //return Mouse.RightButton == MouseButtonState.Pressed;
            }
        }

        public override void SetCursorDefault()
        {
            Control.Cursor = new Cursor(StandardCursorType.Arrow);
        }

        public override void SetCursorHand()
        {
            Control.Cursor = new Cursor(StandardCursorType.Hand);
        }

        public override void SetCursorIBeam()
        {
            Control.Cursor = new Cursor(StandardCursorType.Ibeam);
        }

        public override void DoDragDropCopy(object dragDropData)
        {
            //TODO: Implement DragDropCopy
            //DragDrop.DoDragDrop(_control, dragDropData, DragDropEffects.Copy);
        }

        public override void MeasureString(string str, RFont font, double maxWidth, out int charFit, out double charFitWidth)
        {
            using (var g = new GraphicsAdapter())
            {
                g.MeasureString(str, font, maxWidth, out charFit, out charFitWidth);
            }
        }

        public override void Invalidate()
        {
            Control.InvalidateVisual();
        }
    }
}
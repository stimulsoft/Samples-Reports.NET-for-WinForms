using System;
using System.Drawing;
using System.Collections;
using System.Text;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Painters;
using Stimulsoft.Report.Events;

namespace Adding_a_Custom_Component_to_the_Designer
{
    public class MyCustomComponentGdiPainter : StiComponentGdiPainter
    {
        public virtual void PaintBackground(MyCustomComponent customComponent, Graphics g, RectangleD rect)
        {
            if (customComponent.Brush is StiSolidBrush &&
                ((StiSolidBrush)customComponent.Brush).Color == Color.Transparent &&
                customComponent.Report.Info.FillComponent &&
                customComponent.IsDesigning)
            {
                Color color = Color.FromArgb(150, Color.White);

                StiDrawing.FillRectangle(g, color, rect.Left, rect.Top, rect.Width, rect.Height);
            }
            else StiDrawing.FillRectangle(g, customComponent.Brush, rect);
        }

        public override void Paint(StiComponent component, StiPaintEventArgs e)
        {
            Graphics g = e.Graphics;

            RectangleD rect = component.GetPaintRectangle();
            if (rect.Width > 0 && rect.Height > 0 && (e.ClipRectangle.IsEmpty || rect.IntersectsWith(e.ClipRectangle)))
            {
                MyCustomComponent customComponent = component as MyCustomComponent;

                #region Fill rectangle
                PaintBackground(customComponent, g, rect);
                #endregion

                #region Markers
                if (customComponent.HighlightState == StiHighlightState.Hide && customComponent.Border.Side != StiBorderSides.All)
                    PaintMarkers(customComponent, g, rect);
                #endregion

                RectangleD borderRect = rect;

                //Own drawing


                #region Border
                base.PaintBorder(customComponent, g, borderRect);
                #endregion
            }

            PaintEvents(component, e.Graphics, rect);
            PaintConditions(component, e.Graphics, rect);
            PaintQuickButtons(component, e.Graphics);
            PaintInteraction(component, e.Graphics);
        }
    }
}

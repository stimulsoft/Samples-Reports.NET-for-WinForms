using System;
using System.Drawing;
using System.Collections;
using System.Text;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Painters;
using Stimulsoft.Report.Events;

namespace CustomComponents
{
    public class MyCustomComponentWithExpressionGdiPainter : StiComponentGdiPainter
    {
        public override void Paint(StiComponent component, StiPaintEventArgs e)
        {
            Graphics g = e.Graphics;
            RectangleD rect = component.GetPaintRectangle();

            RectangleF rectF = rect.ToRectangleF();
            g.DrawRectangle(Pens.Gray, rectF.Left, rectF.Top, rectF.Width, rectF.Height);

            MyCustomComponentWithExpression customComponent = component as MyCustomComponentWithExpression;

            using (StringFormat stringFormat = new StringFormat())
            using (Font font = new Font("Arial", (float)(15 * component.Page.Zoom)))
            using (Brush brush = new SolidBrush(Color.Gray))
            {
                stringFormat.LineAlignment = StringAlignment.Center;
                stringFormat.Alignment = StringAlignment.Center;

                string value = component.IsDesigning ? customComponent.CustomCode.Value : customComponent.CustomCodeValue;

                StiTextDrawing.DrawString(g, value, font, brush,
                    new RectangleD(rect.Left, rect.Top, rect.Width, rect.Height), stringFormat);
            }
        }
    }
}

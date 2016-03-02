#region Copyright (C) 2003-2012 Stimulsoft
/*
{*******************************************************************}
{																	}
{	Stimulsoft Reports												}
{	                         										}
{																	}
{	Copyright (C) 2003-2012 Stimulsoft     							}
{	ALL RIGHTS RESERVED												}
{																	}
{	The entire contents of this file is protected by U.S. and		}
{	International Copyright Laws. Unauthorized reproduction,		}
{	reverse-engineering, and distribution of all or any portion of	}
{	the code contained in this file is strictly prohibited and may	}
{	result in severe civil and criminal penalties and will be		}
{	prosecuted to the maximum extent possible under the law.		}
{																	}
{	RESTRICTIONS													}
{																	}
{	THIS SOURCE CODE AND ALL RESULTING INTERMEDIATE FILES			}
{	ARE CONFIDENTIAL AND PROPRIETARY								}
{	TRADE SECRETS OF Stimulsoft										}
{																	}
{	CONSULT THE END USER LICENSE AGREEMENT FOR INFORMATION ON		}
{	ADDITIONAL RESTRICTIONS.										}
{																	}
{*******************************************************************}
*/
#endregion Copyright (C) 2003-2012 Stimulsoft

using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.ComponentModel;
using Stimulsoft.Base.Drawing;

namespace Demo.Controls
{
    [ToolboxItem(false)]
    public class StiDemoButton : Control
    {
        #region Graphics Resources
        private static SolidBrush textBrush = new SolidBrush(Color.FromArgb(255, 39, 38, 37));
        private static SolidBrush selectedTextBrush = new SolidBrush(Color.FromArgb(255, 110, 110, 110));
        #endregion

        #region Fields
        // VisualStates
        private bool IsMouseOver = false;
        private bool IsPressed = false;

        private GraphicsPath path;
        private GraphicsPath path1;
        #endregion

        #region Properties
        private Image image;
        [DefaultValue("")]
        [Browsable(true)]
        public Image Image
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
            }
        }

        private string header = string.Empty;
        public string Header
        {
            get
            {
                return header;
            }
            set
            {
                header = value;
            }
        }

        private int buttonStyle = 0;
        [DefaultValue(0)]
        [Browsable(true)]
        public int ButtonStyle
        {
            get
            {
                return buttonStyle;
            }
            set
            {
                buttonStyle = value;
            }
        }
        #endregion

        #region Methods override
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            this.IsMouseOver = true;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            this.IsMouseOver = false;
            this.Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            this.IsPressed = true;
            this.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            this.IsPressed = false;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            SmoothingMode smoothingMode = g.SmoothingMode;
            TextRenderingHint textRenderingHint = g.TextRenderingHint;

            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            #region Draw
            if (buttonStyle == 0)
                DrawStyle1(g);
            else
                DrawStyle2(g);

            if (image != null)
            {
                g.DrawImage(image, new RectangleF(18, 18, 32, 32));
            }

            // Header
            using (Font font = new Font("Segoe UI", 16))
            {
                g.DrawString(this.header, font, (IsMouseOver ? selectedTextBrush : textBrush), 67, -8);
            }

            // Desription
            using (StringFormat sf = new StringFormat())
            {
                sf.FormatFlags = 0;
                sf.Trimming = StringTrimming.EllipsisWord;
                sf.Alignment = StringAlignment.Center;

                StiTextDrawing.DrawStringWidth(g, this.Text, this.Font, (IsMouseOver ? selectedTextBrush : textBrush), new RectangleD(70, 18, 365, 50), sf);
            }
            #endregion

            g.SmoothingMode = smoothingMode;
            g.TextRenderingHint = textRenderingHint;
        }
        #endregion

        #region Methods
        private void DrawStyle1(Graphics g)
        {
            Brush brush = null;
            Pen pen1 = null;
            Pen pen2 = null;

            if (IsMouseOver)
            {
                if (IsPressed)
                {
                    brush = new LinearGradientBrush(new Rectangle(0, 0, 67, 67), Color.FromArgb(255, 243, 126, 85), Color.FromArgb(255, 203, 74, 29), 45f);
                    pen1 = new Pen(new LinearGradientBrush(new Rectangle(0, 0, 67, 67), Color.FromArgb(255, 213, 69, 22), Color.FromArgb(255, 212, 68, 22), 45f), 1f);
                    pen2 = new Pen(new LinearGradientBrush(new Rectangle(1, 1, 66, 66), Color.FromArgb(255, 242, 167, 142), Color.FromArgb(255, 212, 140, 116), 45f), 1f);
                }
                else
                {
                    brush = new LinearGradientBrush(new Rectangle(0, 0, 67, 67), Color.FromArgb(255, 255, 166, 101), Color.FromArgb(255, 225, 126, 53), 45f);
                    pen1 = new Pen(new LinearGradientBrush(new Rectangle(0, 0, 67, 67), Color.FromArgb(255, 227, 128, 55), Color.FromArgb(255, 226, 127, 55), 45f), 1f);
                    pen2 = new Pen(new LinearGradientBrush(new Rectangle(1, 1, 66, 66), Color.FromArgb(255, 249, 195, 155), Color.FromArgb(255, 225, 173, 134), 45f), 1f);
                }
            }
            else
            {
                brush = new LinearGradientBrush(new Rectangle(0, 0, 67, 67), Color.FromArgb(255, 255, 144, 63), Color.FromArgb(255, 216, 93, 3), 45f);
                pen1 = new Pen(new LinearGradientBrush(new Rectangle(0, 0, 67, 67), Color.FromArgb(255, 223, 107, 21), Color.FromArgb(255, 219, 103, 17), 45f), 1f);
                pen2 = new Pen(new LinearGradientBrush(new Rectangle(1, 1, 66, 66), Color.FromArgb(255, 255, 158, 87), Color.FromArgb(255, 218, 152, 104), 45f), 1f);
            }

            g.FillPath(brush, path);
            g.DrawPath(pen1, path);
            g.DrawPath(pen2, path1);

            brush.Dispose();
            pen1.Dispose();
            pen2.Dispose();
        }

        private void DrawStyle2(Graphics g)
        {
            Brush brush = null;
            Pen pen1 = null;
            Pen pen2 = null;

            if (IsMouseOver)
            {
                if (IsPressed)
                {
                    brush = new LinearGradientBrush(new Rectangle(0, 0, 67, 67), Color.FromArgb(255, 255, 217, 63), Color.FromArgb(255, 217, 174, 3), 45f);
                    pen1 = new Pen(new LinearGradientBrush(new Rectangle(0, 0, 67, 67), Color.FromArgb(255, 210, 169, 6), Color.FromArgb(255, 210, 171, 18), 45f), 1f);
                    pen2 = new Pen(new LinearGradientBrush(new Rectangle(1, 1, 66, 66), Color.FromArgb(255, 247, 224, 132), Color.FromArgb(255, 216, 193, 104), 45f), 1f);
                }
                else
                {
                    brush = new LinearGradientBrush(new Rectangle(0, 0, 67, 67), Color.FromArgb(255, 255, 199, 101), Color.FromArgb(255, 225, 171, 77), 45f);
                    pen1 = new Pen(new LinearGradientBrush(new Rectangle(0, 0, 67, 67), Color.FromArgb(255, 223, 156, 60), Color.FromArgb(255, 222, 160, 70), 45f), 1f);
                    pen2 = new Pen(new LinearGradientBrush(new Rectangle(1, 1, 66, 66), Color.FromArgb(255, 249, 213, 156), Color.FromArgb(255, 225, 191, 135), 45f), 1f);
                }
            }
            else
            {
                brush = new LinearGradientBrush(new Rectangle(0, 0, 67, 67), Color.FromArgb(255, 255, 185, 63), Color.FromArgb(255, 216, 138, 3), 45f);
                pen1 = new Pen(new LinearGradientBrush(new Rectangle(0, 0, 67, 67), Color.FromArgb(255, 218, 140, 27), Color.FromArgb(255, 214, 136, 24), 45f), 1f);
                pen2 = new Pen(new LinearGradientBrush(new Rectangle(1, 1, 66, 66), Color.FromArgb(255, 247, 203, 131), Color.FromArgb(255, 217, 175, 105), 45f), 1f);
            }

            g.FillPath(brush, path);
            g.DrawPath(pen1, path);
            g.DrawPath(pen2, path1);

            brush.Dispose();
            pen1.Dispose();
            pen2.Dispose();
        }
        #endregion

        #region Methods Init
        private void InitPath()
        {
            path = new GraphicsPath();
            path.StartFigure();
            path.AddLine(8, 0, 59, 0);
            path.AddArc(51, 0, 16, 16, -90, 90);
            path.AddLine(67, 8, 67, 59);
            path.AddArc(51, 51, 16, 16, 0, 90);
            path.AddLine(59, 67, 8, 67);
            path.AddArc(0, 51, 16, 16, 90, 90);
            path.AddLine(0, 59, 0, 8);
            path.AddArc(0, 0, 16, 16, 180, 90);
            path.CloseFigure();

            path1 = new GraphicsPath();
            path1.StartFigure();
            path1.AddLine(9, 1, 58, 1);
            path1.AddArc(50, 1, 16, 16, -90, 90);
            path1.AddLine(66, 9, 66, 58);
            path1.AddArc(50, 50, 16, 16, 0, 90);
            path1.AddLine(58, 66, 9, 66);
            path1.AddArc(1, 50, 16, 16, 90, 90);
            path1.AddLine(1, 58, 1, 9);
            path1.AddArc(1, 1, 16, 16, 180, 90);
            path1.CloseFigure();
        }
        #endregion

        public StiDemoButton()
        {
            InitPath();
            this.Cursor = Cursors.Hand;

            this.Width = 445;
            this.Height = 68;
            this.Font = new Font("Segoe UI", 9);

            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }
    }
}
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
using Demo.Controls;
using System.Drawing;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.ComponentModel;
using Stimulsoft.Base;

namespace Demo
{
    [ToolboxItem(false)]
    public partial class StiWelcomeScreenControl : UserControl
    {
        #region Fields
        internal string welcome = string.Empty;
        internal string welcomeDescription = string.Empty;
        #endregion

        #region Methods
        internal void SetDemoButtonText(StiDemoButton button, string text)
        {
            int startIndex = text.IndexOf("<br>");
            button.Header = text.Substring(0, startIndex);

            startIndex += 4;
            button.Text = text.Substring(startIndex, text.Length - startIndex);
        }
        #endregion

        #region Methods override
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            SmoothingMode smoothingMode = g.SmoothingMode;
            TextRenderingHint textRenderingHint = g.TextRenderingHint;

            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;



            // Description
            using (Font font = new Font("Segoe UI", StiScale.I(12)))
            {
                StiTextRenderer.DrawText(g, welcomeDescription, font, new RectangleD(0, StiScale.I(68), StiScale.I(890), StiScale.I(142)), Color.FromArgb(45, 45, 45),
                    Color.Transparent, 1, StiTextHorAlignment.Width, StiVertAlignment.Top, true,
                    false, StiDpiHelper.GraphicsScale, 0, StringTrimming.None, false, true);
            }

            using (Font font = new Font("Segoe UI", 48))
            {
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                g.DrawString(welcome, font, new SolidBrush(Color.FromArgb(99, 99, 99)), new RectangleF(0, 0, StiScale.I(890), StiScale.I(68)), sf);

                sf.Dispose();
            }

            g.SmoothingMode = smoothingMode;
            g.TextRenderingHint = textRenderingHint;
        }
        #endregion

        #region Handlers
        private void buttons_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(((StiDemoButton)sender).Tag as string);
        }
        #endregion

        public StiWelcomeScreenControl()
        {
            InitializeComponent();

            if (!this.DesignMode)
            {
                buttonSupport.Tag = "https://www.stimulsoft.com/en/support";
                buttonVideo.Tag = "https://www.youtube.com/user/StimulsoftVideos";
                buttonForum.Tag = "https://forum.stimulsoft.com/";
                buttonDocumentation.Tag = "https://www.stimulsoft.com/en/documentation";
                buttonSampleProject.Tag = "https://www.stimulsoft.com/en/samples";
            }
        }
    }
}
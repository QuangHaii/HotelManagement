using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Presentation.CustomControl
{
	public class CustomButton : Button
	{
		private int borderSize = 0;
		private int borderRadius = 40;
		private Color borderColor = Color.PaleVioletRed;

		public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
		public int BorderRadius { get => borderRadius; set { borderRadius = value; this.Invalidate(); } }
		public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }

		public Color BackgroundColor { get => this.BackColor; set { this.BackColor = value; } }
		public Color TextColor { get => this.ForeColor; set { this.ForeColor = value; } }
		public string TextString { get => this.Text; set { this.Text = value; } }

		public CustomButton()
		{
			this.FlatStyle = FlatStyle.Flat;
			this.FlatAppearance.BorderSize = 0;
			this.Size = new Size(150, 40);
			this.BackColor = Color.MediumSlateBlue;
			this.ForeColor = Color.White;
		}

		private GraphicsPath GetFigurePath(RectangleF rect, float radius)
		{
			GraphicsPath path = new GraphicsPath();
			float curveSize = radius;
			path.StartFigure();
			path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
			path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
			path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
			path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
			path.CloseFigure();
			return path;
		}

		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
			RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);
			if (BorderRadius > 2)
			{
				using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
				using (GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius-1F))
				using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
				using (Pen penBorder = new Pen(BorderColor, BorderSize))
				{
					penBorder.Alignment = PenAlignment.Inset;
					this.Region = new Region(pathSurface);
					pevent.Graphics.DrawPath(penSurface, pathSurface);
					if (BorderSize >= 1)
						pevent.Graphics.DrawPath(penBorder, pathBorder);
				}
			}
			else
			{
				this.Region = new Region(rectSurface);
				if (BorderSize >= 1)
					using (Pen penborder = new Pen(BorderColor, BorderSize))
					{
						penborder.Alignment = PenAlignment.Inset;
						pevent.Graphics.DrawRectangle(penborder, 0, 0, this.Width - 1, this.Height - 1);

					}
			}
		}
		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
		}

		private void Container_BackColorChanged(object? sender, EventArgs e)
		{
			if (this.DesignMode)
				this.Invalidate();
		}
	}
}

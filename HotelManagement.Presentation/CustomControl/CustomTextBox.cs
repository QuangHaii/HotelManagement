using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.Presentation.CustomControl
{
	public partial class CustomTextBox : UserControl
	{
		private Color borderColor = Color.MediumSlateBlue;
		private int borderSize = 2;
		private bool underlinedStyle = false;
		private bool PassWordChar = false;
		private Color borderFocusColor = Color.FromArgb(78, 205, 196);
		private bool isFocused = false;

		private int borderRadius = 10;
		public CustomTextBox()
		{
			InitializeComponent();
		}

		public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }
		public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }
		public bool UnderlinedStyle { get => underlinedStyle; set { underlinedStyle = value; this.Invalidate(); } }
		public Color BorderFocusColor { get => borderFocusColor; set { borderFocusColor = value; this.Invalidate(); } }
		public int BorderRadius { get => borderRadius; set { if (value >= 0) { borderRadius = value; this.Invalidate(); } } }
		public bool PassWordChar1 { get => PassWordChar; set { PassWordChar = value; textBox1.UseSystemPasswordChar = value; this.Invalidate(); } }
		public Color BackgroundColor { get => textBox1.BackColor; set { textBox1.BackColor = value; } }
		public Color TextColor { get => textBox1.ForeColor; set { textBox1.ForeColor = value; } }
		public string TextString { get => textBox1.Text; set { textBox1.Text = value; } }

		private GraphicsPath GetFigurePath(Rectangle rect, int radius) { 			
			GraphicsPath path = new GraphicsPath();
			float curveSize = radius * 2F;
			path.StartFigure();
			path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
			path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
			path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
			path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
			path.CloseFigure();
			return path;
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graphics = e.Graphics;

			if (borderRadius > 1)
			{
				var rectBorderSmooth = this.ClientRectangle;
				var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
				int smoothSize = borderSize > 0 ? borderSize : 1;

				using (GraphicsPath path = GetFigurePath(rectBorderSmooth, borderRadius))
				using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
				using (Pen penBorderSmooth = new Pen(this.Parent.BackColor,smoothSize))
				using (Pen penBorder = new Pen(borderColor, borderSize))
				{
					this.Region = new Region(path);
					//if (borderRadius > 15) SetTextBoxRoundedRegion();
					graphics.SmoothingMode = SmoothingMode.AntiAlias;
					penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
					if (!isFocused)
					{
						if (underlinedStyle)
						{
							graphics.DrawPath(penBorderSmooth,path);
							graphics.SmoothingMode = SmoothingMode.None;
							graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
						}
						else
						{
							graphics.DrawPath(penBorderSmooth, path);
							graphics.DrawPath(penBorder, pathBorder);
						}
					}
					else
					{
						penBorder.Color = borderFocusColor;
						graphics.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
					}
					graphics.SmoothingMode = SmoothingMode.AntiAlias;
					graphics.DrawPath(penBorderSmooth, path);
					graphics.DrawPath(penBorder, pathBorder);
				}
			}
			else
			{
				using (Pen pen = new Pen(borderColor, borderSize))
				{
					this.Region = new Region(this.ClientRectangle);
					pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
					if (!isFocused)
					{
						if (underlinedStyle)
						{
							graphics.DrawLine(pen, 0, this.Height - 1, this.Width, this.Height - 1);
						}
						else
						{
							graphics.DrawRectangle(pen, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
						}
					}
					else
					{
						pen.Color = borderFocusColor;
						graphics.DrawLine(pen, 0, this.Height - 1, this.Width, this.Height - 1);
					}
				}
			}
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (this.DesignMode)
				UpdateControlHeight();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			UpdateControlHeight();
		}

		private void UpdateControlHeight()
		{
			if (textBox1.Multiline == false)
			{
				int txtHeight = TextRenderer.MeasureText("Text", textBox1.Font).Height + 1;
				textBox1.Multiline = true;
				textBox1.MinimumSize = new Size(0, txtHeight);
				textBox1.Multiline = false;
				this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;

			}
		}

		private void textBox1_Enter(object sender, EventArgs e)
		{
			isFocused = true;
			this.Invalidate();
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			isFocused = false;
			this.Invalidate();
		}
	}
}

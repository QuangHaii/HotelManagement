﻿namespace HotelManagement.Presentation.CustomControl
{
	partial class CustomTextBox
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.Dock = DockStyle.Fill;
			textBox1.Location = new Point(7, 7);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(186, 17);
			textBox1.TabIndex = 0;
			textBox1.Enter += textBox1_Enter;
			textBox1.Leave += textBox1_Leave;
			// 
			// CustomTextBox
			// 
			AutoScaleMode = AutoScaleMode.None;
			BackColor = SystemColors.Window;
			Controls.Add(textBox1);
			Font = new Font("Segoe UI", 9.5F);
			ForeColor = SystemColors.GradientActiveCaption;
			Margin = new Padding(4);
			Name = "CustomTextBox";
			Padding = new Padding(7);
			Size = new Size(200, 30);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
	}
}

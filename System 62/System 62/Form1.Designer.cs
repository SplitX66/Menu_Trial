/*
 * Created by SharpDevelop.
 * User: CC2_PC08
 * Date: 29/10/2026
 * Time: 07:37 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace System_62
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.conversorDeDolaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.distanciaEntreDosPuntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.coordenadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Maroon;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.conversorDeDolaresToolStripMenuItem,
									this.distanciaEntreDosPuntosToolStripMenuItem,
									this.coordenadasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(165, 214);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// conversorDeDolaresToolStripMenuItem
			// 
			this.conversorDeDolaresToolStripMenuItem.ForeColor = System.Drawing.Color.Ivory;
			this.conversorDeDolaresToolStripMenuItem.Name = "conversorDeDolaresToolStripMenuItem";
			this.conversorDeDolaresToolStripMenuItem.Size = new System.Drawing.Size(152, 19);
			this.conversorDeDolaresToolStripMenuItem.Text = "Conversor de Dolares";
			// 
			// distanciaEntreDosPuntosToolStripMenuItem
			// 
			this.distanciaEntreDosPuntosToolStripMenuItem.ForeColor = System.Drawing.Color.Ivory;
			this.distanciaEntreDosPuntosToolStripMenuItem.Name = "distanciaEntreDosPuntosToolStripMenuItem";
			this.distanciaEntreDosPuntosToolStripMenuItem.Size = new System.Drawing.Size(152, 19);
			this.distanciaEntreDosPuntosToolStripMenuItem.Text = "Distancia entre dos Puntos";
			// 
			// coordenadasToolStripMenuItem
			// 
			this.coordenadasToolStripMenuItem.ForeColor = System.Drawing.Color.Ivory;
			this.coordenadasToolStripMenuItem.Name = "coordenadasToolStripMenuItem";
			this.coordenadasToolStripMenuItem.Size = new System.Drawing.Size(152, 19);
			this.coordenadasToolStripMenuItem.Text = "Coordenadas";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 214);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Menu";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem coordenadasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem distanciaEntreDosPuntosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem conversorDeDolaresToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}

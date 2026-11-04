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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.conversorDeDolaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.distanciaEntreDosPuntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.coordenadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.salirDeAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Maroon;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.conversorDeDolaresToolStripMenuItem,
									this.distanciaEntreDosPuntosToolStripMenuItem,
									this.coordenadasToolStripMenuItem,
									this.salirDeAplicaciónToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(165, 262);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1ItemClicked);
			// 
			// conversorDeDolaresToolStripMenuItem
			// 
			this.conversorDeDolaresToolStripMenuItem.ForeColor = System.Drawing.Color.Ivory;
			this.conversorDeDolaresToolStripMenuItem.Name = "conversorDeDolaresToolStripMenuItem";
			this.conversorDeDolaresToolStripMenuItem.Size = new System.Drawing.Size(152, 19);
			this.conversorDeDolaresToolStripMenuItem.Text = "Conversor de Dolares";
			this.conversorDeDolaresToolStripMenuItem.Click += new System.EventHandler(this.ConversorDeDolaresToolStripMenuItemClick);
			// 
			// distanciaEntreDosPuntosToolStripMenuItem
			// 
			this.distanciaEntreDosPuntosToolStripMenuItem.ForeColor = System.Drawing.Color.Ivory;
			this.distanciaEntreDosPuntosToolStripMenuItem.Name = "distanciaEntreDosPuntosToolStripMenuItem";
			this.distanciaEntreDosPuntosToolStripMenuItem.Size = new System.Drawing.Size(152, 19);
			this.distanciaEntreDosPuntosToolStripMenuItem.Text = "Distancia entre dos Puntos";
			this.distanciaEntreDosPuntosToolStripMenuItem.Click += new System.EventHandler(this.DistanciaEntreDosPuntosToolStripMenuItemClick);
			// 
			// coordenadasToolStripMenuItem
			// 
			this.coordenadasToolStripMenuItem.ForeColor = System.Drawing.Color.Ivory;
			this.coordenadasToolStripMenuItem.Name = "coordenadasToolStripMenuItem";
			this.coordenadasToolStripMenuItem.Size = new System.Drawing.Size(152, 19);
			this.coordenadasToolStripMenuItem.Text = "Coordenadas";
			this.coordenadasToolStripMenuItem.Click += new System.EventHandler(this.CoordenadasToolStripMenuItemClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(196, 61);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(224, 189);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(196, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Bienvenido!";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(196, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(200, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Ya se siente la navidad :D";
			// 
			// salirDeAplicaciónToolStripMenuItem
			// 
			this.salirDeAplicaciónToolStripMenuItem.ForeColor = System.Drawing.Color.Ivory;
			this.salirDeAplicaciónToolStripMenuItem.Name = "salirDeAplicaciónToolStripMenuItem";
			this.salirDeAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(152, 19);
			this.salirDeAplicaciónToolStripMenuItem.Text = "Salir de Aplicación";
			this.salirDeAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.SalirDeAplicaciónToolStripMenuItemClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 262);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Menu";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem salirDeAplicaciónToolStripMenuItem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ToolStripMenuItem coordenadasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem distanciaEntreDosPuntosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem conversorDeDolaresToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}

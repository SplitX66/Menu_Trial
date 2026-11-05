/*
 * Created by SharpDevelop.
 * User: CC2_PC08
 * Date: 04/11/2026
 * Time: 07:20 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace System_62
{
	partial class Form4
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
			this.btnRegresar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblResultado = new System.Windows.Forms.Label();
			this.txtY = new System.Windows.Forms.TextBox();
			this.txtX = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnRegresar.Location = new System.Drawing.Point(187, 127);
			this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(68, 27);
			this.btnRegresar.TabIndex = 17;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.BtnRegresarClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnLimpiar.Location = new System.Drawing.Point(24, 127);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(68, 27);
			this.btnLimpiar.TabIndex = 16;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// btnCalcular
			// 
			this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnCalcular.Location = new System.Drawing.Point(99, 127);
			this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(83, 27);
			this.btnCalcular.TabIndex = 15;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = false;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// lblResultado
			// 
			this.lblResultado.Location = new System.Drawing.Point(25, 184);
			this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblResultado.Name = "lblResultado";
			this.lblResultado.Size = new System.Drawing.Size(230, 41);
			this.lblResultado.TabIndex = 14;
			// 
			// txtY
			// 
			this.txtY.Location = new System.Drawing.Point(99, 89);
			this.txtY.Margin = new System.Windows.Forms.Padding(2);
			this.txtY.Name = "txtY";
			this.txtY.Size = new System.Drawing.Size(83, 20);
			this.txtY.TabIndex = 12;
			// 
			// txtX
			// 
			this.txtX.Location = new System.Drawing.Point(99, 55);
			this.txtX.Margin = new System.Windows.Forms.Padding(2);
			this.txtX.Name = "txtX";
			this.txtX.Size = new System.Drawing.Size(83, 20);
			this.txtX.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(25, 89);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 15);
			this.label2.TabIndex = 10;
			this.label2.Text = "Ingresar y:";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 60);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 9;
			this.label1.Text = "Ingresar x:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.label3.Location = new System.Drawing.Point(82, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = "CORDENADAS";
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(284, 231);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnRegresar);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.lblResultado);
			this.Controls.Add(this.txtY);
			this.Controls.Add(this.txtX);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form4";
			this.Text = "Form4";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtX;
		private System.Windows.Forms.TextBox txtY;
		private System.Windows.Forms.Label lblResultado;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnRegresar;
	}
}

/*
 * Creado por SharpDevelop.
 * Usuario: elmak
 * Fecha: 04/11/2026
 * Hora: 07:41 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace System_62
{
	/// <summary>
	/// Description of DistanciaPuntos.
	/// </summary>
	public partial class DistanciaPuntos : Form
	{
		public DistanciaPuntos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double x1, x2, y1, y2, restax, restay, cuadradox, cuadradoy, suma, raiz;
			
			x1 = Convert.ToDouble(txtX1.Text);
			x2 = Convert.ToDouble(txtX2.Text);
			y1 = Convert.ToDouble(txtY1.Text);
			y2 = Convert.ToDouble(txtY2.Text);
			restax = x1 - x2;
			restay = y1 - y2;
			cuadradox = restax * restax;
			cuadradoy = restay * restay;
			suma = cuadradoy + cuadradox;
			raiz = Math.Sqrt(suma);
			
			lblResultado.Text = string.Format("Distancia: {0:F3}", raiz);
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtY1.Text=" ";		
			txtY2.Text=" ";	
			txtX1.Text=" ";	
			txtX2.Text=" ";				
		}
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			Form1 x = new Form1();
			x.Show();
			this.Close();
		}
	}
}

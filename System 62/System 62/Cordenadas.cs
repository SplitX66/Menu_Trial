/*
 * Creado por SharpDevelop.
 * Usuario: elmak
 * Fecha: 04/11/2026
 * Hora: 08:23 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace System_62
{
	/// <summary>
	/// Description of Cordenadas.
	/// </summary>
	public partial class Cordenadas : Form
	{
		public Cordenadas()
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
			double x, y;
			string result="";
			x = Convert.ToDouble(txtX.Text);
			y = Convert.ToDouble(txtY.Text);
			
			if(x > 0 && y > 0){
				result = "Primer cuadrante";
			}
			if(x < 0 && y > 0){
				result = "Segundo cuadrante";
			}
			if(x < 0 && y < 0){
				result = "Tercer cuadrante";
			}
			if(x > 0 && y < 0){
				result = "Cuarto cuadrante";
			}
			if(x == 0 || y == 0){
				result = "Origen";
			}
			
			lblResultado.Text="Las coordenadas estan en el "+result;
		}
		
		void CordenadasLoad(object sender, EventArgs e)
		{
			
		}
	}
}

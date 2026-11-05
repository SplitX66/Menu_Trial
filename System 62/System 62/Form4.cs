/*
 * Created by SharpDevelop.
 * User: CC2_PC08
 * Date: 04/11/2026
 * Time: 07:20 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace System_62
{
	/// <summary>
	/// Description of Form4.
	/// </summary>
	public partial class Form4 : Form
	{
		public Form4()
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
		
		void BtnRegresarClick(object sender, EventArgs e)
		{
			Form1 x = new Form1();
			x.Show();
			this.Close();			
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtX.Text=" ";
			txtY.Text=" ";		
			lblResultado.Text=" ";			
		}
	}
}

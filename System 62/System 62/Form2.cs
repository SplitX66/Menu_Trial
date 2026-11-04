/*
 * Created by SharpDevelop.
 * User: CC2_PC08
 * Date: 04/11/2026
 * Time: 07:19 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace System_62
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form1 mnu = new Form1();
			mnu.Show();
			this.Close();
		}
		
		void ConversiónToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(comboBox1.SelectedItem.ToString() == "Dolares Estadounidenses"){
				double value = 0.054;
				double result = value * Convert.ToDouble(textBox1.Text);
				label4.Text="El valor indicado equivale a "+Convert.ToString(result)+" Dolares Estadounidenses";
			}
			
			if(comboBox1.SelectedItem.ToString() == "Pesos Mexicanos"){
				double value = 18.67;
				double result = value * Convert.ToDouble(textBox1.Text);
				label4.Text="El valor indicado equivale a "+Convert.ToString(result)+" Pesos Mexicanos";
			}
		}
	}
}

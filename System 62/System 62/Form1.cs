/*
 * Created by SharpDevelop.
 * User: CC2_PC08
 * Date: 29/10/2026
 * Time: 07:37 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace System_62
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MenuStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			
		}
		
		void ConversorDeDolaresToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form2 Conv = new Form2();
			this.Hide();
			Conv.Show();
		}
		
		void CoordenadasToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form4 Card = new Form4();
			this.Hide();
			Card.Show();	
		}
		
		void DistanciaEntreDosPuntosToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form3 Dist = new Form3();
			this.Hide();
			Dist.Show();			
		}
	}
}

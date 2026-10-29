/*
 * Created by SharpDevelop.
 * User: CC2_PC08
 * Date: 29/10/2026
 * Time: 07:29 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace System_62
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(textBox2.Text == "Hola"){
				Form1 mnu = new Form1();
				this.Hide();
				mnu.Show();
			}
		}
	}
}

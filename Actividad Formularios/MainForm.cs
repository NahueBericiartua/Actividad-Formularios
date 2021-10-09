/*
 * Created by SharpDevelop.
 * User: Nahue
 * Date: 8/10/2021
 * Time: 18:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Actividad_Formularios
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public Form formulario;
		public MainForm()
		{
			formulario = new Form1();
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Btn_mostrarClick(object sender, EventArgs e)
		{
			formulario.Show();
		}
		void Btn_ocultarClick(object sender, EventArgs e)
		{
			formulario.Hide();
		}
	}
}

/*
 * Creado por SharpDevelop.
 * Usuario: oscar
 * Fecha: 23/10/2026
 * Hora: 07:34 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace multiplica
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
		
		void BtnMultiplicarClick(object sender, EventArgs e)
		{
			double r= Double.Parse(txtNum1.Text)* Double.Parse(txtNum2.Text);
			MessageBox.Show("Resultado "+ r);
			
		}
	}
}

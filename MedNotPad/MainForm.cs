/*
 * Criado por SharpDevelop.
 * Usuário: ICFC
 * Data: 27/01/2023
 * Hora: 13:45
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MedNotPad
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
		void FecharToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void Minimizar_TSMitemClick(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
			
		}
		void DarkTSMitemClick(object sender, EventArgs e)
		{
			richTextBox1.BackColor = Color.Black;
			richTextBox1.ForeColor = Color.White;
		}
		void MediocreTSMitemClick(object sender, EventArgs e)
		{
			richTextBox1.BackColor = Color.White;
			richTextBox1.ForeColor = Color.Blue;
		}
		void TurboPascalTSMitemClick(object sender, EventArgs e)
		{
			richTextBox1.BackColor = Color.FromArgb(0,0,50);
			richTextBox1.ForeColor = Color.Yellow;
		}
		void UbuntuTSMitemClick(object sender, EventArgs e)
		{
			richTextBox1.BackColor = Color.FromArgb(80,10,50);
			richTextBox1.ForeColor = Color.Silver;
		}
		void ZebeleTSMitemClick(object sender, EventArgs e)
		{
			richTextBox1.BackColor = Color.FromArgb(40,40,40);
			richTextBox1.ForeColor = Color.White;
		}
		
		
		
	
	}
}

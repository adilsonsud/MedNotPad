/*
 * Criado por SharpDevelop.
 * Usuário: ICFC
 * Data: 27/01/2023
 * Hora: 13:45
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace MedNotPad
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem Tema_TSMitem;
		private System.Windows.Forms.ToolStripMenuItem DarkTSMitem;
		private System.Windows.Forms.ToolStripMenuItem MediocreTSMitem;
		private System.Windows.Forms.ToolStripMenuItem TurboPascalTSMitem;
		private System.Windows.Forms.ToolStripMenuItem UbuntuTSMitem;
		private System.Windows.Forms.ToolStripMenuItem Fonte_TSMitem;
		private System.Windows.Forms.ToolStripMenuItem Minimizar_TSMitem;
		private System.Windows.Forms.ToolStripMenuItem ZebeleTSMitem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem Salvar_TSMitem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem Fechar_TSMitem;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Tema_TSMitem = new System.Windows.Forms.ToolStripMenuItem();
			this.DarkTSMitem = new System.Windows.Forms.ToolStripMenuItem();
			this.MediocreTSMitem = new System.Windows.Forms.ToolStripMenuItem();
			this.TurboPascalTSMitem = new System.Windows.Forms.ToolStripMenuItem();
			this.UbuntuTSMitem = new System.Windows.Forms.ToolStripMenuItem();
			this.ZebeleTSMitem = new System.Windows.Forms.ToolStripMenuItem();
			this.Fonte_TSMitem = new System.Windows.Forms.ToolStripMenuItem();
			this.Minimizar_TSMitem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.Salvar_TSMitem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.chamadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.renachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adiçãoDeCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.enviamentoDeAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.instalamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.desnativaçãoDeAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.protocoloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.Fechar_TSMitem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.ForeColor = System.Drawing.Color.White;
			this.richTextBox1.Location = new System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.richTextBox1.Size = new System.Drawing.Size(349, 465);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.Tema_TSMitem,
									this.Fonte_TSMitem,
									this.Minimizar_TSMitem,
									this.toolStripMenuItem4,
									this.Salvar_TSMitem,
									this.toolStripMenuItem5,
									this.chamadoToolStripMenuItem,
									this.protocoloToolStripMenuItem,
									this.toolStripMenuItem1,
									this.Fechar_TSMitem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.contextMenuStrip1.Size = new System.Drawing.Size(128, 176);
			// 
			// Tema_TSMitem
			// 
			this.Tema_TSMitem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.DarkTSMitem,
									this.MediocreTSMitem,
									this.TurboPascalTSMitem,
									this.UbuntuTSMitem,
									this.ZebeleTSMitem});
			this.Tema_TSMitem.Name = "Tema_TSMitem";
			this.Tema_TSMitem.Size = new System.Drawing.Size(127, 22);
			this.Tema_TSMitem.Text = "Tema";
			// 
			// DarkTSMitem
			// 
			this.DarkTSMitem.Name = "DarkTSMitem";
			this.DarkTSMitem.Size = new System.Drawing.Size(141, 22);
			this.DarkTSMitem.Text = "Dark";
			this.DarkTSMitem.Click += new System.EventHandler(this.DarkTSMitemClick);
			// 
			// MediocreTSMitem
			// 
			this.MediocreTSMitem.Name = "MediocreTSMitem";
			this.MediocreTSMitem.Size = new System.Drawing.Size(141, 22);
			this.MediocreTSMitem.Text = "Mediocre";
			this.MediocreTSMitem.Click += new System.EventHandler(this.MediocreTSMitemClick);
			// 
			// TurboPascalTSMitem
			// 
			this.TurboPascalTSMitem.Name = "TurboPascalTSMitem";
			this.TurboPascalTSMitem.Size = new System.Drawing.Size(141, 22);
			this.TurboPascalTSMitem.Text = "Turbo Pascal";
			this.TurboPascalTSMitem.Click += new System.EventHandler(this.TurboPascalTSMitemClick);
			// 
			// UbuntuTSMitem
			// 
			this.UbuntuTSMitem.Name = "UbuntuTSMitem";
			this.UbuntuTSMitem.Size = new System.Drawing.Size(141, 22);
			this.UbuntuTSMitem.Text = "Ubuntu";
			this.UbuntuTSMitem.Click += new System.EventHandler(this.UbuntuTSMitemClick);
			// 
			// ZebeleTSMitem
			// 
			this.ZebeleTSMitem.Name = "ZebeleTSMitem";
			this.ZebeleTSMitem.Size = new System.Drawing.Size(141, 22);
			this.ZebeleTSMitem.Text = "Zebelê";
			this.ZebeleTSMitem.Click += new System.EventHandler(this.ZebeleTSMitemClick);
			// 
			// Fonte_TSMitem
			// 
			this.Fonte_TSMitem.Name = "Fonte_TSMitem";
			this.Fonte_TSMitem.Size = new System.Drawing.Size(127, 22);
			this.Fonte_TSMitem.Text = "Fonte";
			// 
			// Minimizar_TSMitem
			// 
			this.Minimizar_TSMitem.Name = "Minimizar_TSMitem";
			this.Minimizar_TSMitem.Size = new System.Drawing.Size(127, 22);
			this.Minimizar_TSMitem.Text = "Minimizar";
			this.Minimizar_TSMitem.Click += new System.EventHandler(this.Minimizar_TSMitemClick);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(124, 6);
			// 
			// Salvar_TSMitem
			// 
			this.Salvar_TSMitem.Name = "Salvar_TSMitem";
			this.Salvar_TSMitem.Size = new System.Drawing.Size(127, 22);
			this.Salvar_TSMitem.Text = "Salvar";
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(124, 6);
			// 
			// chamadoToolStripMenuItem
			// 
			this.chamadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.renachToolStripMenuItem,
									this.adiçãoDeCreditoToolStripMenuItem,
									this.enviamentoDeAulaToolStripMenuItem,
									this.instalamentoToolStripMenuItem,
									this.desnativaçãoDeAulaToolStripMenuItem});
			this.chamadoToolStripMenuItem.Name = "chamadoToolStripMenuItem";
			this.chamadoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.chamadoToolStripMenuItem.Text = "Chamado";
			// 
			// renachToolStripMenuItem
			// 
			this.renachToolStripMenuItem.Name = "renachToolStripMenuItem";
			this.renachToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.renachToolStripMenuItem.Text = "Corregimento de Renach";
			// 
			// adiçãoDeCreditoToolStripMenuItem
			// 
			this.adiçãoDeCreditoToolStripMenuItem.Name = "adiçãoDeCreditoToolStripMenuItem";
			this.adiçãoDeCreditoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.adiçãoDeCreditoToolStripMenuItem.Text = "Colocamento de Credito";
			// 
			// enviamentoDeAulaToolStripMenuItem
			// 
			this.enviamentoDeAulaToolStripMenuItem.Name = "enviamentoDeAulaToolStripMenuItem";
			this.enviamentoDeAulaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.enviamentoDeAulaToolStripMenuItem.Text = "Enviamento de Aula";
			// 
			// instalamentoToolStripMenuItem
			// 
			this.instalamentoToolStripMenuItem.Name = "instalamentoToolStripMenuItem";
			this.instalamentoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.instalamentoToolStripMenuItem.Text = "Instalamento de Sistema";
			// 
			// desnativaçãoDeAulaToolStripMenuItem
			// 
			this.desnativaçãoDeAulaToolStripMenuItem.Name = "desnativaçãoDeAulaToolStripMenuItem";
			this.desnativaçãoDeAulaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.desnativaçãoDeAulaToolStripMenuItem.Text = "Desnativação de Aula";
			// 
			// protocoloToolStripMenuItem
			// 
			this.protocoloToolStripMenuItem.Name = "protocoloToolStripMenuItem";
			this.protocoloToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
			this.protocoloToolStripMenuItem.Text = "Protocolo";
			this.protocoloToolStripMenuItem.Click += new System.EventHandler(this.ProtocoloToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 6);
			// 
			// Fechar_TSMitem
			// 
			this.Fechar_TSMitem.Name = "Fechar_TSMitem";
			this.Fechar_TSMitem.Size = new System.Drawing.Size(127, 22);
			this.Fechar_TSMitem.Text = "Fechar";
			this.Fechar_TSMitem.Click += new System.EventHandler(this.FecharToolStripMenuItem1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(349, 465);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Controls.Add(this.richTextBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "97%";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ToolStripMenuItem desnativaçãoDeAulaToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem protocoloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem instalamentoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem enviamentoDeAulaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adiçãoDeCreditoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem renachToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem chamadoToolStripMenuItem;
	}
}

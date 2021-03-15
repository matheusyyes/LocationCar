
namespace LocationCar.View
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.carroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeVeiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carroToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(378, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // carroToolStripMenuItem
            // 
            this.carroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroCarroToolStripMenuItem,
            this.listaDeVeiculosToolStripMenuItem,
            this.editarVeiculoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.carroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("carroToolStripMenuItem.Image")));
            this.carroToolStripMenuItem.Name = "carroToolStripMenuItem";
            this.carroToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.carroToolStripMenuItem.Text = "Carro";
            // 
            // cadastroCarroToolStripMenuItem
            // 
            this.cadastroCarroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroCarroToolStripMenuItem.Image")));
            this.cadastroCarroToolStripMenuItem.Name = "cadastroCarroToolStripMenuItem";
            this.cadastroCarroToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cadastroCarroToolStripMenuItem.Text = "Cadastro veiculo";
            this.cadastroCarroToolStripMenuItem.Click += new System.EventHandler(this.cadastroCarroToolStripMenuItem_Click);
            // 
            // listaDeVeiculosToolStripMenuItem
            // 
            this.listaDeVeiculosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listaDeVeiculosToolStripMenuItem.Image")));
            this.listaDeVeiculosToolStripMenuItem.Name = "listaDeVeiculosToolStripMenuItem";
            this.listaDeVeiculosToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.listaDeVeiculosToolStripMenuItem.Text = "Lista de veiculos ";
            // 
            // editarVeiculoToolStripMenuItem
            // 
            this.editarVeiculoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarVeiculoToolStripMenuItem.Image")));
            this.editarVeiculoToolStripMenuItem.Name = "editarVeiculoToolStripMenuItem";
            this.editarVeiculoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.editarVeiculoToolStripMenuItem.Text = "Editar veiculo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // cadastroDeClienteToolStripMenuItem
            // 
            this.cadastroDeClienteToolStripMenuItem.Name = "cadastroDeClienteToolStripMenuItem";
            this.cadastroDeClienteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cadastroDeClienteToolStripMenuItem.Text = "Cadastro de cliente";
            this.cadastroDeClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClienteToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 159);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem carroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeVeiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClienteToolStripMenuItem;
    }
}
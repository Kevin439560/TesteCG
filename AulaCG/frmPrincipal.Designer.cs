namespace AulaCG {
    partial class frmPrincipal {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.menuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBasico = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.statusPrincipal = new System.Windows.Forms.StatusStrip();
            this.barraPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuUnidadeFederativa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.barraPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastro});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1067, 28);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // menuCadastro
            // 
            this.menuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBasico,
            this.toolStripMenuItem1,
            this.menuFechar});
            this.menuCadastro.Name = "menuCadastro";
            this.menuCadastro.Size = new System.Drawing.Size(82, 24);
            this.menuCadastro.Text = "Cadastro";
            this.menuCadastro.Click += new System.EventHandler(this.menuCadastro_Click);
            // 
            // menuBasico
            // 
            this.menuBasico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUnidadeFederativa});
            this.menuBasico.Name = "menuBasico";
            this.menuBasico.Size = new System.Drawing.Size(224, 26);
            this.menuBasico.Text = "Basico";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // menuFechar
            // 
            this.menuFechar.Name = "menuFechar";
            this.menuFechar.Size = new System.Drawing.Size(224, 26);
            this.menuFechar.Text = "Fechar";
            // 
            // statusPrincipal
            // 
            this.statusPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusPrincipal.Location = new System.Drawing.Point(0, 532);
            this.statusPrincipal.Name = "statusPrincipal";
            this.statusPrincipal.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusPrincipal.Size = new System.Drawing.Size(1067, 22);
            this.statusPrincipal.TabIndex = 2;
            this.statusPrincipal.Text = "statusStrip1";
            // 
            // barraPrincipal
            // 
            this.barraPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barraPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.barraPrincipal.Location = new System.Drawing.Point(0, 28);
            this.barraPrincipal.Name = "barraPrincipal";
            this.barraPrincipal.Size = new System.Drawing.Size(1067, 39);
            this.barraPrincipal.TabIndex = 3;
            this.barraPrincipal.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // menuUnidadeFederativa
            // 
            this.menuUnidadeFederativa.Name = "menuUnidadeFederativa";
            this.menuUnidadeFederativa.Size = new System.Drawing.Size(224, 26);
            this.menuUnidadeFederativa.Text = "Unidade Federativa";
            this.menuUnidadeFederativa.Click += new System.EventHandler(this.menuUnidadeFederativa_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.barraPrincipal);
            this.Controls.Add(this.statusPrincipal);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto Novo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.barraPrincipal.ResumeLayout(false);
            this.barraPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem menuCadastro;
        private System.Windows.Forms.ToolStripMenuItem menuBasico;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuFechar;
        private System.Windows.Forms.StatusStrip statusPrincipal;
        private System.Windows.Forms.ToolStrip barraPrincipal;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem menuUnidadeFederativa;
    }
}


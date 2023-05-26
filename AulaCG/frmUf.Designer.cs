namespace AulaCG {
    partial class frmUf {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUf));
            this.barraManu = new System.Windows.Forms.ToolStrip();
            this.barrabtnNovo = new System.Windows.Forms.ToolStripButton();
            this.barrabtnEditar = new System.Windows.Forms.ToolStripButton();
            this.barrabtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.barrabtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.barrabtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.barrabtnFechar = new System.Windows.Forms.ToolStripButton();
            this.dadosUf = new System.Windows.Forms.DataGridView();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelSigla = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.barraManu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosUf)).BeginInit();
            this.SuspendLayout();
            // 
            // barraManu
            // 
            this.barraManu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barraManu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barrabtnNovo,
            this.barrabtnEditar,
            this.barrabtnExcluir,
            this.barrabtnSalvar,
            this.barrabtnCancelar,
            this.barrabtnFechar});
            this.barraManu.Location = new System.Drawing.Point(0, 0);
            this.barraManu.Name = "barraManu";
            this.barraManu.Size = new System.Drawing.Size(615, 39);
            this.barraManu.TabIndex = 0;
            this.barraManu.Text = "toolStrip1";
            // 
            // barrabtnNovo
            // 
            this.barrabtnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barrabtnNovo.Image = ((System.Drawing.Image)(resources.GetObject("barrabtnNovo.Image")));
            this.barrabtnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barrabtnNovo.Name = "barrabtnNovo";
            this.barrabtnNovo.Size = new System.Drawing.Size(36, 36);
            this.barrabtnNovo.Text = "Novo";
            this.barrabtnNovo.ToolTipText = "Nova Unidade Federativa";
            this.barrabtnNovo.Click += new System.EventHandler(this.barrabtnNovo_Click);
            // 
            // barrabtnEditar
            // 
            this.barrabtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barrabtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("barrabtnEditar.Image")));
            this.barrabtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barrabtnEditar.Name = "barrabtnEditar";
            this.barrabtnEditar.Size = new System.Drawing.Size(36, 36);
            this.barrabtnEditar.Text = "Editar";
            this.barrabtnEditar.ToolTipText = "Edita a Unidade Federativa Selecionada";
            this.barrabtnEditar.Click += new System.EventHandler(this.barrabtnEditar_Click);
            // 
            // barrabtnExcluir
            // 
            this.barrabtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barrabtnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("barrabtnExcluir.Image")));
            this.barrabtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barrabtnExcluir.Name = "barrabtnExcluir";
            this.barrabtnExcluir.Size = new System.Drawing.Size(36, 36);
            this.barrabtnExcluir.Text = "Exclui";
            this.barrabtnExcluir.ToolTipText = "Exclui a Unidade Federativa Selecionada";
            this.barrabtnExcluir.Click += new System.EventHandler(this.barrabtnExcluir_Click);
            // 
            // barrabtnSalvar
            // 
            this.barrabtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barrabtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("barrabtnSalvar.Image")));
            this.barrabtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barrabtnSalvar.Name = "barrabtnSalvar";
            this.barrabtnSalvar.Size = new System.Drawing.Size(36, 36);
            this.barrabtnSalvar.Text = "Salvar";
            this.barrabtnSalvar.ToolTipText = "Salva uma nova Unidade Federativa";
            this.barrabtnSalvar.Click += new System.EventHandler(this.barrabtnSalvar_Click);
            // 
            // barrabtnCancelar
            // 
            this.barrabtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barrabtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("barrabtnCancelar.Image")));
            this.barrabtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barrabtnCancelar.Name = "barrabtnCancelar";
            this.barrabtnCancelar.Size = new System.Drawing.Size(36, 36);
            this.barrabtnCancelar.Text = "Cancelar";
            this.barrabtnCancelar.ToolTipText = "Cancela a operação de inclusão ou edição";
            this.barrabtnCancelar.Click += new System.EventHandler(this.barrabtnCancelar_Click);
            // 
            // barrabtnFechar
            // 
            this.barrabtnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.barrabtnFechar.Image = ((System.Drawing.Image)(resources.GetObject("barrabtnFechar.Image")));
            this.barrabtnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.barrabtnFechar.Name = "barrabtnFechar";
            this.barrabtnFechar.Size = new System.Drawing.Size(36, 36);
            this.barrabtnFechar.Text = "Fechar";
            this.barrabtnFechar.ToolTipText = "Fecha o formulário de Manutenção de Unidade Federativa";
            this.barrabtnFechar.Click += new System.EventHandler(this.barrabtnFechar_Click);
            // 
            // dadosUf
            // 
            this.dadosUf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosUf.Location = new System.Drawing.Point(0, 42);
            this.dadosUf.Name = "dadosUf";
            this.dadosUf.RowHeadersWidth = 51;
            this.dadosUf.Size = new System.Drawing.Size(240, 264);
            this.dadosUf.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(262, 42);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(59, 21);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(265, 63);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(338, 29);
            this.txtNome.TabIndex = 3;
            // 
            // labelSigla
            // 
            this.labelSigla.AutoSize = true;
            this.labelSigla.Location = new System.Drawing.Point(265, 95);
            this.labelSigla.Name = "labelSigla";
            this.labelSigla.Size = new System.Drawing.Size(55, 21);
            this.labelSigla.TabIndex = 4;
            this.labelSigla.Text = "Sigla: ";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(265, 116);
            this.txtSigla.MaxLength = 2;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(43, 29);
            this.txtSigla.TabIndex = 5;
            // 
            // frmUf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 333);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.labelSigla);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.dadosUf);
            this.Controls.Add(this.barraManu);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção de Unidade Federativa";
            this.Load += new System.EventHandler(this.frmUf_Load);
            this.barraManu.ResumeLayout(false);
            this.barraManu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dadosUf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barraManu;
        private System.Windows.Forms.ToolStripButton barrabtnNovo;
        private System.Windows.Forms.ToolStripButton barrabtnEditar;
        private System.Windows.Forms.ToolStripButton barrabtnExcluir;
        private System.Windows.Forms.ToolStripButton barrabtnSalvar;
        private System.Windows.Forms.ToolStripButton barrabtnCancelar;
        private System.Windows.Forms.ToolStripButton barrabtnFechar;
        private System.Windows.Forms.DataGridView dadosUf;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label labelSigla;
        private System.Windows.Forms.TextBox txtSigla;
    }
}
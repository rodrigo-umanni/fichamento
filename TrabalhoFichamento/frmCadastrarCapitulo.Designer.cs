namespace TrabalhoFichamento
{
    partial class frmCadastrarCapitulo
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
            this.components = new System.ComponentModel.Container();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCnfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarProjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarFichamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFichamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarObraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarObraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarModalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarNaturezaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarFormaDeEstudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarObjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelObra = new System.Windows.Forms.Label();
            this.labelPagina = new System.Windows.Forms.Label();
            this.labelDe = new System.Windows.Forms.Label();
            this.textBoxObra = new System.Windows.Forms.TextBox();
            this.textBoxPaginaDe = new System.Windows.Forms.TextBox();
            this.textBoxAte = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.ForeColor = System.Drawing.Color.Red;
            this.labelInfo.Location = new System.Drawing.Point(29, 316);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(111, 13);
            this.labelInfo.TabIndex = 34;
            this.labelInfo.Text = "* Campos Obrigatórios";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(25, 50);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(159, 24);
            this.labelTitle.TabIndex = 33;
            this.labelTitle.Text = "Cadastrar Artigo";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Image = global::TrabalhoFichamento.Properties.Resources.limpar;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(405, 383);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(158, 53);
            this.btnLimpar.TabIndex = 32;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCnfirmar
            // 
            this.btnCnfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCnfirmar.Image = global::TrabalhoFichamento.Properties.Resources.confirmar;
            this.btnCnfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCnfirmar.Location = new System.Drawing.Point(596, 383);
            this.btnCnfirmar.Name = "btnCnfirmar";
            this.btnCnfirmar.Size = new System.Drawing.Size(158, 53);
            this.btnCnfirmar.TabIndex = 31;
            this.btnCnfirmar.Text = "Confirmar";
            this.btnCnfirmar.UseVisualStyleBackColor = true;
            this.btnCnfirmar.Click += new System.EventHandler(this.btnCnfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = global::TrabalhoFichamento.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(204, 383);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(158, 53);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(826, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(138, 17);
            this.toolStripStatusLabel1.Text = "Cadastrar Capítulo de Livro";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.projetoToolStripMenuItem,
            this.fichamentoToolStripMenuItem,
            this.obraToolStripMenuItem,
            this.autorToolStripMenuItem,
            this.outrosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // projetoToolStripMenuItem
            // 
            this.projetoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarProjetoToolStripMenuItem,
            this.cadastrarProjetoToolStripMenuItem});
            this.projetoToolStripMenuItem.Name = "projetoToolStripMenuItem";
            this.projetoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.projetoToolStripMenuItem.Text = "Projeto";
            // 
            // verificarProjetoToolStripMenuItem
            // 
            this.verificarProjetoToolStripMenuItem.Name = "verificarProjetoToolStripMenuItem";
            this.verificarProjetoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.verificarProjetoToolStripMenuItem.Text = "Verificar Projeto";
            this.verificarProjetoToolStripMenuItem.Click += new System.EventHandler(this.verificarProjetoToolStripMenuItem_Click);
            // 
            // cadastrarProjetoToolStripMenuItem
            // 
            this.cadastrarProjetoToolStripMenuItem.Name = "cadastrarProjetoToolStripMenuItem";
            this.cadastrarProjetoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cadastrarProjetoToolStripMenuItem.Text = "Cadastrar Projeto";
            this.cadastrarProjetoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProjetoToolStripMenuItem_Click);
            // 
            // fichamentoToolStripMenuItem
            // 
            this.fichamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarFichamentoToolStripMenuItem,
            this.cadastrarFichamentoToolStripMenuItem});
            this.fichamentoToolStripMenuItem.Name = "fichamentoToolStripMenuItem";
            this.fichamentoToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.fichamentoToolStripMenuItem.Text = "Fichamento";
            // 
            // verificarFichamentoToolStripMenuItem
            // 
            this.verificarFichamentoToolStripMenuItem.Name = "verificarFichamentoToolStripMenuItem";
            this.verificarFichamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verificarFichamentoToolStripMenuItem.Text = "Verificar Fichamento";
            this.verificarFichamentoToolStripMenuItem.Click += new System.EventHandler(this.verificarFichamentoToolStripMenuItem_Click);
            // 
            // cadastrarFichamentoToolStripMenuItem
            // 
            this.cadastrarFichamentoToolStripMenuItem.Name = "cadastrarFichamentoToolStripMenuItem";
            this.cadastrarFichamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarFichamentoToolStripMenuItem.Text = "Cadastrar Fichamento";
            this.cadastrarFichamentoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFichamentoToolStripMenuItem_Click);
            // 
            // obraToolStripMenuItem
            // 
            this.obraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarObraToolStripMenuItem,
            this.cadastrarObraToolStripMenuItem});
            this.obraToolStripMenuItem.Name = "obraToolStripMenuItem";
            this.obraToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.obraToolStripMenuItem.Text = "Obra";
            // 
            // verificarObraToolStripMenuItem
            // 
            this.verificarObraToolStripMenuItem.Name = "verificarObraToolStripMenuItem";
            this.verificarObraToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.verificarObraToolStripMenuItem.Text = "Verificar Obra";
            this.verificarObraToolStripMenuItem.Click += new System.EventHandler(this.verificarObraToolStripMenuItem_Click);
            // 
            // cadastrarObraToolStripMenuItem
            // 
            this.cadastrarObraToolStripMenuItem.Name = "cadastrarObraToolStripMenuItem";
            this.cadastrarObraToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.cadastrarObraToolStripMenuItem.Text = "Cadastrar Obra";
            this.cadastrarObraToolStripMenuItem.Click += new System.EventHandler(this.cadastrarObraToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarAutorToolStripMenuItem,
            this.cadastrarAutorToolStripMenuItem});
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.autorToolStripMenuItem.Text = "Autor";
            // 
            // verificarAutorToolStripMenuItem
            // 
            this.verificarAutorToolStripMenuItem.Name = "verificarAutorToolStripMenuItem";
            this.verificarAutorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.verificarAutorToolStripMenuItem.Text = "Verificar autor";
            this.verificarAutorToolStripMenuItem.Click += new System.EventHandler(this.verificarAutorToolStripMenuItem_Click);
            // 
            // cadastrarAutorToolStripMenuItem
            // 
            this.cadastrarAutorToolStripMenuItem.Name = "cadastrarAutorToolStripMenuItem";
            this.cadastrarAutorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadastrarAutorToolStripMenuItem.Text = "Cadastrar Autor";
            this.cadastrarAutorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAutorToolStripMenuItem_Click);
            // 
            // outrosToolStripMenuItem
            // 
            this.outrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarModalidadeToolStripMenuItem,
            this.verificarNaturezaToolStripMenuItem,
            this.verificarFormaDeEstudoToolStripMenuItem,
            this.verificarObjetoToolStripMenuItem});
            this.outrosToolStripMenuItem.Name = "outrosToolStripMenuItem";
            this.outrosToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.outrosToolStripMenuItem.Text = "Outros";
            // 
            // verificarModalidadeToolStripMenuItem
            // 
            this.verificarModalidadeToolStripMenuItem.Name = "verificarModalidadeToolStripMenuItem";
            this.verificarModalidadeToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.verificarModalidadeToolStripMenuItem.Text = "Verificar Modalidade";
            this.verificarModalidadeToolStripMenuItem.Click += new System.EventHandler(this.verificarModalidadeToolStripMenuItem_Click);
            // 
            // verificarNaturezaToolStripMenuItem
            // 
            this.verificarNaturezaToolStripMenuItem.Name = "verificarNaturezaToolStripMenuItem";
            this.verificarNaturezaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.verificarNaturezaToolStripMenuItem.Text = "Verificar Natureza";
            this.verificarNaturezaToolStripMenuItem.Click += new System.EventHandler(this.verificarNaturezaToolStripMenuItem_Click);
            // 
            // verificarFormaDeEstudoToolStripMenuItem
            // 
            this.verificarFormaDeEstudoToolStripMenuItem.Name = "verificarFormaDeEstudoToolStripMenuItem";
            this.verificarFormaDeEstudoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.verificarFormaDeEstudoToolStripMenuItem.Text = "Verificar Forma de Estudo";
            this.verificarFormaDeEstudoToolStripMenuItem.Click += new System.EventHandler(this.verificarFormaDeEstudoToolStripMenuItem_Click);
            // 
            // verificarObjetoToolStripMenuItem
            // 
            this.verificarObjetoToolStripMenuItem.Name = "verificarObjetoToolStripMenuItem";
            this.verificarObjetoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.verificarObjetoToolStripMenuItem.Text = "Verificar Objeto";
            this.verificarObjetoToolStripMenuItem.Click += new System.EventHandler(this.verificarObjetoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // labelObra
            // 
            this.labelObra.AutoSize = true;
            this.labelObra.Location = new System.Drawing.Point(29, 89);
            this.labelObra.Name = "labelObra";
            this.labelObra.Size = new System.Drawing.Size(37, 13);
            this.labelObra.TabIndex = 35;
            this.labelObra.Text = "Obra *";
            // 
            // labelPagina
            // 
            this.labelPagina.AutoSize = true;
            this.labelPagina.Location = new System.Drawing.Point(32, 136);
            this.labelPagina.Name = "labelPagina";
            this.labelPagina.Size = new System.Drawing.Size(47, 13);
            this.labelPagina.TabIndex = 36;
            this.labelPagina.Text = "Página *";
            // 
            // labelDe
            // 
            this.labelDe.AutoSize = true;
            this.labelDe.Location = new System.Drawing.Point(104, 165);
            this.labelDe.Name = "labelDe";
            this.labelDe.Size = new System.Drawing.Size(19, 13);
            this.labelDe.TabIndex = 37;
            this.labelDe.Text = "de";
            // 
            // textBoxObra
            // 
            this.textBoxObra.Location = new System.Drawing.Point(32, 106);
            this.textBoxObra.Name = "textBoxObra";
            this.textBoxObra.Size = new System.Drawing.Size(507, 20);
            this.textBoxObra.TabIndex = 38;
            // 
            // textBoxPaginaDe
            // 
            this.textBoxPaginaDe.Location = new System.Drawing.Point(35, 162);
            this.textBoxPaginaDe.Name = "textBoxPaginaDe";
            this.textBoxPaginaDe.Size = new System.Drawing.Size(47, 20);
            this.textBoxPaginaDe.TabIndex = 39;
            this.toolTip1.SetToolTip(this.textBoxPaginaDe, "Informe Apenas Campos Numéricos");
            this.textBoxPaginaDe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPaginaDe_KeyPress);
            // 
            // textBoxAte
            // 
            this.textBoxAte.Location = new System.Drawing.Point(137, 162);
            this.textBoxAte.Name = "textBoxAte";
            this.textBoxAte.Size = new System.Drawing.Size(47, 20);
            this.textBoxAte.TabIndex = 40;
            this.toolTip1.SetToolTip(this.textBoxAte, "Informe Apenas campos numéricos");
            this.textBoxAte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAte_KeyPress);
            // 
            // frmCadastrarCapitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.textBoxAte);
            this.Controls.Add(this.textBoxPaginaDe);
            this.Controls.Add(this.textBoxObra);
            this.Controls.Add(this.labelDe);
            this.Controls.Add(this.labelPagina);
            this.Controls.Add(this.labelObra);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCnfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmCadastrarCapitulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Capitulo de Livro";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCnfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarProjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarFichamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFichamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarObraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarObraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarModalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarNaturezaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarFormaDeEstudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarObjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label labelObra;
        private System.Windows.Forms.Label labelPagina;
        private System.Windows.Forms.Label labelDe;
        private System.Windows.Forms.TextBox textBoxObra;
        private System.Windows.Forms.TextBox textBoxPaginaDe;
        private System.Windows.Forms.TextBox textBoxAte;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
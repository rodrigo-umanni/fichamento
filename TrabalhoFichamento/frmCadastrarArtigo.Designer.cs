namespace TrabalhoFichamento
{
    partial class frmCadastrarArtigo
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPeriodico = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelPagina = new System.Windows.Forms.Label();
            this.labelISSN = new System.Windows.Forms.Label();
            this.labelDe = new System.Windows.Forms.Label();
            this.textBoxPeriodico = new System.Windows.Forms.TextBox();
            this.textBoxVolume = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxPaginaDe = new System.Windows.Forms.TextBox();
            this.textBoxPaginaAte = new System.Windows.Forms.TextBox();
            this.textBoxISSN = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCnfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // projetoToolStripMenuItem
            // 
            this.projetoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarProjetoToolStripMenuItem,
            this.cadastrarProjetoToolStripMenuItem});
            this.projetoToolStripMenuItem.Name = "projetoToolStripMenuItem";
            this.projetoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.projetoToolStripMenuItem.Text = "Projeto";
            // 
            // verificarProjetoToolStripMenuItem
            // 
            this.verificarProjetoToolStripMenuItem.Name = "verificarProjetoToolStripMenuItem";
            this.verificarProjetoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.verificarProjetoToolStripMenuItem.Text = "Verificar Projeto";
            this.verificarProjetoToolStripMenuItem.Click += new System.EventHandler(this.verificarProjetoToolStripMenuItem_Click);
            // 
            // cadastrarProjetoToolStripMenuItem
            // 
            this.cadastrarProjetoToolStripMenuItem.Name = "cadastrarProjetoToolStripMenuItem";
            this.cadastrarProjetoToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cadastrarProjetoToolStripMenuItem.Text = "Cadastrar Projeto";
            this.cadastrarProjetoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProjetoToolStripMenuItem_Click);
            // 
            // fichamentoToolStripMenuItem
            // 
            this.fichamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarFichamentoToolStripMenuItem,
            this.cadastrarFichamentoToolStripMenuItem});
            this.fichamentoToolStripMenuItem.Name = "fichamentoToolStripMenuItem";
            this.fichamentoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.fichamentoToolStripMenuItem.Text = "Fichamento";
            // 
            // verificarFichamentoToolStripMenuItem
            // 
            this.verificarFichamentoToolStripMenuItem.Name = "verificarFichamentoToolStripMenuItem";
            this.verificarFichamentoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.verificarFichamentoToolStripMenuItem.Text = "Verificar Fichamento";
            this.verificarFichamentoToolStripMenuItem.Click += new System.EventHandler(this.verificarFichamentoToolStripMenuItem_Click);
            // 
            // cadastrarFichamentoToolStripMenuItem
            // 
            this.cadastrarFichamentoToolStripMenuItem.Name = "cadastrarFichamentoToolStripMenuItem";
            this.cadastrarFichamentoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cadastrarFichamentoToolStripMenuItem.Text = "Cadastrar Fichamento";
            this.cadastrarFichamentoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFichamentoToolStripMenuItem_Click);
            // 
            // obraToolStripMenuItem
            // 
            this.obraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarObraToolStripMenuItem,
            this.cadastrarObraToolStripMenuItem});
            this.obraToolStripMenuItem.Name = "obraToolStripMenuItem";
            this.obraToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.obraToolStripMenuItem.Text = "Obra";
            // 
            // verificarObraToolStripMenuItem
            // 
            this.verificarObraToolStripMenuItem.Name = "verificarObraToolStripMenuItem";
            this.verificarObraToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.verificarObraToolStripMenuItem.Text = "Verificar Obra";
            this.verificarObraToolStripMenuItem.Click += new System.EventHandler(this.verificarObraToolStripMenuItem_Click);
            // 
            // cadastrarObraToolStripMenuItem
            // 
            this.cadastrarObraToolStripMenuItem.Name = "cadastrarObraToolStripMenuItem";
            this.cadastrarObraToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.cadastrarObraToolStripMenuItem.Text = "Cadastrar Obra";
            this.cadastrarObraToolStripMenuItem.Click += new System.EventHandler(this.cadastrarObraToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarAutorToolStripMenuItem,
            this.cadastrarAutorToolStripMenuItem});
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.autorToolStripMenuItem.Text = "Autor";
            // 
            // verificarAutorToolStripMenuItem
            // 
            this.verificarAutorToolStripMenuItem.Name = "verificarAutorToolStripMenuItem";
            this.verificarAutorToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.verificarAutorToolStripMenuItem.Text = "Verificar autor";
            this.verificarAutorToolStripMenuItem.Click += new System.EventHandler(this.verificarAutorToolStripMenuItem_Click);
            // 
            // cadastrarAutorToolStripMenuItem
            // 
            this.cadastrarAutorToolStripMenuItem.Name = "cadastrarAutorToolStripMenuItem";
            this.cadastrarAutorToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
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
            this.outrosToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.outrosToolStripMenuItem.Text = "Outros";
            // 
            // verificarModalidadeToolStripMenuItem
            // 
            this.verificarModalidadeToolStripMenuItem.Name = "verificarModalidadeToolStripMenuItem";
            this.verificarModalidadeToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.verificarModalidadeToolStripMenuItem.Text = "Verificar Modalidade";
            this.verificarModalidadeToolStripMenuItem.Click += new System.EventHandler(this.verificarModalidadeToolStripMenuItem_Click);
            // 
            // verificarNaturezaToolStripMenuItem
            // 
            this.verificarNaturezaToolStripMenuItem.Name = "verificarNaturezaToolStripMenuItem";
            this.verificarNaturezaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.verificarNaturezaToolStripMenuItem.Text = "Verificar Natureza";
            this.verificarNaturezaToolStripMenuItem.Click += new System.EventHandler(this.verificarNaturezaToolStripMenuItem_Click);
            // 
            // verificarFormaDeEstudoToolStripMenuItem
            // 
            this.verificarFormaDeEstudoToolStripMenuItem.Name = "verificarFormaDeEstudoToolStripMenuItem";
            this.verificarFormaDeEstudoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.verificarFormaDeEstudoToolStripMenuItem.Text = "Verificar Forma de Estudo";
            this.verificarFormaDeEstudoToolStripMenuItem.Click += new System.EventHandler(this.verificarFormaDeEstudoToolStripMenuItem_Click);
            // 
            // verificarObjetoToolStripMenuItem
            // 
            this.verificarObjetoToolStripMenuItem.Name = "verificarObjetoToolStripMenuItem";
            this.verificarObjetoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.verificarObjetoToolStripMenuItem.Text = "Verificar Objeto";
            this.verificarObjetoToolStripMenuItem.Click += new System.EventHandler(this.verificarObjetoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(826, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel1.Text = "Cadastrar Artigo";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.ForeColor = System.Drawing.Color.Red;
            this.labelInfo.Location = new System.Drawing.Point(29, 316);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(111, 13);
            this.labelInfo.TabIndex = 27;
            this.labelInfo.Text = "* Campos Obrigatórios";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(25, 50);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(159, 24);
            this.labelTitle.TabIndex = 26;
            this.labelTitle.Text = "Cadastrar Artigo";
            // 
            // labelPeriodico
            // 
            this.labelPeriodico.AutoSize = true;
            this.labelPeriodico.Location = new System.Drawing.Point(29, 89);
            this.labelPeriodico.Name = "labelPeriodico";
            this.labelPeriodico.Size = new System.Drawing.Size(145, 13);
            this.labelPeriodico.TabIndex = 28;
            this.labelPeriodico.Text = "Nome do Períodico/Evento *";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(29, 133);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(42, 13);
            this.labelVolume.TabIndex = 29;
            this.labelVolume.Text = "Volume";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(163, 133);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(44, 13);
            this.labelNumero.TabIndex = 30;
            this.labelNumero.Text = "Número";
            // 
            // labelPagina
            // 
            this.labelPagina.AutoSize = true;
            this.labelPagina.Location = new System.Drawing.Point(29, 184);
            this.labelPagina.Name = "labelPagina";
            this.labelPagina.Size = new System.Drawing.Size(40, 13);
            this.labelPagina.TabIndex = 31;
            this.labelPagina.Text = "Página";
            // 
            // labelISSN
            // 
            this.labelISSN.AutoSize = true;
            this.labelISSN.Location = new System.Drawing.Point(29, 240);
            this.labelISSN.Name = "labelISSN";
            this.labelISSN.Size = new System.Drawing.Size(62, 13);
            this.labelISSN.TabIndex = 32;
            this.labelISSN.Text = "ISSN/ISBN";
            // 
            // labelDe
            // 
            this.labelDe.AutoSize = true;
            this.labelDe.Location = new System.Drawing.Point(89, 203);
            this.labelDe.Name = "labelDe";
            this.labelDe.Size = new System.Drawing.Size(19, 13);
            this.labelDe.TabIndex = 33;
            this.labelDe.Text = "de";
            // 
            // textBoxPeriodico
            // 
            this.textBoxPeriodico.Location = new System.Drawing.Point(32, 106);
            this.textBoxPeriodico.Name = "textBoxPeriodico";
            this.textBoxPeriodico.Size = new System.Drawing.Size(552, 20);
            this.textBoxPeriodico.TabIndex = 34;
            // 
            // textBoxVolume
            // 
            this.textBoxVolume.Location = new System.Drawing.Point(32, 150);
            this.textBoxVolume.Name = "textBoxVolume";
            this.textBoxVolume.Size = new System.Drawing.Size(100, 20);
            this.textBoxVolume.TabIndex = 35;
            this.toolTip1.SetToolTip(this.textBoxVolume, "Informe caracteres numéricos");
            this.textBoxVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVolume_KeyPress);
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(166, 150);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumero.TabIndex = 36;
            this.toolTip1.SetToolTip(this.textBoxNumero, "Informe apenas caracteres numéricos");
            this.textBoxNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumero_KeyPress);
            // 
            // textBoxPaginaDe
            // 
            this.textBoxPaginaDe.Location = new System.Drawing.Point(32, 200);
            this.textBoxPaginaDe.Name = "textBoxPaginaDe";
            this.textBoxPaginaDe.Size = new System.Drawing.Size(42, 20);
            this.textBoxPaginaDe.TabIndex = 37;
            this.toolTip1.SetToolTip(this.textBoxPaginaDe, "Informe apenas caracteres numéricos");
            this.textBoxPaginaDe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPaginaDe_KeyPress);
            // 
            // textBoxPaginaAte
            // 
            this.textBoxPaginaAte.Location = new System.Drawing.Point(125, 200);
            this.textBoxPaginaAte.Name = "textBoxPaginaAte";
            this.textBoxPaginaAte.Size = new System.Drawing.Size(42, 20);
            this.textBoxPaginaAte.TabIndex = 38;
            this.toolTip1.SetToolTip(this.textBoxPaginaAte, "Informe apenas caracteres numéricos");
            this.textBoxPaginaAte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPaginaAte_KeyPress);
            // 
            // textBoxISSN
            // 
            this.textBoxISSN.Location = new System.Drawing.Point(32, 256);
            this.textBoxISSN.Name = "textBoxISSN";
            this.textBoxISSN.Size = new System.Drawing.Size(175, 20);
            this.textBoxISSN.TabIndex = 39;
            this.toolTip1.SetToolTip(this.textBoxISSN, "Informe apenas caracteres numéricos");
            this.textBoxISSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxISSN_KeyPress);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.Image = global::TrabalhoFichamento.Properties.Resources.limpar;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(405, 383);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(158, 53);
            this.btnLimpar.TabIndex = 25;
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
            this.btnCnfirmar.TabIndex = 24;
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
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCadastrarArtigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.textBoxISSN);
            this.Controls.Add(this.textBoxPaginaAte);
            this.Controls.Add(this.textBoxPaginaDe);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.textBoxVolume);
            this.Controls.Add(this.textBoxPeriodico);
            this.Controls.Add(this.labelDe);
            this.Controls.Add(this.labelISSN);
            this.Controls.Add(this.labelPagina);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelPeriodico);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCnfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmCadastrarArtigo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Artigo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCnfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelPeriodico;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelPagina;
        private System.Windows.Forms.Label labelISSN;
        private System.Windows.Forms.Label labelDe;
        private System.Windows.Forms.TextBox textBoxPeriodico;
        private System.Windows.Forms.TextBox textBoxVolume;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxPaginaDe;
        private System.Windows.Forms.TextBox textBoxPaginaAte;
        private System.Windows.Forms.TextBox textBoxISSN;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
namespace TrabalhoFichamento
{
    partial class frmCadastrarProjeto
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textData = new System.Windows.Forms.TextBox();
            this.textNomeProjeto = new System.Windows.Forms.TextBox();
            this.labelDataDeAbertura = new System.Windows.Forms.Label();
            this.labelNomeProjeto = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCnfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.verficarObraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarObraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarModalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarNeturezaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarFormaDeEstudoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarObjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(25, 50);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(170, 24);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Cadastrar Projeto";
            // 
            // textData
            // 
            this.textData.Enabled = false;
            this.textData.Location = new System.Drawing.Point(29, 165);
            this.textData.Name = "textData";
            this.textData.Size = new System.Drawing.Size(100, 20);
            this.textData.TabIndex = 13;
            // 
            // textNomeProjeto
            // 
            this.textNomeProjeto.Location = new System.Drawing.Point(29, 108);
            this.textNomeProjeto.Name = "textNomeProjeto";
            this.textNomeProjeto.Size = new System.Drawing.Size(448, 20);
            this.textNomeProjeto.TabIndex = 12;
            // 
            // labelDataDeAbertura
            // 
            this.labelDataDeAbertura.AutoSize = true;
            this.labelDataDeAbertura.Location = new System.Drawing.Point(28, 149);
            this.labelDataDeAbertura.Name = "labelDataDeAbertura";
            this.labelDataDeAbertura.Size = new System.Drawing.Size(88, 13);
            this.labelDataDeAbertura.TabIndex = 11;
            this.labelDataDeAbertura.Text = "Data de Abertura";
            // 
            // labelNomeProjeto
            // 
            this.labelNomeProjeto.AutoSize = true;
            this.labelNomeProjeto.Location = new System.Drawing.Point(28, 92);
            this.labelNomeProjeto.Name = "labelNomeProjeto";
            this.labelNomeProjeto.Size = new System.Drawing.Size(92, 13);
            this.labelNomeProjeto.TabIndex = 10;
            this.labelNomeProjeto.Text = "Nome do projeto *";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.ForeColor = System.Drawing.Color.Red;
            this.labelInfo.Location = new System.Drawing.Point(26, 204);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(111, 13);
            this.labelInfo.TabIndex = 15;
            this.labelInfo.Text = "* Campos Obrigatórios";
            // 
            // btnCnfirmar
            // 
            this.btnCnfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCnfirmar.Image = global::TrabalhoFichamento.Properties.Resources.confirmar;
            this.btnCnfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCnfirmar.Location = new System.Drawing.Point(548, 362);
            this.btnCnfirmar.Name = "btnCnfirmar";
            this.btnCnfirmar.Size = new System.Drawing.Size(158, 53);
            this.btnCnfirmar.TabIndex = 17;
            this.btnCnfirmar.Text = "Confirmar";
            this.toolTip1.SetToolTip(this.btnCnfirmar, "Confirmar");
            this.btnCnfirmar.UseVisualStyleBackColor = true;
            this.btnCnfirmar.Click += new System.EventHandler(this.btnCnfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = global::TrabalhoFichamento.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(355, 362);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(158, 53);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabalhoFichamento.Properties.Resources.limpar;
            this.pictureBox1.Location = new System.Drawing.Point(483, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 13);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Limpar Campo");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(826, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel1.Text = "Cadastrar Projeto";
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
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.verificarProjetoToolStripMenuItem.Click += new System.EventHandler(this.verificarProjetoToolStripMenuItem_Click_1);
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
            this.verificarFichamentoToolStripMenuItem.Click += new System.EventHandler(this.verificarFichamentoToolStripMenuItem_Click_1);
            // 
            // cadastrarFichamentoToolStripMenuItem
            // 
            this.cadastrarFichamentoToolStripMenuItem.Name = "cadastrarFichamentoToolStripMenuItem";
            this.cadastrarFichamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarFichamentoToolStripMenuItem.Text = "Cadastrar Fichamento";
            this.cadastrarFichamentoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFichamentoToolStripMenuItem_Click_1);
            // 
            // obraToolStripMenuItem
            // 
            this.obraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verficarObraToolStripMenuItem,
            this.cadastrarObraToolStripMenuItem});
            this.obraToolStripMenuItem.Name = "obraToolStripMenuItem";
            this.obraToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.obraToolStripMenuItem.Text = "Obra";
            // 
            // verficarObraToolStripMenuItem
            // 
            this.verficarObraToolStripMenuItem.Name = "verficarObraToolStripMenuItem";
            this.verficarObraToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.verficarObraToolStripMenuItem.Text = "Verificar Obra";
            this.verficarObraToolStripMenuItem.Click += new System.EventHandler(this.verficarObraToolStripMenuItem_Click_1);
            // 
            // cadastrarObraToolStripMenuItem
            // 
            this.cadastrarObraToolStripMenuItem.Name = "cadastrarObraToolStripMenuItem";
            this.cadastrarObraToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.cadastrarObraToolStripMenuItem.Text = "Cadastrar Obra";
            this.cadastrarObraToolStripMenuItem.Click += new System.EventHandler(this.cadastrarObraToolStripMenuItem_Click_1);
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
            this.verificarAutorToolStripMenuItem.Click += new System.EventHandler(this.verificarAutorToolStripMenuItem_Click_1);
            // 
            // cadastrarAutorToolStripMenuItem
            // 
            this.cadastrarAutorToolStripMenuItem.Name = "cadastrarAutorToolStripMenuItem";
            this.cadastrarAutorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadastrarAutorToolStripMenuItem.Text = "Cadastrar Autor";
            this.cadastrarAutorToolStripMenuItem.Click += new System.EventHandler(this.cadastrarAutorToolStripMenuItem_Click_1);
            // 
            // outrosToolStripMenuItem
            // 
            this.outrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarModalidadeToolStripMenuItem,
            this.verificarNeturezaToolStripMenuItem,
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
            this.verificarModalidadeToolStripMenuItem.Click += new System.EventHandler(this.verificarModalidadeToolStripMenuItem_Click_1);
            // 
            // verificarNeturezaToolStripMenuItem
            // 
            this.verificarNeturezaToolStripMenuItem.Name = "verificarNeturezaToolStripMenuItem";
            this.verificarNeturezaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.verificarNeturezaToolStripMenuItem.Text = "Verificar Natureza";
            this.verificarNeturezaToolStripMenuItem.Click += new System.EventHandler(this.verificarNeturezaToolStripMenuItem_Click_1);
            // 
            // verificarFormaDeEstudoToolStripMenuItem
            // 
            this.verificarFormaDeEstudoToolStripMenuItem.Name = "verificarFormaDeEstudoToolStripMenuItem";
            this.verificarFormaDeEstudoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.verificarFormaDeEstudoToolStripMenuItem.Text = "Verificar Forma de Estudo";
            this.verificarFormaDeEstudoToolStripMenuItem.Click += new System.EventHandler(this.verificarFormaDeEstudoToolStripMenuItem_Click_1);
            // 
            // verificarObjetoToolStripMenuItem
            // 
            this.verificarObjetoToolStripMenuItem.Name = "verificarObjetoToolStripMenuItem";
            this.verificarObjetoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.verificarObjetoToolStripMenuItem.Text = "Verificar Objeto";
            this.verificarObjetoToolStripMenuItem.Click += new System.EventHandler(this.verificarObjetoToolStripMenuItem_Click_1);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // frmCadastrarProjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCnfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textData);
            this.Controls.Add(this.textNomeProjeto);
            this.Controls.Add(this.labelDataDeAbertura);
            this.Controls.Add(this.labelNomeProjeto);
            this.Controls.Add(this.labelTitle);
            this.Name = "frmCadastrarProjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Projeto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.TextBox textNomeProjeto;
        private System.Windows.Forms.Label labelDataDeAbertura;
        private System.Windows.Forms.Label labelNomeProjeto;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCnfirmar;
        private System.Windows.Forms.ToolTip toolTip1;
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
        private System.Windows.Forms.ToolStripMenuItem verficarObraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarObraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarModalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarNeturezaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarFormaDeEstudoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarObjetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;

    }
}
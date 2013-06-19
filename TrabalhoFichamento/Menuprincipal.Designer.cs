namespace TrabalhoFichamento
{
    partial class frmMenuPrincipal
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAutor = new System.Windows.Forms.Button();
            this.btnObra = new System.Windows.Forms.Button();
            this.btnFichamento = new System.Windows.Forms.Button();
            this.btnProjeto = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(642, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
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
            this.verificarObraToolStripMenuItem.Click += new System.EventHandler(this.verificarObraToolStripMenuItem_Click_1);
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
            this.verificarNaturezaToolStripMenuItem.Click += new System.EventHandler(this.verificarNaturezaToolStripMenuItem_Click_1);
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 285);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(642, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(184, 17);
            this.toolStripStatusLabel1.Text = "Bem Vindo ao Sistema de Fichamento";
            // 
            // btnAutor
            // 
            this.btnAutor.Image = global::TrabalhoFichamento.Properties.Resources.autor;
            this.btnAutor.Location = new System.Drawing.Point(437, 93);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Size = new System.Drawing.Size(75, 72);
            this.btnAutor.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnAutor, "Autor");
            this.btnAutor.UseVisualStyleBackColor = true;
            this.btnAutor.Click += new System.EventHandler(this.btnAutor_Click);
            // 
            // btnObra
            // 
            this.btnObra.Image = global::TrabalhoFichamento.Properties.Resources.obra;
            this.btnObra.Location = new System.Drawing.Point(310, 93);
            this.btnObra.Name = "btnObra";
            this.btnObra.Size = new System.Drawing.Size(75, 72);
            this.btnObra.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnObra, "Obra");
            this.btnObra.UseVisualStyleBackColor = true;
            this.btnObra.Click += new System.EventHandler(this.btnObra_Click);
            // 
            // btnFichamento
            // 
            this.btnFichamento.Image = global::TrabalhoFichamento.Properties.Resources.fichamento;
            this.btnFichamento.Location = new System.Drawing.Point(190, 93);
            this.btnFichamento.Name = "btnFichamento";
            this.btnFichamento.Size = new System.Drawing.Size(75, 72);
            this.btnFichamento.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnFichamento, "Fichamento");
            this.btnFichamento.UseVisualStyleBackColor = true;
            this.btnFichamento.Click += new System.EventHandler(this.btnFichamento_Click);
            // 
            // btnProjeto
            // 
            this.btnProjeto.Image = global::TrabalhoFichamento.Properties.Resources.projeto;
            this.btnProjeto.Location = new System.Drawing.Point(85, 93);
            this.btnProjeto.Name = "btnProjeto";
            this.btnProjeto.Size = new System.Drawing.Size(75, 72);
            this.btnProjeto.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnProjeto, "Projeto");
            this.btnProjeto.UseVisualStyleBackColor = true;
            this.btnProjeto.Click += new System.EventHandler(this.btnProjeto_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 307);
            this.Controls.Add(this.btnAutor);
            this.Controls.Add(this.btnObra);
            this.Controls.Add(this.btnFichamento);
            this.Controls.Add(this.btnProjeto);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnProjeto;
        private System.Windows.Forms.Button btnFichamento;
        private System.Windows.Forms.Button btnObra;
        private System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
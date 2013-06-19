namespace TrabalhoFichamento
{
    partial class frmVerificarAutor
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.projetoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarProjetoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProjetoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fichamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarFichamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFichamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.obraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarObraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarObraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarAutorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarAutorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.outrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarModalidadeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarNaturezaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarFormaDeEstudoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarObjetoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSobrenome = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.comboBoxSobrenome = new System.Windows.Forms.ComboBox();
            this.comboBoxNome = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.fICHAMENTODataSet = new TrabalhoFichamento.FICHAMENTODataSet();
            this.autordeobraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autor_de_obraTableAdapter = new TrabalhoFichamento.FICHAMENTODataSetTableAdapters.Autor_de_obraTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobrenome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fICHAMENTODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autordeobraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(826, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel1.Text = "Verificar Autor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem1,
            this.projetoToolStripMenuItem1,
            this.fichamentoToolStripMenuItem1,
            this.obraToolStripMenuItem1,
            this.autorToolStripMenuItem1,
            this.outrosToolStripMenuItem1,
            this.sairToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem1
            // 
            this.menuPrincipalToolStripMenuItem1.Name = "menuPrincipalToolStripMenuItem1";
            this.menuPrincipalToolStripMenuItem1.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem1.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem1.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem1_Click);
            // 
            // projetoToolStripMenuItem1
            // 
            this.projetoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarProjetoToolStripMenuItem1,
            this.cadastrarProjetoToolStripMenuItem1});
            this.projetoToolStripMenuItem1.Name = "projetoToolStripMenuItem1";
            this.projetoToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.projetoToolStripMenuItem1.Text = "Projeto";
            // 
            // verificarProjetoToolStripMenuItem1
            // 
            this.verificarProjetoToolStripMenuItem1.Name = "verificarProjetoToolStripMenuItem1";
            this.verificarProjetoToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.verificarProjetoToolStripMenuItem1.Text = "Verificar Projeto";
            this.verificarProjetoToolStripMenuItem1.Click += new System.EventHandler(this.verificarProjetoToolStripMenuItem1_Click);
            // 
            // cadastrarProjetoToolStripMenuItem1
            // 
            this.cadastrarProjetoToolStripMenuItem1.Name = "cadastrarProjetoToolStripMenuItem1";
            this.cadastrarProjetoToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.cadastrarProjetoToolStripMenuItem1.Text = "Cadastrar Projeto";
            this.cadastrarProjetoToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarProjetoToolStripMenuItem1_Click);
            // 
            // fichamentoToolStripMenuItem1
            // 
            this.fichamentoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarFichamentoToolStripMenuItem1,
            this.cadastrarFichamentoToolStripMenuItem1});
            this.fichamentoToolStripMenuItem1.Name = "fichamentoToolStripMenuItem1";
            this.fichamentoToolStripMenuItem1.Size = new System.Drawing.Size(82, 20);
            this.fichamentoToolStripMenuItem1.Text = "Fichamento";
            // 
            // verificarFichamentoToolStripMenuItem1
            // 
            this.verificarFichamentoToolStripMenuItem1.Name = "verificarFichamentoToolStripMenuItem1";
            this.verificarFichamentoToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.verificarFichamentoToolStripMenuItem1.Text = "Verificar Fichamento";
            this.verificarFichamentoToolStripMenuItem1.Click += new System.EventHandler(this.verificarFichamentoToolStripMenuItem1_Click);
            // 
            // cadastrarFichamentoToolStripMenuItem1
            // 
            this.cadastrarFichamentoToolStripMenuItem1.Name = "cadastrarFichamentoToolStripMenuItem1";
            this.cadastrarFichamentoToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.cadastrarFichamentoToolStripMenuItem1.Text = "Cadastrar Fichamento";
            this.cadastrarFichamentoToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarFichamentoToolStripMenuItem1_Click);
            // 
            // obraToolStripMenuItem1
            // 
            this.obraToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarObraToolStripMenuItem1,
            this.cadastrarObraToolStripMenuItem1});
            this.obraToolStripMenuItem1.Name = "obraToolStripMenuItem1";
            this.obraToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.obraToolStripMenuItem1.Text = "Obra ";
            // 
            // verificarObraToolStripMenuItem1
            // 
            this.verificarObraToolStripMenuItem1.Name = "verificarObraToolStripMenuItem1";
            this.verificarObraToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.verificarObraToolStripMenuItem1.Text = "Verificar Obra";
            this.verificarObraToolStripMenuItem1.Click += new System.EventHandler(this.verificarObraToolStripMenuItem1_Click);
            // 
            // cadastrarObraToolStripMenuItem1
            // 
            this.cadastrarObraToolStripMenuItem1.Name = "cadastrarObraToolStripMenuItem1";
            this.cadastrarObraToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.cadastrarObraToolStripMenuItem1.Text = "Cadastrar Obra";
            this.cadastrarObraToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarObraToolStripMenuItem1_Click);
            // 
            // autorToolStripMenuItem1
            // 
            this.autorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarAutorToolStripMenuItem1,
            this.cadastrarAutorToolStripMenuItem1});
            this.autorToolStripMenuItem1.Name = "autorToolStripMenuItem1";
            this.autorToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.autorToolStripMenuItem1.Text = "Autor";
            // 
            // verificarAutorToolStripMenuItem1
            // 
            this.verificarAutorToolStripMenuItem1.Name = "verificarAutorToolStripMenuItem1";
            this.verificarAutorToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.verificarAutorToolStripMenuItem1.Text = "Verificar Autor";
            this.verificarAutorToolStripMenuItem1.Click += new System.EventHandler(this.verificarAutorToolStripMenuItem1_Click);
            // 
            // cadastrarAutorToolStripMenuItem1
            // 
            this.cadastrarAutorToolStripMenuItem1.Name = "cadastrarAutorToolStripMenuItem1";
            this.cadastrarAutorToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.cadastrarAutorToolStripMenuItem1.Text = "Cadastrar Autor";
            this.cadastrarAutorToolStripMenuItem1.Click += new System.EventHandler(this.cadastrarAutorToolStripMenuItem1_Click);
            // 
            // outrosToolStripMenuItem1
            // 
            this.outrosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarModalidadeToolStripMenuItem1,
            this.verificarNaturezaToolStripMenuItem1,
            this.verificarFormaDeEstudoToolStripMenuItem1,
            this.verificarObjetoToolStripMenuItem1});
            this.outrosToolStripMenuItem1.Name = "outrosToolStripMenuItem1";
            this.outrosToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.outrosToolStripMenuItem1.Text = "Outros";
            // 
            // verificarModalidadeToolStripMenuItem1
            // 
            this.verificarModalidadeToolStripMenuItem1.Name = "verificarModalidadeToolStripMenuItem1";
            this.verificarModalidadeToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.verificarModalidadeToolStripMenuItem1.Text = "Verificar Modalidade";
            this.verificarModalidadeToolStripMenuItem1.Click += new System.EventHandler(this.verificarModalidadeToolStripMenuItem1_Click);
            // 
            // verificarNaturezaToolStripMenuItem1
            // 
            this.verificarNaturezaToolStripMenuItem1.Name = "verificarNaturezaToolStripMenuItem1";
            this.verificarNaturezaToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.verificarNaturezaToolStripMenuItem1.Text = "Verificar Natureza";
            this.verificarNaturezaToolStripMenuItem1.Click += new System.EventHandler(this.verificarNaturezaToolStripMenuItem1_Click);
            // 
            // verificarFormaDeEstudoToolStripMenuItem1
            // 
            this.verificarFormaDeEstudoToolStripMenuItem1.Name = "verificarFormaDeEstudoToolStripMenuItem1";
            this.verificarFormaDeEstudoToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.verificarFormaDeEstudoToolStripMenuItem1.Text = "Verificar Forma de Estudo";
            this.verificarFormaDeEstudoToolStripMenuItem1.Click += new System.EventHandler(this.verificarFormaDeEstudoToolStripMenuItem1_Click);
            // 
            // verificarObjetoToolStripMenuItem1
            // 
            this.verificarObjetoToolStripMenuItem1.Name = "verificarObjetoToolStripMenuItem1";
            this.verificarObjetoToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.verificarObjetoToolStripMenuItem1.Text = "Verificar Objeto";
            this.verificarObjetoToolStripMenuItem1.Click += new System.EventHandler(this.verificarObjetoToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(25, 50);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(143, 24);
            this.labelTitle.TabIndex = 27;
            this.labelTitle.Text = "Verificar Autor";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(26, 146);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(78, 13);
            this.labelNome.TabIndex = 33;
            this.labelNome.Text = "Nome do Autor";
            // 
            // labelSobrenome
            // 
            this.labelSobrenome.AutoSize = true;
            this.labelSobrenome.Location = new System.Drawing.Point(26, 96);
            this.labelSobrenome.Name = "labelSobrenome";
            this.labelSobrenome.Size = new System.Drawing.Size(107, 13);
            this.labelSobrenome.TabIndex = 31;
            this.labelSobrenome.Text = "Sobrenome do Autor ";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Image = global::TrabalhoFichamento.Properties.Resources.pesquisar;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(596, 124);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(145, 56);
            this.btnPesquisar.TabIndex = 37;
            this.btnPesquisar.Text = "Pesquisar";
            this.toolTip1.SetToolTip(this.btnPesquisar, "PesquisarAutor");
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = global::TrabalhoFichamento.Properties.Resources.cadastro;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(29, 209);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(145, 56);
            this.btnCadastrar.TabIndex = 38;
            this.btnCadastrar.Text = "Cadastrar";
            this.toolTip1.SetToolTip(this.btnCadastrar, "Cadastrar Autor");
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // comboBoxSobrenome
            // 
            this.comboBoxSobrenome.FormattingEnabled = true;
            this.comboBoxSobrenome.Location = new System.Drawing.Point(29, 112);
            this.comboBoxSobrenome.Name = "comboBoxSobrenome";
            this.comboBoxSobrenome.Size = new System.Drawing.Size(477, 21);
            this.comboBoxSobrenome.TabIndex = 39;
            // 
            // comboBoxNome
            // 
            this.comboBoxNome.FormattingEnabled = true;
            this.comboBoxNome.Location = new System.Drawing.Point(29, 162);
            this.comboBoxNome.Name = "comboBoxNome";
            this.comboBoxNome.Size = new System.Drawing.Size(477, 21);
            this.comboBoxNome.TabIndex = 40;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.sobrenome,
            this.nome,
            this.citacao});
            this.dataGridView1.DataSource = this.autordeobraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 150);
            this.dataGridView1.TabIndex = 41;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(659, 454);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(59, 20);
            this.textBoxResultado.TabIndex = 43;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(525, 457);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(128, 13);
            this.labelResultado.TabIndex = 42;
            this.labelResultado.Text = "Resultados encontrados: ";
            // 
            // fICHAMENTODataSet
            // 
            this.fICHAMENTODataSet.DataSetName = "FICHAMENTODataSet";
            this.fICHAMENTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autordeobraBindingSource
            // 
            this.autordeobraBindingSource.DataMember = "Autor_de_obra";
            this.autordeobraBindingSource.DataSource = this.fICHAMENTODataSet;
            // 
            // autor_de_obraTableAdapter
            // 
            this.autor_de_obraTableAdapter.ClearBeforeFill = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id_autor_de_obra";
            this.id.HeaderText = "id_autor_de_obra";
            this.id.Name = "id";
            // 
            // sobrenome
            // 
            this.sobrenome.DataPropertyName = "sobrenome";
            this.sobrenome.HeaderText = "sobrenome";
            this.sobrenome.Name = "sobrenome";
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "nome";
            this.nome.Name = "nome";
            // 
            // citacao
            // 
            this.citacao.DataPropertyName = "citacao";
            this.citacao.HeaderText = "citacao";
            this.citacao.Name = "citacao";
            // 
            // frmVerificarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxNome);
            this.Controls.Add(this.comboBoxSobrenome);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelSobrenome);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmVerificarAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificar Autor";
            this.Load += new System.EventHandler(this.frmVerificarAutor_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fICHAMENTODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autordeobraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem projetoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verificarProjetoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProjetoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fichamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verificarFichamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFichamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem obraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verificarObraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarObraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verificarAutorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarAutorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem outrosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verificarModalidadeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verificarNaturezaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verificarFormaDeEstudoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verificarObjetoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSobrenome;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox comboBoxSobrenome;
        private System.Windows.Forms.ComboBox comboBoxNome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Label labelResultado;
        private FICHAMENTODataSet fICHAMENTODataSet;
        private System.Windows.Forms.BindingSource autordeobraBindingSource;
        private FICHAMENTODataSetTableAdapters.Autor_de_obraTableAdapter autor_de_obraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobrenome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn citacao;
    }
}
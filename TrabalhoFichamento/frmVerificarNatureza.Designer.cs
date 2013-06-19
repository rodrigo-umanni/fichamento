namespace TrabalhoFichamento
{
    partial class frmVerificarNatureza
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.radioButtonDesativo = new System.Windows.Forms.RadioButton();
            this.radioButtonAtivado = new System.Windows.Forms.RadioButton();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirmar2 = new System.Windows.Forms.Button();
            this.btnCancelar2 = new System.Windows.Forms.Button();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.labelCod = new System.Windows.Forms.Label();
            this.radioButtonDesativado2 = new System.Windows.Forms.RadioButton();
            this.radioButtonAtivado2 = new System.Windows.Forms.RadioButton();
            this.labelStatus2 = new System.Windows.Forms.Label();
            this.textBoxDescricao2 = new System.Windows.Forms.TextBox();
            this.labelDescicao2 = new System.Windows.Forms.Label();
            this.labelTitle2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alterar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.naturezaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fICHAMENTODataSet = new TrabalhoFichamento.FICHAMENTODataSet();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.naturezaTableAdapter = new TrabalhoFichamento.FICHAMENTODataSetTableAdapters.NaturezaTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.naturezaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fICHAMENTODataSet)).BeginInit();
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
            this.menuStrip1.TabIndex = 5;
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
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(25, 50);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(176, 24);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Verificar Natureza";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(826, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(51, 17);
            this.toolStripStatusLabel1.Text = "Natureza";
            // 
            // radioButtonDesativo
            // 
            this.radioButtonDesativo.AutoSize = true;
            this.radioButtonDesativo.Location = new System.Drawing.Point(149, 168);
            this.radioButtonDesativo.Name = "radioButtonDesativo";
            this.radioButtonDesativo.Size = new System.Drawing.Size(79, 17);
            this.radioButtonDesativo.TabIndex = 31;
            this.radioButtonDesativo.TabStop = true;
            this.radioButtonDesativo.Text = "Desativado";
            this.radioButtonDesativo.UseVisualStyleBackColor = true;
            // 
            // radioButtonAtivado
            // 
            this.radioButtonAtivado.AutoSize = true;
            this.radioButtonAtivado.Location = new System.Drawing.Point(32, 168);
            this.radioButtonAtivado.Name = "radioButtonAtivado";
            this.radioButtonAtivado.Size = new System.Drawing.Size(61, 17);
            this.radioButtonAtivado.TabIndex = 30;
            this.radioButtonAtivado.TabStop = true;
            this.radioButtonAtivado.Text = "Ativado";
            this.radioButtonAtivado.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(29, 151);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 29;
            this.labelStatus.Text = "Status";
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(29, 113);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(455, 20);
            this.textBoxDescricao.TabIndex = 27;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(26, 96);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(113, 13);
            this.labelDescricao.TabIndex = 26;
            this.labelDescricao.Text = "Descrição daNatureza";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnConfirmar2);
            this.panel1.Controls.Add(this.btnCancelar2);
            this.panel1.Controls.Add(this.textBoxCod);
            this.panel1.Controls.Add(this.labelCod);
            this.panel1.Controls.Add(this.radioButtonDesativado2);
            this.panel1.Controls.Add(this.radioButtonAtivado2);
            this.panel1.Controls.Add(this.labelStatus2);
            this.panel1.Controls.Add(this.textBoxDescricao2);
            this.panel1.Controls.Add(this.labelDescicao2);
            this.panel1.Controls.Add(this.labelTitle2);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 460);
            this.panel1.TabIndex = 32;
            this.panel1.Visible = false;
            // 
            // btnConfirmar2
            // 
            this.btnConfirmar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar2.Image = global::TrabalhoFichamento.Properties.Resources.confirmar;
            this.btnConfirmar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar2.Location = new System.Drawing.Point(626, 367);
            this.btnConfirmar2.Name = "btnConfirmar2";
            this.btnConfirmar2.Size = new System.Drawing.Size(158, 53);
            this.btnConfirmar2.TabIndex = 45;
            this.btnConfirmar2.Text = "Confirmar";
            this.btnConfirmar2.UseVisualStyleBackColor = true;
            this.btnConfirmar2.Visible = false;
            this.btnConfirmar2.Click += new System.EventHandler(this.btnConfirmar2_Click);
            // 
            // btnCancelar2
            // 
            this.btnCancelar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar2.Image = global::TrabalhoFichamento.Properties.Resources.cancelar;
            this.btnCancelar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar2.Location = new System.Drawing.Point(454, 367);
            this.btnCancelar2.Name = "btnCancelar2";
            this.btnCancelar2.Size = new System.Drawing.Size(158, 53);
            this.btnCancelar2.TabIndex = 44;
            this.btnCancelar2.Text = "Cancelar";
            this.btnCancelar2.UseVisualStyleBackColor = true;
            this.btnCancelar2.Visible = false;
            this.btnCancelar2.Click += new System.EventHandler(this.btnCancelar2_Click);
            // 
            // textBoxCod
            // 
            this.textBoxCod.Enabled = false;
            this.textBoxCod.Location = new System.Drawing.Point(73, 102);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(100, 20);
            this.textBoxCod.TabIndex = 43;
            this.textBoxCod.Visible = false;
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(27, 105);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(40, 13);
            this.labelCod.TabIndex = 42;
            this.labelCod.Text = "Código";
            this.labelCod.Visible = false;
            // 
            // radioButtonDesativado2
            // 
            this.radioButtonDesativado2.AutoSize = true;
            this.radioButtonDesativado2.Location = new System.Drawing.Point(150, 206);
            this.radioButtonDesativado2.Name = "radioButtonDesativado2";
            this.radioButtonDesativado2.Size = new System.Drawing.Size(79, 17);
            this.radioButtonDesativado2.TabIndex = 41;
            this.radioButtonDesativado2.TabStop = true;
            this.radioButtonDesativado2.Text = "Desativado";
            this.radioButtonDesativado2.UseVisualStyleBackColor = true;
            this.radioButtonDesativado2.Visible = false;
            // 
            // radioButtonAtivado2
            // 
            this.radioButtonAtivado2.AutoSize = true;
            this.radioButtonAtivado2.Location = new System.Drawing.Point(33, 206);
            this.radioButtonAtivado2.Name = "radioButtonAtivado2";
            this.radioButtonAtivado2.Size = new System.Drawing.Size(61, 17);
            this.radioButtonAtivado2.TabIndex = 40;
            this.radioButtonAtivado2.TabStop = true;
            this.radioButtonAtivado2.Text = "Ativado";
            this.radioButtonAtivado2.UseVisualStyleBackColor = true;
            this.radioButtonAtivado2.Visible = false;
            // 
            // labelStatus2
            // 
            this.labelStatus2.AutoSize = true;
            this.labelStatus2.Location = new System.Drawing.Point(30, 189);
            this.labelStatus2.Name = "labelStatus2";
            this.labelStatus2.Size = new System.Drawing.Size(37, 13);
            this.labelStatus2.TabIndex = 39;
            this.labelStatus2.Text = "Status";
            this.labelStatus2.Visible = false;
            // 
            // textBoxDescricao2
            // 
            this.textBoxDescricao2.Enabled = false;
            this.textBoxDescricao2.Location = new System.Drawing.Point(30, 151);
            this.textBoxDescricao2.Name = "textBoxDescricao2";
            this.textBoxDescricao2.Size = new System.Drawing.Size(455, 20);
            this.textBoxDescricao2.TabIndex = 38;
            this.textBoxDescricao2.Visible = false;
            // 
            // labelDescicao2
            // 
            this.labelDescicao2.AutoSize = true;
            this.labelDescicao2.Location = new System.Drawing.Point(27, 134);
            this.labelDescicao2.Name = "labelDescicao2";
            this.labelDescicao2.Size = new System.Drawing.Size(116, 13);
            this.labelDescicao2.TabIndex = 37;
            this.labelDescicao2.Text = "Descrição da Natureza";
            this.labelDescicao2.Visible = false;
            // 
            // labelTitle2
            // 
            this.labelTitle2.AutoSize = true;
            this.labelTitle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle2.Location = new System.Drawing.Point(25, 50);
            this.labelTitle2.Name = "labelTitle2";
            this.labelTitle2.Size = new System.Drawing.Size(160, 24);
            this.labelTitle2.TabIndex = 5;
            this.labelTitle2.Text = "Alterar Natureza";
            this.labelTitle2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descricao,
            this.status,
            this.alterar});
            this.dataGridView1.DataSource = this.naturezaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(149, 292);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 150);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id_natureza";
            this.id.HeaderText = "id_natureza";
            this.id.Name = "id";
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "nome";
            this.descricao.HeaderText = "nome";
            this.descricao.Name = "descricao";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.Name = "status";
            // 
            // alterar
            // 
            this.alterar.HeaderText = "";
            this.alterar.Name = "alterar";
            this.alterar.Text = "alterar";
            this.alterar.UseColumnTextForLinkValue = true;
            // 
            // naturezaBindingSource
            // 
            this.naturezaBindingSource.DataMember = "Natureza";
            this.naturezaBindingSource.DataSource = this.fICHAMENTODataSet;
            // 
            // fICHAMENTODataSet
            // 
            this.fICHAMENTODataSet.DataSetName = "FICHAMENTODataSet";
            this.fICHAMENTODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(536, 458);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.Size = new System.Drawing.Size(59, 20);
            this.textBoxResultado.TabIndex = 35;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(402, 461);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(128, 13);
            this.labelResultado.TabIndex = 34;
            this.labelResultado.Text = "Resultados encontrados: ";
            // 
            // naturezaTableAdapter
            // 
            this.naturezaTableAdapter.ClearBeforeFill = true;
            // 
            // frmVerificarNatureza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 512);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButtonDesativo);
            this.Controls.Add(this.radioButtonAtivado);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmVerificarNatureza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Natureza";
            this.Load += new System.EventHandler(this.frmVerificarNatureza_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.naturezaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fICHAMENTODataSet)).EndInit();
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
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.RadioButton radioButtonDesativo;
        private System.Windows.Forms.RadioButton radioButtonAtivado;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitle2;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.RadioButton radioButtonDesativado2;
        private System.Windows.Forms.RadioButton radioButtonAtivado2;
        private System.Windows.Forms.Label labelStatus2;
        private System.Windows.Forms.TextBox textBoxDescricao2;
        private System.Windows.Forms.Label labelDescicao2;
        private System.Windows.Forms.Button btnConfirmar2;
        private System.Windows.Forms.Button btnCancelar2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Label labelResultado;
        private FICHAMENTODataSet fICHAMENTODataSet;
        private System.Windows.Forms.BindingSource naturezaBindingSource;
        private FICHAMENTODataSetTableAdapters.NaturezaTableAdapter naturezaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewLinkColumn alterar;
    }
}
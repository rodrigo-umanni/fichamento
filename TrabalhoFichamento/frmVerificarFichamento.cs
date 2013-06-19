using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrabalhoFichamento
{
    public partial class frmVerificarFichamento : Form
    {
        public frmVerificarFichamento()
        {
            InitializeComponent();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verificarProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarProjeto projeto = new frmVerificarProjeto();
            projeto.Show();
        }

        private void cadastrarProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarProjeto projeto = new frmCadastrarProjeto();
            projeto.Show();
        }

        private void verificarFichamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
        }

        private void cadastrarFichamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarFichamento fichamento = new frmCadastrarFichamento();
            fichamento.Show();
        }

        private void verficarObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarObra obra = new frmVerificarObra();
            obra.Show();
        }

        private void cadastrarObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarObra obra = new frmCadastrarObra();
            obra.Show();
        }

        private void verificarAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarAutor autor = new frmVerificarAutor();
            autor.Show();
        }

        private void cadastrarAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarAutor autor = new frmCadastrarAutor();
            autor.Show();
        }

        private void verificarModalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarModalidade modalidade = new frmVerificarModalidade();
            modalidade.Show();
        }

        private void verificarNeturezaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarNatureza natureza = new frmVerificarNatureza();
            natureza.Show();
        }

        private void verificarFormaDeEstudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarFormaDeEstudo forma = new frmVerificarFormaDeEstudo();
            forma.Show();
        }

        private void verificarObjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarObjeto objeto = new frmVerificarObjeto();
            objeto.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Você deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (d.ToString() == "Yes")
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        //Botão

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarFichamento fichamento = new frmCadastrarFichamento();
            fichamento.Show();
        }  
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if ((comboBoxAutorFichamento.Text == String.Empty && comboBoxAutorFichamento.Text.Trim() == "") &&
               (projeto_combobox.Text == String.Empty && projeto_combobox.Text.Trim() == "") &&
                (obra_combobox.Text == String.Empty && projeto_combobox.Text.Trim() == "") &&
                 (palavra_comboBox.Text == String.Empty && palavra_comboBox.Text.Trim() == ""))
            {
                MessageBox.Show("Defina pelo menos um campo para pesquisa");
                return;
            }
            else
            {
                MessageBox.Show("Em Desenvolviemtno");
            }
            textBoxResultado.Text = dataGridView1.Rows.Count.ToString();
        }
        //Carregamento da Tela
        private void frmVerificarFichamento_Load(object sender, EventArgs e)
        {
            textBoxResultado.Text = ((dataGridView1.Rows.Count) - 1).ToString();
        }
        //Data Grid
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                //Tornando os campos visiveis
                panel1.Visible = true;
                labelTitle2.Visible = true;
                labelAutorF.Visible = true;
                comboBoxAutorFichamento.Visible = true;
                labelModalidade2.Visible = true;
                modalidade_combobox.Visible = true;
                btnAddModalidade.Visible = true;
                labelNatureza2.Visible = true;
                natureza_combobox.Visible = true;
                btnAddNatureza.Visible = true;
                labelForma2.Visible = true;
                forma_de_estudo_combobox.Visible = true;
                btnAddForma.Visible = true;
                labelObjeto2.Visible = true;
                objeto_combobox.Visible = true;
                btnAddObjeto.Visible = true;
                labelPChave.Visible = true;
                textBoxPChave.Visible = true;
                btnAdd1.Visible = true;
                panel2.Visible = true;
                labelResumo2.Visible = true;
                resumo_text_box.Visible = true;
                labelResenha2.Visible = true;
                resenha_text_box.Visible = true;
                citacoes_text_box.Visible = true;
                labelInfo2.Visible = true;
                btnCancelar2.Visible = true;
                btnConfirmar2.Visible = true;

                //Enviando os dados para alteração
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxAutorF.Text = row.Cells["autorf"].Value.ToString();
                citacoes_text_box.Text = row.Cells["citacao"].Value.ToString();
            }


        }
        //Form Alteração do Fichamento
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            btnAdd1.Visible = false;
            btnAdd2.Visible = true;
            textBoxPChave2.Visible = true;
            panel1.Location = new Point(0, 274);
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            btnAdd2.Visible = false;
            btnAdd3.Visible = true;
            textBoxPChave3.Visible = true;
            panel1.Location = new Point(0, 301);
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            btnAdd3.Visible = false;
            btnAdd4.Visible = true;
            textBoxPChave4.Visible = true;
            panel1.Location = new Point(0, 327);
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            btnAdd4.Visible = true;
            textBoxPChave5.Visible = true;
            panel1.Location = new Point(0, 357);
        }
        //Cadastrar Natureza
        private void btnAddNatureza_Click(object sender, EventArgs e)
        {

            frmCadastrarNatureza natureza = new frmCadastrarNatureza();
            natureza.ShowDialog();
        }
        private void btnAddModalidade_Click(object sender, EventArgs e)
        {
            frmCadastrarModalidade modalidade = new frmCadastrarModalidade();
            modalidade.ShowDialog();
        }
        //Cadastrando Forma de Estudo
        private void btnAddForma_Click(object sender, EventArgs e)
        {
            frmCadastrarFormaDeEstudo forma = new frmCadastrarFormaDeEstudo();
            forma.ShowDialog();
        }
        //Cadastrando Objeto
        private void btnAddObjeto_Click(object sender, EventArgs e)
        {
            frmCadastrarObjeto objeto = new frmCadastrarObjeto();
            objeto.ShowDialog();
        }

        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Você deseja cancelar a alteração?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (d.ToString() == "Yes")
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void btnConfirmar2_Click(object sender, EventArgs e)
        {

        }

                


    }
}

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
    public partial class frmVerificarProjeto : Form
    {
        public frmVerificarProjeto()
        {
            InitializeComponent();
        }
        // Itens do Menu
        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void verificarProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Próprio Item
        }

        private void cadastrarProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarProjeto projeto = new frmCadastrarProjeto();
            projeto.Show();
        }

        private void verificarFichamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarFichamento fichamento = new frmVerificarFichamento();
            fichamento.Show();
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
        //Botões
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textNomeProjeto.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            groupCalendar.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textData.Text = monthCalendar1.SelectionStart.ToShortDateString();
            groupCalendar.Visible = false;

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarProjeto projeto = new frmCadastrarProjeto();
            projeto.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if ((textNomeProjeto.Text == String.Empty && textNomeProjeto.Text.Trim() == "") &&
               (textData.Text == String.Empty && textData.Text.Trim() == ""))
            {
                MessageBox.Show("Defina pelo menos um campo para pesquisa");
                return;
            }
            else
            {
                if ((textData.Text == String.Empty && textData.Text.Trim() == ""))
                {
                    models.OperacaoProjeto p = new models.OperacaoProjeto();
                    dataGridView1.DataSource = p.pesquisarProjeto(textNomeProjeto.Text);
                }
                else if ((textNomeProjeto.Text == String.Empty && textNomeProjeto.Text.Trim() == ""))
                {
                    models.OperacaoProjeto p = new models.OperacaoProjeto();
                    dataGridView1.DataSource = p.pesquisarProjeto(Convert.ToDateTime(textData.Text));
                }
                else
                {
                    models.OperacaoProjeto p = new models.OperacaoProjeto();
                    dataGridView1.DataSource = p.pesquisarProjeto(textNomeProjeto.Text, Convert.ToDateTime(textData.Text));
                }
                textBoxResultado.Text = dataGridView1.Rows.Count.ToString();
            }
        }

        private void frmVerificarProjeto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fICHAMENTODataSet.Projeto' table. You can move, or remove it, as needed.
            this.projetoTableAdapter.Fill(this.fICHAMENTODataSet.Projeto);
            textBoxResultado.Text = ((dataGridView1.Rows.Count) - 1).ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                //Tornando os campos visiveis
                panel1.Visible = true;
                labelTitle2.Visible = true;
                labelCod.Visible = true;
                textBoxCod.Visible = true;
                labelNomeAlterar.Visible = true;
                textBoxNomeAlterar.Visible = true;
                textBoxDataAlterar.Visible = true;
                labelDataAlterar.Visible = true;
                btnLimpar2.Visible = true;
                labelInfo2.Visible = true;
                btnCancelar2.Visible = true;
                btnConfirmar2.Visible = true;

                //Enviando os dados para alteração
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxCod.Text = row.Cells["id"].Value.ToString();
                textBoxNomeAlterar.Text = row.Cells["nome"].Value.ToString();
                textBoxDataAlterar.Text = row.Cells["data"].Value.ToString();
            }

        }
        //Formulario Alterar
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
            if (textBoxNomeAlterar.Text != String.Empty || textBoxNomeAlterar.Text.Equals(" "))
            {
                Projeto projeto = new Projeto();
                projeto.id_projeto = Convert.ToInt32(textBoxCod.Text);
                projeto.nome = textBoxNomeAlterar.Text;

                models.OperacaoProjeto p = new models.OperacaoProjeto();
                p.alterar(projeto);
                this.Close();

            }
            else
            {
                MessageBox.Show("Os campos com (*) são obrigatório");
            }
        }

        private void btnLimpar2_Click(object sender, EventArgs e)
        {
            textBoxNomeAlterar.Clear();
        }




    }
}

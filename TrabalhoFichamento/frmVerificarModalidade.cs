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
    public partial class frmVerificarModalidade : Form
    {
        public frmVerificarModalidade()
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

        private void verificarObraToolStripMenuItem_Click(object sender, EventArgs e)
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
            return;
        }

        private void verificarNaturezaToolStripMenuItem_Click(object sender, EventArgs e)
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

        
        private void frmVerificarModalidade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fICHAMENTODataSet.Modalidade' table. You can move, or remove it, as needed.
            this.modalidadeTableAdapter.Fill(this.fICHAMENTODataSet.Modalidade);

            //Carregar GRiD
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
                labelDescicao2.Visible = true;
                textBoxDescricao2.Visible = true;
                radioButtonAtivado2.Visible = true;
                radioButtonDesativado2.Visible = true;
                btnCancelar2.Visible = true;
                btnConfirmar2.Visible = true;

                //Enviando os dados para alteração
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxCod.Text = row.Cells["id"].Value.ToString();
                textBoxDescricao2.Text = row.Cells["descricao"].Value.ToString();

            }
        }
        //Form Alterar
        private void btnCancelar2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Você deseja cancelar a alteração?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (d.ToString() == "Yes")
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btnConfirmar2_Click(object sender, EventArgs e)
        {
            Modalidade modalidade = new Modalidade();
            modalidade.id_modalidade = Convert.ToInt32(textBoxCod.Text);
            modalidade.Descricao = textBoxDescricao.Text;

            if (radioButtonAtivado2.Checked)
            {
                modalidade.Status = true;
            }
            if (radioButtonDesativado2.Checked)
            {
                modalidade.Status = false;
            }

            models.OperacaoModalidade m = new models.OperacaoModalidade();
            m.alterar(modalidade);
            this.Close();
        }

        private void labelTitle2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCod_Click(object sender, EventArgs e)
        {

        }

        private void labelDescicao2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDescricao2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelStatus2_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonAtivado2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonDesativado2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }






    }
}

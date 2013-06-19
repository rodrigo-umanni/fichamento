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
    public partial class frmCadastrarProjeto : Form
    {
        public frmCadastrarProjeto()
        {
            InitializeComponent();
            textData.Text = DateTime.Now.ToShortDateString();
        }
        //Itens do menu
        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void verificarProjetoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarProjeto projeto = new frmVerificarProjeto();
            projeto.Show();
        }

        private void cadastrarProjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return;
        }

        private void verificarFichamentoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarFichamento fichamento = new frmVerificarFichamento();
            fichamento.Show();
        }
        private void cadastrarFichamentoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarFichamento fichamento = new frmCadastrarFichamento();
            fichamento.Show();
        }

        private void verficarObraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarObra obra = new frmVerificarObra();
            obra.Show();
        }

        private void cadastrarObraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarObra obra = new frmCadastrarObra();
            obra.Show();
        }

        private void verificarAutorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarAutor autor = new frmVerificarAutor();
            autor.Show();
        }
        
        private void cadastrarAutorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarAutor autor = new frmCadastrarAutor();
            autor.Show();
        }

        private void verificarModalidadeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarModalidade modalidade = new frmVerificarModalidade();
            modalidade.Show();
        }

        private void verificarNeturezaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarNatureza natureza = new frmVerificarNatureza();
            natureza.Show();
        }

        private void verificarFormaDeEstudoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarFormaDeEstudo forma = new frmVerificarFormaDeEstudo();
            forma.Show();
        }

        private void verificarObjetoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarObjeto objeto = new frmVerificarObjeto();
            objeto.Show();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Você deseja cancelar o cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (d.ToString() == "Yes")
            {
                this.Close();
            }
            else
            {
                return;
            }
            
        }

        private void btnCnfirmar_Click(object sender, EventArgs e)
        {

            if (textNomeProjeto.Text != String.Empty || textNomeProjeto.Text.Equals(" "))
            {
                Projeto projeto = new Projeto();
                projeto.nome = textNomeProjeto.Text;
                projeto.data_Abertura =  DateTime.Parse(textData.Text);

                models.OperacaoProjeto p = new models.OperacaoProjeto();
                p.gravar(projeto);

            }
            else
            {
                MessageBox.Show("Os campos com (*) são obrigatório");
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textNomeProjeto.Clear();
        }

        

        

        

       

       

        

        
    }
}

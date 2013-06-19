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
    public partial class frmCadastrarCapitulo : Form
    {
        private Capitulo capitulo = null;

        internal Capitulo Capitulo
        {
            get { return capitulo; }
            set { capitulo = value; }
        }
        public frmCadastrarCapitulo()
        {
            InitializeComponent();
        }
        //itens do Menu
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
            this.Close();
            frmVerificarModalidade modalidade = new frmVerificarModalidade();
            modalidade.Show();
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
        //Botões
        private void btnCnfirmar_Click(object sender, EventArgs e)
        {
            if ((textBoxObra.Text != String.Empty && textBoxObra.Text.Trim() != "") &&
              (textBoxPaginaDe.Text != String.Empty && textBoxPaginaDe.Text.Trim() != "") && 
              (textBoxAte.Text != String.Empty && textBoxAte.Text.Trim() != ""))
            {
                MessageBox.Show("Em Desenvolvimento");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxObra.Clear();
            textBoxPaginaDe.Clear();
            textBoxAte.Clear();

        }

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

        private void textBoxPaginaDe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void textBoxAte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

    }
}

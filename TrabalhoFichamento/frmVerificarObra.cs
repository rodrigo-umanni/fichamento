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
    public partial class frmVerificarObra : Form
    {
        public frmVerificarObra()
        {
            InitializeComponent();
        }
        //Itens do Menu
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
            return; 
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
        //Botão
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarObra obra = new frmCadastrarObra();
            obra.Show();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //Verificando se ao menos um campo esta preenchido
            if ((comboBoxTitulo.Text == String.Empty) &&
               (comboBoxAutor.Text == String.Empty) &&
                (comboBoxISSN.Text == String.Empty) &&
                (maskedTextBoxAno.Text == String.Empty) &&
                (comboBoxEditora.Text == String.Empty) &&
                (comboBoxEvento.Text == String.Empty) &&
                (comboBoxCurso.Text == String.Empty) &&
                (checkBoxLivro.Checked == false) &&
                (checkBoxCapitulo.Checked == false) &&
                (checkBoxArtigo.Checked == false) &&
                (checkBoxTDM.Checked == false)
                )
            {
                MessageBox.Show("Defina pelo menos um campo para pesquisa");
                return;
            }
            else {
                MessageBox.Show("E desenvolvimento");
            }
            textBoxResultado.Text = dataGridView1.Rows.Count.ToString();
        }
        //Validações de campos
        private void maskedTextBoxAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&& e.KeyChar !=(char)8){
            e.Handled = true;
            }
        }
        //Carregar Tela 
        private void frmVerificarObra_Load(object sender, EventArgs e)
        {
            textBoxResultado.Text = ((dataGridView1.Rows.Count) - 1).ToString();
            CompletaTituloObra();
            CompletarAutoresObra();
            CompletaIssn();
            CompletaEditora();
            //CompletaEvento();
            CompletaCurso();
        }

        private void CompletaTituloObra()
        {
            models.OperacaoObra m = new models.OperacaoObra();
            List<Obra> list = m.listarTodos();

            comboBoxTitulo.DataSource = list;
            comboBoxTitulo.DisplayMember = "titulo";
            comboBoxTitulo.ValueMember = "id_obra";
            
        }

        private void CompletarAutoresObra()
        {
            models.OperacaoAutor m = new models.OperacaoAutor();
            List<Autor> autores = m.listarTodos();

            ComboBox c = comboBoxAutor;
            c.DataSource = autores;
            c.DisplayMember = "nome";
            c.ValueMember = "id_autor_de_obra";


        }

        private void CompletaEditora() {
            models.OperacaoLivro m = new models.OperacaoLivro();
            List<Livro> livros = m.listarTodos();

            ComboBox c = comboBoxEditora;
            c.DataSource = livros;
            c.DisplayMember = "editora";
            c.ValueMember = "id_obra_livro";
            
        }

        private void CompletaIssn() {
            models.OperacaoArtigo m = new models.OperacaoArtigo();
            List<Artigo> lista = m.listarTodos();

            ComboBox c = comboBoxISSN;
            c.DataSource = lista;
            c.DisplayMember = "ISBN_ISSN";
            c.ValueMember = "obra_id_obra";
        
        }

        private void CompletaCurso() {
            models.OperacaoTDM m = new models.OperacaoTDM();
            List<Entidades.Tdm> lista = m.listarTodos();

            ComboBox c = comboBoxCurso;
            c.DataSource = lista;
            c.DisplayMember = "curso";
            c.ValueMember = "obra_id_obra";
        }
    }
}

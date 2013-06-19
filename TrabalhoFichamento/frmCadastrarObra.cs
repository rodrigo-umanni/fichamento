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
    public partial class frmCadastrarObra : Form
    {
        int countAutor = 0;
        public frmCadastrarObra()
        {
            InitializeComponent();

        }

        private void btnAvançar_Click(object sender, EventArgs e)
        {
            if ((textBoxTitulo.Text != String.Empty && textBoxTitulo.Text.Trim() != "") &&
              (comboBoxAutor1.Text != String.Empty && comboBoxAutor1.Text.Trim() != "") &&
              (textBoxLocal.Text != String.Empty && textBoxLocal.Text.Trim() != "") &&
              (maskAno.Text != String.Empty && maskAno.Text.Trim() != "") &&
              (radioButtonLivro.Checked || radioButtonArtigo.Checked || radioButtonCapitulo.Checked || radioButtonTDM.Checked))
            {
                if (maskAno.Text.Length < 4)
                {
                    MessageBox.Show("Informe Ano de Publicação no formato: YYYY ");
                    return;
                }
                else
                {
                    Obra obra = new Obra();
                    obra.titulo = textBoxTitulo.Text;
                    obra.subtitulo = textBoxSub.Text;
                    obra.local_publicacao = textBoxLocal.Text;
                    obra.ano_publicacao = Convert.ToInt32(maskAno.Text);

                    //comboBoxAutor1.SelectedValue.

                    //models.OperacaoObra o = new models.OperacaoObra();
                    //o.gravar(obra);
                    //Bancos

                    //verificando tipo de publicação
                    if (radioButtonLivro.Checked == true)
                    {
                        this.Close();
                        frmCadastrarLivro livro = new frmCadastrarLivro();
                        livro.Livro = new Livro();

                        livro.Livro.titulo = obra.titulo;
                        livro.Livro.subtitulo = obra.subtitulo;
                        livro.Livro.local_publicacao = obra.local_publicacao;
                        livro.Livro.ano_publicacao = obra.ano_publicacao;
                        livro.Show();
                    }
                    if (radioButtonArtigo.Checked == true)
                    {
                        this.Close();
                        frmCadastrarArtigo artigo = new frmCadastrarArtigo();

                        artigo.Artigo = new Artigo();

                        artigo.Artigo.titulo = obra.titulo;
                        artigo.Artigo.subtitulo = obra.subtitulo;
                        artigo.Artigo.local_publicacao = obra.local_publicacao;
                        artigo.Artigo.ano_publicacao = obra.ano_publicacao;

                        artigo.Show();
                    }
                    if (radioButtonCapitulo.Checked == true)
                    {
                        this.Close();
                        frmCadastrarCapitulo capitulo = new frmCadastrarCapitulo();

                        capitulo.Capitulo = new Capitulo();

                        capitulo.Capitulo.titulo = obra.titulo;
                        capitulo.Capitulo.subtitulo = obra.subtitulo;
                        capitulo.Capitulo.local_publicacao = obra.local_publicacao;
                        capitulo.Capitulo.ano_publicacao = obra.ano_publicacao;

                        capitulo.Show();
                    }
                    if (radioButtonTDM.Checked == true)
                    {
                        this.Close();
                        frmCadastrarTDM tdm = new frmCadastrarTDM();

                        tdm.Tdm = new Entidades.Tdm();

                        tdm.Tdm.titulo = obra.titulo;
                        tdm.Tdm.subtitulo = obra.subtitulo;
                        tdm.Tdm.local_publicacao = obra.local_publicacao;
                        tdm.Tdm.ano_publicacao = obra.ano_publicacao;

                        tdm.Show();
                    }
                }


            }


            else
            {
                MessageBox.Show("Os campos com (*) são obrigatório");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBoxTitulo.Clear();
            //comboBoxAutor1.Clear();
            textBoxLocal.Clear();
            maskAno.Clear();
            radioButtonLivro.Checked = false;
            radioButtonArtigo.Checked = false;
            radioButtonCapitulo.Checked = false;
            radioButtonTDM.Checked = false;

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
            //Itens do menu

        }

        private void menuPrincipalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verificarProjetoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarProjeto projeto = new frmVerificarProjeto();
            projeto.Show();
        }

        private void cadastrarProjetoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarProjeto projeto = new frmCadastrarProjeto();
            projeto.Show();
        }

        private void verificarFichamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarFichamento fichamento = new frmVerificarFichamento();
            fichamento.Show();
        }

        private void cadastrarFichamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarFichamento fichamento = new frmCadastrarFichamento();
            fichamento.Show();
        }

        private void verificarObraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarObra obra = new frmVerificarObra();
            obra.Show();
        }

        private void cadastrarObraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void verificarAutorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarAutor autor = new frmVerificarAutor();
            autor.Show();
        }

        private void cadastrarAutorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarAutor autor = new frmCadastrarAutor();
            autor.Show();
        }

        private void verificarModalidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarModalidade modalidade = new frmVerificarModalidade();
            modalidade.Show();
        }

        private void verificarNaturezaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarNatureza natureza = new frmVerificarNatureza();
            natureza.Show();
        }

        private void verificarFormaDeEstudoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarFormaDeEstudo forma = new frmVerificarFormaDeEstudo();
            forma.Show();
        }

        private void verificarObjetoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarObjeto objeto = new frmVerificarObjeto();
            objeto.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void maskAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        //Comportamento do Adicionar autor
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            
            btnAdd1.Visible = false;
            btnAdd2.Visible = true;
            btnMenos1.Visible = true;
            comboBoxAutor2.Visible = true;
            panel1.Location = new Point(0, 248);
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            panel1.Location = new Point(0, 275);
            btnAdd2.Visible=false;
            btnAdd3.Visible = true;
            btnMenos1.Visible = false;
            btnMenos2.Visible = true;
            comboBoxAutor3.Visible = true;
            

        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            btnAdd3.Visible=false;
            btnAdd4.Visible = true;
            btnMenos2.Visible = false;
            btnMenos3.Visible = true;
            comboBoxAutor4.Visible = true;
            panel1.Location = new Point(0, 302);
            
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            btnAdd4.Visible = false;
            comboBoxAutor5.Visible = true;
            btnMenos3.Visible = false;
            btnMenos4.Visible = true;
            panel1.Location = new Point(0, 329);
        }

        private void btnMenos1_Click(object sender, EventArgs e)
        {
            btnMenos1.Visible = false;
            btnAdd1.Visible = true;
            btnAdd2.Visible = false;
            comboBoxAutor2.Visible = false;
            panel1.Location = new Point(0, 219);

        }

        private void btnMenos2_Click(object sender, EventArgs e)
        {
            btnMenos2.Visible = false;
            btnAdd2.Visible = true;
            btnAdd3.Visible = false;
            btnMenos1.Visible = true;
            comboBoxAutor3.Visible = false;
            panel1.Location = new Point(0, 248);
        }

        private void btnMenos3_Click(object sender, EventArgs e)
        {
            btnMenos3.Visible = false;
            btnAdd3.Visible = true;
            btnAdd4.Visible = false;
            btnMenos2.Visible = true;
            comboBoxAutor4.Visible = false;
            panel1.Location = new Point(0, 275);
        }

        private void btnMenos4_Click(object sender, EventArgs e)
        {
            btnMenos4.Visible = false;
            btnAdd4.Visible = true;
            btnMenos3.Visible = true;
            comboBoxAutor5.Visible = false;
            panel1.Location = new Point(0, 302);
        }

        private void frmCadastrarObra_Load(object sender, EventArgs e)
        {
            CompletarObra();
        }

        private void CompletarObra()
        {
            models.OperacaoAutor m = new models.OperacaoAutor();
            List<Autor> autores = m.listarTodos();

            ComboBox[] comboAutores = { comboBoxAutor1, comboBoxAutor2, comboBoxAutor3, comboBoxAutor4,
            comboBoxAutor5 };
            foreach (ComboBox c in comboAutores)
            {
                c.DataSource = autores;
                c.DisplayMember = "nome";
                c.ValueMember = "id_autor_de_obra";
            }

        }
























    }
}



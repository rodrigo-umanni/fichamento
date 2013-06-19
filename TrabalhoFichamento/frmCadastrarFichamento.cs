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
    public partial class frmCadastrarFichamento : Form
    {
        public frmCadastrarFichamento()
        {
            InitializeComponent();
        }

        private void menuPrincipalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verificarProjetoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarProjeto projeto = new frmVerificarProjeto();
            projeto.Show();
        }

        private void cadastrarProjetoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarProjeto projeto = new frmCadastrarProjeto();
            projeto.Show();
        }

        private void verificarFichamentoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarFichamento fichamento = new frmVerificarFichamento();
            fichamento.Show();
        }

        private void cadastrarFichamentoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            return;
        }

        private void verificarObraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarObra obra = new frmVerificarObra();
            obra.Show();
        }

        private void cadastrarObraToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarObra obra = new frmCadastrarObra();
            obra.Show();
        }

        private void verificarAutorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarAutor autor = new frmVerificarAutor();
            autor.Show();
        }
        private void cadastrarAutorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCadastrarAutor autor = new frmCadastrarAutor();
            autor.Show();
        }

        private void verificarModalidadeToolStripMenuItem2_Click(object sender, EventArgs e)
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

        private void verificarFormaDeEstudoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarFormaDeEstudo forma = new frmVerificarFormaDeEstudo();
            forma.Show();
        }

        private void verificarObjetoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmVerificarObjeto objeto = new frmVerificarObjeto();
            objeto.Show();
        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
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
        private void frmCadastrarFichamento_Load(object sender, EventArgs e)
        {
            CompletarProjetoCombo();
            CompletarNaturezaCombo();
            CompletarModalidadeCombo();
            CompletarFormaDeEstudoCombo();
            CompletarObjetoCombo();
            CompletarObraCombo();
        }
        private void CompletarProjetoCombo() {
            models.OperacaoProjeto p = new models.OperacaoProjeto();
            List<Projeto> projetos = p.listarTodos();
 
            projeto_combobox.DataSource = projetos;
            projeto_combobox.DisplayMember = "Nome";
            projeto_combobox.ValueMember = "id_projeto";
        }
        private void CompletarNaturezaCombo() {
            models.OperacaoNatureza n = new models.OperacaoNatureza();
            List<Natureza> naturezas = n.listarTodos();

            natureza_combobox.DataSource = naturezas;
            natureza_combobox.DisplayMember = "Nome";
            natureza_combobox.ValueMember = "id_natureza";
        }

        private void CompletarModalidadeCombo() {
            models.OperacaoModalidade m = new models.OperacaoModalidade();
            List<Modalidade> modalidades = m.listarTodos();

            modalidade_combobox.DataSource = modalidades;
            modalidade_combobox.DisplayMember = "Descricao";
            modalidade_combobox.ValueMember = "id_modalidade";
        }

        private void CompletarFormaDeEstudoCombo() {
            models.OperacaoFormaDeEstudo m = new models.OperacaoFormaDeEstudo();
            List<FormaDeEstudo> list = m.listarTodos();

            forma_de_estudo_combobox.DataSource = list;
            forma_de_estudo_combobox.DisplayMember = "Descricao";
            forma_de_estudo_combobox.ValueMember = "id_forma_de_estudo";
            
        }

        private void CompletarObjetoCombo() {
            models.OperacaoObjeto m = new models.OperacaoObjeto();
            List<Objeto> list = m.listarTodos();

            objeto_combobox.DataSource = list;
            objeto_combobox.DisplayMember = "Descricao";
            objeto_combobox.ValueMember = "id_objeto";
        }

        private void CompletarObraCombo() {
            models.OperacaoObra m = new models.OperacaoObra();
            List<Obra> list = m.listarTodos();

            obra_combobox.DataSource = list;
            obra_combobox.DisplayMember = "titulo";
            obra_combobox.ValueMember = "id_obra";
        
        }

        private void btnCnfirmar_Click(object sender, EventArgs e)
        {
            if (!campos_validos())
            {
                MessageBox.Show("Os campos(*) são obrigatórios");
            }
            else {
                DialogResult d = MessageBox.Show("Confirma o cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (d.ToString() == "Yes")
                {
                    salvarFichamento();
                }
                else
                {
                    return;
                }
                
            }
        }

        private bool campos_validos() {
            bool validos = true;
            validos = resumo_text_box.Text == String.Empty || resenha_text_box.Text == String.Empty || citacoes_text_box.Text == String.Empty;
            return !validos;
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
        //Comportamento adicionar palavra chave
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            btnAdd1.Visible = false;
            btnAdd2.Visible = true;
            textBoxPChave2.Visible = true;
            panel1.Location = new Point(0, 289);
        }

        private void btnmenos1_Click(object sender, EventArgs e)
        {
            btnAdd1.Visible = true;
            btnAdd2.Visible = false;
            textBoxPChave2.Visible = false;
            panel1.Location = new Point(0, 262);
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            btnAdd2.Visible = false;
            btnAdd3.Visible = true;
            btnmenos1.Visible = false;
            textBoxPChave3.Visible = true;
            panel1.Location = new Point(0, 315);
        }

        private void btnmenos2_Click(object sender, EventArgs e)
        {
            btnAdd2.Visible = true;
            btnAdd3.Visible = false;
            textBoxPChave3.Visible = false;
            btnmenos1.Visible = true;
            panel1.Location = new Point(0, 289);
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            btnAdd3.Visible = false;
            btnAdd4.Visible = true;
            btnmenos2.Visible = false;
            textBoxPChave4.Visible = true;
            panel1.Location = new Point(0, 341);
        }

        private void btnmenos3_Click(object sender, EventArgs e)
        {
            btnAdd3.Visible = true;
            btnAdd4.Visible = false;
            textBoxPChave4.Visible = false;
            btnmenos2.Visible = true;
            panel1.Location = new Point(0, 315);
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            btnmenos3.Visible = false;
            btnAdd4.Visible = false;
            textBoxPChave5.Visible = true;
            panel1.Location = new Point(0, 367);
        }
        private void btnmenos4_Click(object sender, EventArgs e)
        {
            btnAdd4.Visible = true;
            textBoxPChave5.Visible = false;
            btnmenos3.Visible = true;
            panel1.Location = new Point(0, 341);
        }

        //Cadastrar Natureza
        private void btnAddNatureza_Click(object sender, EventArgs e)
        {
            frmCadastrarNatureza natureza = new frmCadastrarNatureza();
            natureza.ShowDialog();
        }
        //Cadastrar modalidade
        private void btnAddModalidade_Click(object sender, EventArgs e)
        {
            frmCadastrarModalidade modalidade = new frmCadastrarModalidade();
            modalidade.ShowDialog();
        }
        //Cadastrar Forma
        private void btnAddForma_Click(object sender, EventArgs e)
        {
            frmCadastrarFormaDeEstudo forma = new frmCadastrarFormaDeEstudo();
            forma.ShowDialog();
        }
        //Cadastrar Objeto
        private void btnAddObjeto_Click(object sender, EventArgs e)
        {
            frmCadastrarObjeto objeto = new frmCadastrarObjeto();
            objeto.ShowDialog();
        }
        private void salvarFichamento()
        {
            String autor = textBoxAutorF.Text;


            //MessageBox.Show(Convert.ToString(projeto_combobox.SelectedValue) );

            int projeto_id = Convert.ToInt16(projeto_combobox.SelectedValue);
            int obra_id = Convert.ToInt16(obra_combobox.SelectedValue);
            int natureza_id = Convert.ToInt16(natureza_combobox.SelectedValue);
            int modalidade_id = Convert.ToInt16(modalidade_combobox.SelectedValue);
            int forma_de_estudo = Convert.ToInt16(forma_de_estudo_combobox.SelectedValue);
            int objeto_id = Convert.ToInt16(objeto_combobox.SelectedValue);

            String resumo = resumo_text_box.Text;
            String resenha = resenha_text_box.Text;
            String citacoes = citacoes_text_box.Text;
            String[] palavras_chave = { textBoxPChave.Text, textBoxPChave2.Text, textBoxPChave3.Text,
                                          textBoxPChave4.Text, textBoxPChave5.Text};

            Fichamento fich = new Fichamento();
            fich.IdProjeto = projeto_id;
            fich.Resumo = resumo;
            fich.IdNatureza = natureza_id;
            fich.IdModalidade = modalidade_id;
            fich.IdFormaEstudo = forma_de_estudo;
            fich.IdObjeto = objeto_id;
            fich.Resenha = resenha;
            fich.Citacoes = citacoes;
            fich.DataFichamento = DateTime.Now;
            fich.ObraIdObra = obra_id;


            models.OperacaoFichamento of = new models.OperacaoFichamento();
            of.gravar(fich);
            //MessageBox.Show(projeto_combobox.ValueMember);
            //usar metodo para remover palavras chave vazias

        }

        
       
    }
}

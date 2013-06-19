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
    public partial class frmCadastrarObjeto : Form
    {
        public frmCadastrarObjeto()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxDescricao.Text != String.Empty || textBoxDescricao.Text.Equals(" "))
            {
                DialogResult d = MessageBox.Show("Confirma cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (d.ToString() == "Yes")
                {
                    Objeto objeto = new Objeto();
                    objeto.Descricao = textBoxDescricao.Text;
                    objeto.Status = true;

                    models.OperacaoObjeto m = new models.OperacaoObjeto();
                    m.gravar(objeto);
                }
                else
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("Preencha a campo Descrição");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Você deseja cancelar a cadastro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (d.ToString() == "Yes")
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

    }
}

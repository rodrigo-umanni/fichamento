using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoFichamento
{
    class Fichamento
    {
        private Int32 _id_fichamento;
        private Int32 _id_projeto;
        private String _resumo;
        private Int32 _id_natureza;
        private Int32 _id_modalidade;
        private Int32 _id_forma_estudo;
        private Int32 _id_objeto;
        private String _resenha;
        private String _citacoes;
        private DateTime _data_fichamento;
        private Int32 _obra_id_obra;

        public Int32 IdFichamento
        {
            get { return _id_fichamento; }
            set { _id_fichamento = value; }
        }

        public Int32 IdProjeto
        {
            get { return _id_projeto; }
            set { _id_projeto = value; }
        }
        public String Resumo
        {
            get { return _resumo; }
            set { _resumo = value; }
        }
        public Int32 IdNatureza
        {
            get { return _id_natureza; }
            set { _id_natureza = value; }
        }
        public Int32 IdModalidade
        {
            get { return _id_modalidade; }
            set { _id_modalidade = value; }
        }
        public Int32 IdFormaEstudo
        {
            get { return _id_forma_estudo; }
            set { _id_forma_estudo = value; }
        }
        public Int32 IdObjeto
        {
            get { return _id_objeto; }
            set { _id_objeto = value; }
        }
        public String Resenha
        {
            get { return _resenha; }
            set { _resenha = value; }
        }
        public String Citacoes
        {
            get { return _citacoes; }
            set { _citacoes = value; }
        }

        public DateTime DataFichamento
        {
            get { return _data_fichamento; }
            set { _data_fichamento = value; }
        }

        public Int32 ObraIdObra
        {
            get { return _obra_id_obra; }
            set { _obra_id_obra = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoFichamento
{
    class Projeto
    {
        public Int32 id_projeto { get; set; }
        public String nome { get; set; }
        private DateTime data_abertura;

        public Projeto() { }

        public Projeto(string nome, DateTime data_abertura) 
        {
            this.nome = nome;
            this.data_abertura = data_abertura;
        }

        public DateTime data_Abertura
        {
            get { return data_abertura; }
            set { data_abertura = value; }
        }
    }
}

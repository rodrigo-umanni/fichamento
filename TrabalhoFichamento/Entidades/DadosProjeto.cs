using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoFichamento
{
    abstract class DadosProjeto
    {
        private String descricao;       
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
    }
}

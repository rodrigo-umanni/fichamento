using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoFichamento
{
    class Modalidade : DadosProjeto
    {
        private Int32 id_modalidade1;

        public Int32 id_modalidade
        {
            get { return id_modalidade1; }
            set { id_modalidade1 = value; }
        }
    }
}

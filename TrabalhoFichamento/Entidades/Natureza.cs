using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoFichamento
{
    class Natureza
    {
        private Int32 id_natureza1;
        private String nome;
        private bool status;

        public Int32 id_natureza
        {
            get { return id_natureza1; }
            set { id_natureza1 = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }


    }
}

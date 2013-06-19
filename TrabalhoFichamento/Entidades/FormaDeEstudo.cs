using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoFichamento
{
    class FormaDeEstudo : DadosProjeto
    {
        private Int32 id_forma_de_estudo1;

        public Int32 id_forma_de_estudo
        {
            get { return id_forma_de_estudo1; }
            set { id_forma_de_estudo1 = value; }
        }
    }
}

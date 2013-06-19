using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoFichamento
{
    class Objeto : DadosProjeto
    {
        private Int32 _id_objeto1;

        public Int32 id_objeto
        {
            get { return _id_objeto1; }
            set { _id_objeto1 = value; }
        }
    }
}

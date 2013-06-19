using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoFichamento.Entidades
{
    class Tdm : Obra
    {
        public int obra_id_obra { get; set; }
        public String programa { get; set; }
        public String curso { get; set; }
        public String instituicao { get; set; }

        public Tdm() { }

        public Tdm(int idObra, string programa, string curso, string instituicao )
        {
            this.obra_id_obra = idObra;
            this.programa = programa;
            this.curso = curso;
            this.instituicao = instituicao;
        }
    }
}

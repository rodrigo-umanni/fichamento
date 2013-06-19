using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoFichamento
{
    class Livro : Obra
    {
        public int obra_id_obra { get; set; }
        public int id_obra_livro { get; set; }
        public String editora { get; set; }
        public String edicao { get; set; }

        public Livro() { }

        public Livro(string editora)
        {
            
            this.editora = editora;

        }

        public Livro(int idObra, string editora, string edicao)
        {
            this.obra_id_obra = idObra;
            this.editora = editora;
            this.edicao = edicao;

        }
    }
}

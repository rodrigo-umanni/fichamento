using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoFichamento

{
    class Capitulo : Livro
    {
        public int id_capitulo_livro { get; set; }
        public int pagina_inicial { get; set; }
        public int pagina_final { get; set; }

        public Capitulo() { }

        public Capitulo(int idObra, string obra, int paginaDe, int paginaAte )
        {
            this.obra_id_obra = idObra;
            this.pagina_inicial = paginaDe;
            this.pagina_final = paginaAte;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoFichamento
{
    class Artigo : Obra
    {
        public int obra_id_obra { get; set; }
        public String periodico { get; set; }
        public String volume { get; set; }
        public int pagina_inical { get; set; }
        public int pagina_final { get; set; }
        public String ISBN_ISSN { get; set; }
        public String numero { get; set; }

        public Artigo() { }

        public Artigo(string periodico)
        {

            this.periodico = periodico;
        }

        public Artigo(int idObra, string periodico, string volume, int paginaDe, int paginaAte, string ISSN)
        {
            this.obra_id_obra = idObra;
            this.periodico = periodico;
            this.volume = volume;
            this.pagina_inical = paginaDe;
            this.pagina_final = paginaAte;
            this.ISBN_ISSN = ISSN;
        }

    }
}

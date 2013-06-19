using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TrabalhoFichamento.Entidades;

namespace TrabalhoFichamento
{
    class Obra
    {
        public Int64 id_obra { get; set; }
        public String titulo { get; set; }
        public String subtitulo { get; set; }
        public String local_publicacao { get; set; }
        public int ano_publicacao { get; set; }
        public List<Autor> listaAutor { get; set; }

        public Obra() { }

        public Obra(string titulo, string local, int ano)
        {

            this.titulo = titulo;
            this.local_publicacao = local;
            this.ano_publicacao = ano;

        }

        public Obra(string titulo, string subtitutlo, string local, int ano)
        {

            this.titulo = titulo;
            this.subtitulo = subtitutlo;
            this.local_publicacao = local;
            this.ano_publicacao = ano;
        }
    }
}

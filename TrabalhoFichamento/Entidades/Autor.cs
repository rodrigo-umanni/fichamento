using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabalhoFichamento
{
    class Autor
    {
        public Int64 id_autor_de_obra { get; set; }
        public String sobrenome { get; set; }
        public String nome { get; set; }
        public String citacao { get; set; }
        
        public Autor() { }

        public Autor(string sobrenome, string nome, string citacao) {
            this.sobrenome = sobrenome;
            this.nome = nome;
            this.citacao = citacao;

        }
    }
}

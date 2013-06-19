using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace TrabalhoFichamento
{
    abstract class Registro
    {
        protected Connection connection;

        public Registro()
        {
            //todo model tem acesso a instancia da classe de conexao
            //pelo atributo connection
            this.connection = Connection.Instance();
        }
    }
}

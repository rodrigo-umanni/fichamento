using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrabalhoFichamento
{
    class Connection
    {
        private static Connection UniqueInstance = null;
        private SqlConnection conex = null;
        private Connection()
        {
            Connect();

        }

        public static Connection Instance()
        {
            if (UniqueInstance == null)
            {
                UniqueInstance = new Connection();
            }
            return UniqueInstance;

        }
        //getter e setter da conexao
        public SqlConnection Conex
        {
            set { this.conex = value; }

            get { return this.conex; }
        }

        //private methods
        private void Connect()
        {
            //abre a conexao com o sql server e coloca no atributo conex

            //troque o data source para o nome do seu SERVER NAME
            string StrConex = @"Data Source = COMPUTADOR-PC\SQLEXPRESS;
                    Integrated Security = true;
                    Initial Catalog = FICHAMENTO";
            bool erro = false;
            try
            {
                conex = new SqlConnection(StrConex);
                conex.Open();
            }
            catch (SqlException ex)
            {
                erro = true;
                MessageBox.Show(ex.Message, "Erro na conexão com o banco de dados");
            }
            finally
            {
                if (erro == true)
                {
                    conex.Close();
                }
            }
        }

    }
}

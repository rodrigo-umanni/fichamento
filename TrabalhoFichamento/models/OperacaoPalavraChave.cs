using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace TrabalhoFichamento.models
{
    class OperacaoPalavraChave : Registro
    {
        public Boolean gravar(String  text)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Palavra_chave", this.connection.Conex);

                string insert = @"INSERT INTO Palavra_chave VALUES(@id_fichamento, @palavra_chave)";
                SqlCommand cmd = new SqlCommand(insert, this.connection.Conex);

                // Define os parâmetros de comando com valores


                string query2 = "select MAX(id_fichamento) from Fichamento";
                SqlCommand cmd2 = new SqlCommand(query2, this.connection.Conex);
                SqlDataReader reader = cmd2.ExecuteReader();
                reader.Read();

                //cmd.Parameters.AddWithValue("@id_chave", reader.GetInt32(0));
                cmd.Parameters.AddWithValue("@id_fichamento", reader.GetInt32(0));
                reader.Close();
                cmd.Parameters.AddWithValue("@palavra_chave", text);

                //TODO COLOCAR ID NA PALAVRA CHAVE
                //DA.InsertCommand = cmd;
                //DA.InsertCommand.ExecuteNonQuery();

                
                //MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Erro ao cadastrar Autor");
                MessageBox.Show(ex.Message, "Erro ao cadastrar Palavra chave");
                return false;
            }

            return true;
        }
    }
}

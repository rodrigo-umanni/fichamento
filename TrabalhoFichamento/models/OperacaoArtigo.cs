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
    class OperacaoArtigo : Registro
    {
        public List<Artigo> listarTodos()
           {
            List<Artigo> Lista = new List<Artigo>();
            SqlDataReader reader = null;
            try
            {
                string select = @"select a.obra_id_obra, a.ISBN_ISSN from Artigo a,Obra o where
                a.obra_id_obra = o.id_obra;";
                SqlCommand cmd = new SqlCommand(select, this.connection.Conex);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Artigo a = new Artigo();
                    a.obra_id_obra = reader.GetInt32(0);
                    a.ISBN_ISSN = reader.GetString(1);

                    Lista.Add(a);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhum Artigo encontrado");
                return Lista;
            }
            finally
            {
                reader.Close();
            }
        }
    }
}

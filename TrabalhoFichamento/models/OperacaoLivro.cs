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
    class OperacaoLivro : Registro
    {
        public List<Livro> listarTodos()
        {
            List<Livro> Lista = new List<Livro>();
            SqlDataReader reader = null;
            try
            {
                string select = @"select l.editora, l.id_obra_livro,l.obra_id_obra from Obra o,Livro l where
                    o.id_obra = l.obra_id_obra order by l.edicao ASC;";
                SqlCommand cmd = new SqlCommand(select, this.connection.Conex);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Livro Livro = new Livro();
                    Livro.editora = reader.GetString(0);
                    Livro.obra_id_obra = reader.GetInt32(2);
                    Livro.id_obra_livro = reader.GetInt32(1);

                    Lista.Add(Livro);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhuma Livro encontrado");
                return Lista;
            }
            finally
            {
                reader.Close();
            }
        }
    }
}

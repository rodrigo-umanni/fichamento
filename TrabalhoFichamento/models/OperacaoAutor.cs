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
    class OperacaoAutor : Registro
    {
        public List<Obra> listarTodosSobrenome()
        {
            List<Obra> Lista = new List<Obra>();
            SqlDataReader reader = null;
            try
            {
                string select = @"SELECT id_autor_de_obra, sobrenome FROM Autor_de_obra ORDER BY titulo ASC;";
                SqlCommand cmd = new SqlCommand(select, this.connection.Conex);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Obra Obra = new Obra();
                    Obra.id_obra = reader.GetInt32(0);
                    Obra.titulo = reader.GetString(1);

                    Lista.Add(Obra);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhuma Obra encontrado");
                return Lista;
            }
            finally
            {
                reader.Close();
            }
        }

        public List<Autor> listarTodos()
        {
            List<Autor> Lista = new List<Autor>();
            SqlDataReader reader = null;
            try
            {
                string select = @"SELECT id_autor_de_obra, nome FROM Autor_de_obra ORDER BY nome ASC;";
                SqlCommand cmd = new SqlCommand(select, this.connection.Conex);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Autor Autor = new Autor();
                    Autor.id_autor_de_obra = reader.GetInt32(0);
                    Autor.nome = reader.GetString(1);

                    Lista.Add(Autor);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhum Autor encontrado");
                return Lista;
            }
            finally
            {
                reader.Close();
            }
        }

        public Boolean gravarAutorObra(Int64 id_obra, Int64 id_autor)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Autor_de_obra", this.connection.Conex);

                SqlCommand cmd = new SqlCommand("pInsAutor_de_obra02", this.connection.Conex);
                cmd.CommandType = CommandType.StoredProcedure;
                /*
                *   @obra_id_obra		INT,
                    @autor_de_obra_id_autor_de_obra INT
                * */
                cmd.Parameters.AddWithValue("@obra_id_obra", id_obra);
                cmd.Parameters.AddWithValue("@autor_de_obra_id_autor_de_obra", id_autor);

                DA.InsertCommand = cmd;
                DA.InsertCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao gravar");
                //MessageBox.Show("Erro ao gravar");
                return false;
            }

            return true;
        }
   }
}
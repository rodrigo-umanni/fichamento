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
    class OperacaoObjeto : Registro
    {
        public List<Objeto> listarTodos()
        {
            List<Objeto> Lista = new List<Objeto>();
            SqlDataReader reader = null;
            try
            {
                string select = @"SELECT id_objeto, descricao FROM Objeto ORDER BY descricao ASC;";
                SqlCommand cmd = new SqlCommand(select, this.connection.Conex);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Objeto Objeto = new Objeto();
                    Objeto.id_objeto = reader.GetInt32(0);
                    Objeto.Descricao = reader.GetString(1);

                    Lista.Add(Objeto);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhuma Objeto encontrado");
                return Lista;
            }
            finally
            {
                reader.Close();
            }
        }
        //Cadastrar Modalidade
        public Boolean gravar(Objeto objeto)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Objeto", this.connection.Conex);


                string insert = @"INSERT INTO Objeto(descricao, status)VALUES(@descricao,@status)";
                SqlCommand cmd = new SqlCommand(insert, this.connection.Conex);

                // Define os parâmetros de comando com valores

                cmd.Parameters.AddWithValue("@descricao", objeto.Descricao);
                cmd.Parameters.AddWithValue("@status", objeto.Status);

                DA.InsertCommand = cmd;
                DA.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Erro ao cadastrar Modalidade");
                MessageBox.Show("Erro ao cadastrar Objeto");
                return false;
            }

            return true;
        }
        //Alteração do Objeto
        public Boolean alterar(Objeto modalidade)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Objeto", this.connection.Conex);


                string update = @"UPDATE Modalidade SET nome = @descricao status = @status WHERE id_modalidade = @id";
                SqlCommand cmd = new SqlCommand(update, this.connection.Conex);

                // Define os parâmetros de comando com valores

                cmd.Parameters.AddWithValue("@nome", modalidade.Descricao);
                cmd.Parameters.AddWithValue("@id", modalidade.id_objeto);
                cmd.Parameters.AddWithValue("@status", modalidade.Status);

                DA.InsertCommand = cmd;
                DA.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Alterado com sucesso");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Erro ao gravar");
                MessageBox.Show("Erro ao alterar");
                return false;
            }

            return true;
        }
    }
}

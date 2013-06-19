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
    class OperacaoFormaDeEstudo : Registro
    {
        public List<FormaDeEstudo> listarTodos()
        {
            List<FormaDeEstudo> Lista = new List<FormaDeEstudo>();
            SqlDataReader reader = null;
            try
            {
                string select = @"SELECT id_forma_de_estudo, descricao FROM Forma_de_estudo ORDER BY descricao ASC;";
                SqlCommand cmd = new SqlCommand(select, this.connection.Conex);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    FormaDeEstudo FormaDeEstudo = new FormaDeEstudo();
                    FormaDeEstudo.id_forma_de_estudo = reader.GetInt32(0);
                    FormaDeEstudo.Descricao = reader.GetString(1);

                    Lista.Add(FormaDeEstudo);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhuma FormaDeEstudo encontrado");
                return Lista;
            }
            finally
            {
                reader.Close();
            }
        }
        //Cadastrar Forma de Estudo
        public Boolean gravar(FormaDeEstudo forma)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Forma_de_Estudo", this.connection.Conex);


                string insert = @"INSERT INTO Modalidade(descricao, status)VALUES(@descricao,@status)";
                SqlCommand cmd = new SqlCommand(insert, this.connection.Conex);

                // Define os parâmetros de comando com valores

                cmd.Parameters.AddWithValue("@descricao", forma.Descricao);
                cmd.Parameters.AddWithValue("@status", forma.Status);

                DA.InsertCommand = cmd;
                DA.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Erro ao cadastrar Modalidade");
                MessageBox.Show("Erro ao cadastrar Forma de Estudo");
                return false;
            }

            return true;
        }
        //Alteração da Forma de Estudo
        public Boolean alterar(FormaDeEstudo modalidade)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Forma_de_estudo", this.connection.Conex);


                string update = @"UPDATE Forma_de_estudo e SET nome = @descricao status = @status WHERE id_modalidade = @id";
                SqlCommand cmd = new SqlCommand(update, this.connection.Conex);

                // Define os parâmetros de comando com valores

                cmd.Parameters.AddWithValue("@nome", modalidade.Descricao);
                cmd.Parameters.AddWithValue("@id", modalidade.id_forma_de_estudo);
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

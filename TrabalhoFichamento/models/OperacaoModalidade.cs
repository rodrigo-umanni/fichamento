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
    class OperacaoModalidade : Registro
    {
        public List<Modalidade> listarTodos()
        {
            List<Modalidade> Lista = new List<Modalidade>();
            SqlDataReader reader = null;
            try
            {
                string select = @"SELECT id_modalidade, descricao FROM Modalidade ORDER BY descricao ASC;";
                SqlCommand cmd = new SqlCommand(select, this.connection.Conex);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Modalidade Modalidade = new Modalidade();
                    Modalidade.id_modalidade = reader.GetInt32(0);
                    Modalidade.Descricao = reader.GetString(1);

                    Lista.Add(Modalidade);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Nenhuma Modalidade encontrado");
                return Lista;
            }
            finally
            {
                reader.Close();
            }
        }
        //Cadastrar Modalidade
        public Boolean gravar(Modalidade modalidade)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Modalidade", this.connection.Conex);


                string insert = @"INSERT INTO Modalidade(descricao, status)VALUES(@descricao,@status)";
                SqlCommand cmd = new SqlCommand(insert, this.connection.Conex);

                // Define os parâmetros de comando com valores
                
                cmd.Parameters.AddWithValue("@descricao", modalidade.Descricao);
                cmd.Parameters.AddWithValue("@status", modalidade.Status);

                DA.InsertCommand = cmd;
                DA.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Erro ao cadastrar Modalidade");
                MessageBox.Show("Erro ao cadastrar Modalidade");
                return false;
            }

            return true;
        }

        //Alteração da Modalidade
        public Boolean alterar(Modalidade modalidade)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Modalidade", this.connection.Conex);


                string update = @"UPDATE Modalidade SET nome = @descricao status = @status WHERE id_modalidade = @id";
                SqlCommand cmd = new SqlCommand(update, this.connection.Conex);

                // Define os parâmetros de comando com valores

                cmd.Parameters.AddWithValue("@nome", modalidade.Descricao);
                cmd.Parameters.AddWithValue("@id", modalidade.id_modalidade);
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


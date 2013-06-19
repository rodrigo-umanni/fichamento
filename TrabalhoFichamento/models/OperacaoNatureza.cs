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
    class OperacaoNatureza : Registro
    {
        public List<Natureza> listarTodos()
        {
            List<Natureza> Lista = new List<Natureza>();
            SqlDataReader reader = null;
            try
            {
                string select = @"SELECT id_natureza, nome FROM Natureza ORDER BY nome ASC;";
                SqlCommand cmd = new SqlCommand(select, this.connection.Conex);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Natureza natureza = new Natureza();
                    natureza.id_natureza = reader.GetInt32(0);
                    natureza.Nome = reader.GetString(1);

                    Lista.Add(natureza);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Nenhuma Natureza encontrado");
                return Lista;
            }
            finally
            {
                reader.Close();
            }
        }
        //Cadastrar Modalidade
        public Boolean gravar(Natureza natureza)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Natureza", this.connection.Conex);


                string insert = @"INSERT INTO Natureza(nome, status)VALUES(@nome,@status)";
                SqlCommand cmd = new SqlCommand(insert, this.connection.Conex);

                // Define os parâmetros de comando com valores

                cmd.Parameters.AddWithValue("@nome", natureza.Nome);
                cmd.Parameters.AddWithValue("@status", natureza.Status);

                DA.InsertCommand = cmd;
                DA.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Erro ao cadastrar Modalidade");
                MessageBox.Show("Erro ao cadastrar Natureza");
                return false;
            }

            return true;
        }

        //Alterar Natureza
        public Boolean alterar(Natureza natureza)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Natureza", this.connection.Conex);


                string update = @"UPDATE Natureza SET nome = @descricao status = @status WHERE id_modalidade = @id";
                SqlCommand cmd = new SqlCommand(update, this.connection.Conex);

                // Define os parâmetros de comando com valores

                cmd.Parameters.AddWithValue("@nome", natureza.Nome);
                cmd.Parameters.AddWithValue("@id", natureza.id_natureza);
                cmd.Parameters.AddWithValue("@status", natureza.Status);

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

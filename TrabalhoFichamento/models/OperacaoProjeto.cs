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
    class OperacaoProjeto : Registro
    {

        public Boolean gravar(Projeto project)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Projeto", this.connection.Conex);


                string insert = @"INSERT INTO Projeto(nome, data_abertura)VALUES(@nome,@data)";
                SqlCommand cmd = new SqlCommand(insert, this.connection.Conex);

                // Define os parâmetros de comando com valores
                //cmd.Parameters.AddWithValue("@id", 99);
                cmd.Parameters.AddWithValue("@nome", project.nome);
                cmd.Parameters.AddWithValue("@data", project.data_Abertura);

                DA.InsertCommand = cmd;
                DA.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Erro ao gravar");
                MessageBox.Show("Erro ao cadastrar Projeto");
                return false;
            }

            return true;
        }
        //SobrecargaBusca pelo nome e Data
        public List<Projeto> pesquisarProjeto(string nome, DateTime dataAbertura)
        {
            List<Projeto> Lista = new List<Projeto>();
            try
            {

                string select = @"SELECT id_projeto,nome,  data_abertura FROM Projeto WHERE nome = @nome and data_abertura = @data ";
                SqlCommand cmd = new SqlCommand(select, this.connection.Conex);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@data", dataAbertura);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Projeto projeto = new Projeto();
                    projeto.id_projeto = reader.GetInt32(0);
                    projeto.nome = reader.GetString(1);
                    projeto.data_Abertura = reader.GetDateTime(2);

                    Lista.Add(projeto);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Nenhum projeto encontrado");
                return Lista;
            }
            finally
            {
                this.connection.Conex.Close();
            }
        }
        //SobrecargaBusca pelo nome
        public List<Projeto> pesquisarProjeto(string nome)
        {
            List<Projeto> Lista = new List<Projeto>();
            try
            {
                string select = @"SELECT id_projeto,nome, data_abertura FROM Projeto WHERE nome = @nome ";
                SqlCommand cmd = new SqlCommand(select, this.connection.Conex);
                cmd.Parameters.AddWithValue("@nome", nome);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Projeto projeto = new Projeto();
                    projeto.id_projeto = reader.GetInt32(0);
                    projeto.nome = reader.GetString(1);
                    projeto.data_Abertura = reader.GetDateTime(2);

                    Lista.Add(projeto);
                }
                
                return Lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Nenhum projeto encontrado");
                return Lista;
            }
            /*finally
            {
                this.connection.Conex.Close();
            }*/
        }
        //SobrecargaBusca pela data
        public List<Projeto> pesquisarProjeto(DateTime dataAbertura)
        {
            List<Projeto> Lista = new List<Projeto>();
            try
            {
                string select = @"SELECT id_projeto,nome, data_abertura FROM Projeto WHERE data_abertura = @data ";
                SqlCommand cmd = new SqlCommand(select, this.connection.Conex);
                cmd.Parameters.AddWithValue("@data", dataAbertura);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Projeto projeto = new Projeto();
                    projeto.id_projeto = reader.GetInt32(0);
                    projeto.nome = reader.GetString(1);
                    projeto.data_Abertura = reader.GetDateTime(2);

                    Lista.Add(projeto);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Nenhum projeto encontrado");
                return Lista;
            }
            /*finally
            {
            this.connection.Conex.Close();
            }*/
        }

        public Boolean alterar(Projeto project)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Projeto", this.connection.Conex);


                string update = @"UPDATE Projeto SET nome = @nome WHERE id_projeto = @id";
                SqlCommand cmd = new SqlCommand(update, this.connection.Conex);

                // Define os parâmetros de comando com valores
                
                cmd.Parameters.AddWithValue("@nome", project.nome);
                cmd.Parameters.AddWithValue("@id", project.id_projeto);

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
        public Boolean delete(Projeto project)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Projeto", this.connection.Conex);


                string update = @"DELETE FROM Projeto WHERE id_projeto = @id ";
                SqlCommand cmd = new SqlCommand(update, this.connection.Conex);

                // Define os parâmetros de comando com valores

               
                cmd.Parameters.AddWithValue("@id", project.id_projeto);

                DA.InsertCommand = cmd;
                DA.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Excluído com sucesso");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Erro ao gravar");
                MessageBox.Show("Erro ao excluir");
                return false;
            }

            return true;
        }

        public List<Projeto> listarTodos()
        {
            List<Projeto> Lista = new List<Projeto>();
            SqlDataReader reader = null;
            try
            {
                string select = @"SELECT id_projeto, nome FROM Projeto ORDER BY nome ASC;";
                SqlCommand cmd = new SqlCommand(select, this.connection.Conex);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Projeto projeto = new Projeto();
                    projeto.id_projeto = reader.GetInt32(0);
                    projeto.nome = reader.GetString(1);

                    Lista.Add(projeto);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Nenhum projeto encontrado");
                return Lista;
            }
            finally {
                reader.Close();
            }
        }
    }

}

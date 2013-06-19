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
    class OperacaoFichamento : Registro
    {
        public int gravar(Fichamento fichamento)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Fichamento", this.connection.Conex);


                string insert = @"INSERT INTO Fichamento(id_projeto, resumo,id_natureza,id_modalidade,id_forma_estudo,
                id_objeto,resenha,citacoes,data_fichamento,id_obra)VALUES(@id_projeto, @resumo,@id_natureza,@id_modalidade,@id_forma_estudo,
                @id_objeto,@resenha,@citacoes,@data_fichamento,@id_obra)";
                SqlCommand cmd = new SqlCommand(insert, this.connection.Conex);

                // Define os parâmetros de comando com valores

                cmd.Parameters.AddWithValue("@id_projeto", fichamento.IdProjeto);
                cmd.Parameters.AddWithValue("@resumo", fichamento.Resumo);
                cmd.Parameters.AddWithValue("@id_natureza", fichamento.IdNatureza);
                cmd.Parameters.AddWithValue("@id_modalidade", fichamento.IdModalidade);
                cmd.Parameters.AddWithValue("@id_forma_estudo", fichamento.IdFormaEstudo);
                cmd.Parameters.AddWithValue("@id_objeto", fichamento.IdObjeto);
                cmd.Parameters.AddWithValue("@resenha", fichamento.Resenha);
                cmd.Parameters.AddWithValue("@citacoes", fichamento.Citacoes);
                cmd.Parameters.AddWithValue("@data_fichamento", fichamento.DataFichamento);
                cmd.Parameters.AddWithValue("@id_obra", fichamento.ObraIdObra);

                DA.InsertCommand = cmd;
                return (DA.InsertCommand.ExecuteNonQuery());
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao gravar");
                //MessageBox.Show("Erro ao gravar");
                return 0;
            }

            return 1;
        }

        public Boolean alterar(Fichamento fichamento)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Fichamento", this.connection.Conex);


                string alterar = @"UPDATE SET Fichamento resumo = @resumo,id_natureza = @id_natureza,id_modalidade = @id_modalidade,id_forma_estudo = @id_forma_estudo,
                id_objeto = @id_objeto,resenha = @resenha,citacoes =@citacoes ,data_fichamento";

                SqlCommand cmd = new SqlCommand(alterar, this.connection.Conex);

                // Define os parâmetros de comando com valores


                cmd.Parameters.AddWithValue("@resumo", fichamento.Resumo);
                cmd.Parameters.AddWithValue("@id_natureza", fichamento.IdNatureza);
                cmd.Parameters.AddWithValue("@id_modalidade", fichamento.IdModalidade);
                cmd.Parameters.AddWithValue("@id_forma_estudo", fichamento.IdFormaEstudo);
                cmd.Parameters.AddWithValue("@id_objeto", fichamento.IdObjeto);
                cmd.Parameters.AddWithValue("@resenha", fichamento.Resenha);
                cmd.Parameters.AddWithValue("@citacoes", fichamento.Citacoes);
                cmd.Parameters.AddWithValue("@data_fichamento", fichamento.DataFichamento);


                DA.InsertCommand = cmd;
                DA.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Alterado com sucesso");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Erro ao alterar o fichamento");
                MessageBox.Show("Erro ao alterar o fichamento");
                return false;
            }

            return true;
        }
    }
}

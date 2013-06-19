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
        public Boolean gravar(Fichamento fichamento)
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
                DA.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Inserido com sucesso");
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

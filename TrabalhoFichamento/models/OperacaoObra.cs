using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using TrabalhoFichamento.Entidades;
namespace TrabalhoFichamento.models
{
    class OperacaoObra : Registro
    {
        public Boolean gravar(Obra obra)
        {
            try
            {
                // Cria um objeto DataAdapter
                //SqlDataAdapter DA = new SqlDataAdapter("select * from Projeto", this.connection.Conex);


                string insert = @"INSERT INTO Obra(titulo,subtitulo,local_publicao, ano_publicacao)VALUES(@titulo,@subtitulo,@local,@ano)";
                SqlCommand cmd = new SqlCommand(insert, this.connection.Conex);

                // Define os parâmetros de comando com valores
                //cmd.Parameters.AddWithValue("@id", 9);
                cmd.Parameters.AddWithValue("@titulo", obra.titulo);
                cmd.Parameters.AddWithValue("@data", obra.subtitulo);
                cmd.Parameters.AddWithValue("@local", obra.local_publicacao);
                cmd.Parameters.AddWithValue("@ano", obra.ano_publicacao);

                //DA.InsertCommand = cmd;
                //DA.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Erro ao gravar");
                MessageBox.Show("Erro ao gravar");
                return false;
            }

            return true;
        }

        public List<Obra> pesquisarObra(string nome, DateTime dataAbertura)
        {
            List<Obra> Lista = new List<Obra>();
            try
            {

                string select = @"SELECT id_projeto,titulo,subtitulo, local_publicacao,ano_publicacao FROM Obra WHERE";
                SqlCommand cmd = new SqlCommand(select, this.connection.Conex);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@data", dataAbertura);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Obra obra = new Obra();
                    obra.id_obra = reader.GetInt32(0);
                    //obra.Nome = reader.GetString(1);
                    //obra.DataAbertura = Convert.ToString(reader.GetDateTime(2));

                    Lista.Add(obra);
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

        public List<Obra> listarTodos()
        {
            List<Obra> Lista = new List<Obra>();
            SqlDataReader reader = null;
            try
            {
                string select = @"SELECT id_obra, titulo FROM Obra ORDER BY titulo ASC;";
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

        public Boolean gravarLivro(Livro livro)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Obra", this.connection.Conex);

                SqlCommand cmd = new SqlCommand("pInsLivro01", this.connection.Conex);
                cmd.CommandType = CommandType.StoredProcedure;


                //string insert = @"INSERT INTO Obra(titulo,subtitulo,local_publicao, ano_publicacao)VALUES(@titulo,@subtitulo,@local,@ano)";
                //SqlCommand cmd = new SqlCommand(insert, this.connection.Conex);

                // Define os parâmetros de comando com valores
                //cmd.Parameters.AddWithValue("@id", 9);

                /*
                 * 
                 *  @titulo				VARCHAR(45),
                    @subtitulo			VARCHAR(45),
                    @local_publicacao	VARCHAR(45),
                    @ano_publicacao		INT,
                    @editora			VARCHAR(45),
                    @edicao				VARCHAR(45),
                    @obra_id_obra		INT = NULL OUT,
                    @id_obra_livro		INT = NULL OUT
                 * */
                cmd.Parameters.AddWithValue("@titulo", livro.titulo);
                cmd.Parameters.AddWithValue("@subtitulo", livro.subtitulo);
                cmd.Parameters.AddWithValue("@local_publicacao", livro.local_publicacao);
                cmd.Parameters.AddWithValue("@ano_publicacao", livro.ano_publicacao);
                cmd.Parameters.AddWithValue("@editora", livro.editora);
                cmd.Parameters.AddWithValue("@edicao", livro.edicao);
                cmd.Parameters.Add("@obra_id_obra", SqlDbType.Int);
                cmd.Parameters["@obra_id_obra"].Direction = ParameterDirection.Output;


                DA.InsertCommand = cmd;
                DA.InsertCommand.ExecuteNonQuery();

                livro.id_obra = (int)cmd.Parameters["@obra_id_obra"].Value;

                //MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao gravar");
                //MessageBox.Show("Erro ao gravar");
                return false;
            }

            return true;
        }

        public Boolean gravarArtigo(Artigo artigo)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Artigo", this.connection.Conex);

                SqlCommand cmd = new SqlCommand("pInsArtigo01", this.connection.Conex);
                cmd.CommandType = CommandType.StoredProcedure;


                //string insert = @"INSERT INTO Obra(titulo,subtitulo,local_publicao, ano_publicacao)VALUES(@titulo,@subtitulo,@local,@ano)";
                //SqlCommand cmd = new SqlCommand(insert, this.connection.Conex);

                // Define os parâmetros de comando com valores
                //cmd.Parameters.AddWithValue("@id", 9);

                /*
                 * 
                 *  @titulo					VARCHAR(45),
                    @subtitulo				VARCHAR(45),
                    @local_publicacao		VARCHAR(45),
                    @ano_publicacao			INT,
                    @nome_periodico_evento	VARCHAR(45),
                    @volume					INT,
                    @numero					VARCHAR(45),
                    @pagina_inicial			INT,
                    @pagina_final			INT,
                    @ISBN_ISSN				VARCHAR(45)
                 * */
                cmd.Parameters.AddWithValue("@titulo", artigo.titulo);
                cmd.Parameters.AddWithValue("@subtitulo", artigo.subtitulo);
                cmd.Parameters.AddWithValue("@local_publicacao", artigo.local_publicacao);
                cmd.Parameters.AddWithValue("@ano_publicacao", artigo.ano_publicacao);
                cmd.Parameters.AddWithValue("@nome_periodico_evento", artigo.periodico);
                cmd.Parameters.AddWithValue("@volume", artigo.volume);
                cmd.Parameters.AddWithValue("@numero", artigo.numero);
                cmd.Parameters.AddWithValue("@pagina_inicial", artigo.pagina_inical);
                cmd.Parameters.AddWithValue("@pagina_final", artigo.pagina_final);
                cmd.Parameters.AddWithValue("@ISBN_ISSN", artigo.ISBN_ISSN);
                cmd.Parameters.Add("@id_obra", SqlDbType.Int);
                cmd.Parameters["@id_obra"].Direction = ParameterDirection.Output;


                DA.InsertCommand = cmd;
                DA.InsertCommand.ExecuteNonQuery();

                artigo.id_obra = (int)cmd.Parameters["@id_obra"].Value;
                //MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao gravar");
                //MessageBox.Show("Erro ao gravar");
                return false;
            }

            return true;
        }


        public Boolean gravarTdm(Tdm tdm)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from TDM", this.connection.Conex);

                SqlCommand cmd = new SqlCommand("pInsTDM01", this.connection.Conex);
                cmd.CommandType = CommandType.StoredProcedure;


                //string insert = @"INSERT INTO Obra(titulo,subtitulo,local_publicao, ano_publicacao)VALUES(@titulo,@subtitulo,@local,@ano)";
                //SqlCommand cmd = new SqlCommand(insert, this.connection.Conex);

                // Define os parâmetros de comando com valores
                //cmd.Parameters.AddWithValue("@id", 9);

                /*
                 *  @titulo				VARCHAR(45),
                    @subtitulo			VARCHAR(45),
                    @local_publicacao	VARCHAR(45),
                    @ano_publicacao		INT,
                    @programa			VARCHAR(45),
                    @curso				VARCHAR(45),
                    @instituicao		VARCHAR(45),
                    @obra_id_obra		INT = NULL OUT
                 *  
                 * */
                cmd.Parameters.AddWithValue("@titulo", tdm.titulo);
                cmd.Parameters.AddWithValue("@subtitulo", tdm.subtitulo);
                cmd.Parameters.AddWithValue("@local_publicacao", tdm.local_publicacao);
                cmd.Parameters.AddWithValue("@ano_publicacao", tdm.ano_publicacao);
                cmd.Parameters.AddWithValue("@programa", tdm.programa);
                cmd.Parameters.AddWithValue("@curso", tdm.curso);
                cmd.Parameters.AddWithValue("@instituicao", tdm.instituicao);
                cmd.Parameters.Add("@obra_id_obra", SqlDbType.Int);
                cmd.Parameters["@obra_id_obra"].Direction = ParameterDirection.Output;


                DA.InsertCommand = cmd;
                DA.InsertCommand.ExecuteNonQuery();

                tdm.id_obra = (int)cmd.Parameters["@obra_id_obra"].Value;
                //MessageBox.Show("Inserido com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao gravar");
                //MessageBox.Show("Erro ao gravar");
                return false;
            }

            return true;
        }

        public Boolean gravarCapitulo(Capitulo capitulo)
        {
            try
            {
                // Cria um objeto DataAdapter
                SqlDataAdapter DA = new SqlDataAdapter("select * from Capitulo_livro", this.connection.Conex);

                SqlCommand cmd = new SqlCommand("pInsCapitulo_livro01", this.connection.Conex);
                cmd.CommandType = CommandType.StoredProcedure;


                //string insert = @"INSERT INTO Obra(titulo,subtitulo,local_publicao, ano_publicacao)VALUES(@titulo,@subtitulo,@local,@ano)";
                //SqlCommand cmd = new SqlCommand(insert, this.connection.Conex);

                // Define os parâmetros de comando com valores
                //cmd.Parameters.AddWithValue("@id", 9);

                /*
                 *  @titulo				VARCHAR(45),
                    @subtitulo			VARCHAR(45),
                    @local_publicacao	VARCHAR(45),
                    @ano_publicacao		INT,
                    @livro_id_obra		INT,
                    @livro_id_livro		INT,
                    @pagina_inicial		INT,
                    @pagina_final		INT,
                    @obra_id_obra		INT = NULL OUT
                 *  
                 * */
                cmd.Parameters.AddWithValue("@titulo", capitulo.titulo);
                cmd.Parameters.AddWithValue("@subtitulo", capitulo.subtitulo);
                cmd.Parameters.AddWithValue("@local_publicacao", capitulo.local_publicacao);
                cmd.Parameters.AddWithValue("@ano_publicacao", capitulo.ano_publicacao);
                cmd.Parameters.AddWithValue("@livro_id_obra", capitulo.obra_id_obra);
                cmd.Parameters.AddWithValue("@livro_id_livro", capitulo.id_obra_livro);
                cmd.Parameters.AddWithValue("@pagina_inicial", capitulo.pagina_inicial);
                cmd.Parameters.AddWithValue("@pagina_final", capitulo.pagina_final);
                cmd.Parameters.Add("@obra_id_obra", SqlDbType.Int);
                cmd.Parameters["@obra_id_obra"].Direction = ParameterDirection.Output;


                DA.InsertCommand = cmd;
                DA.InsertCommand.ExecuteNonQuery();

                capitulo.id_obra = (int)cmd.Parameters["@obra_id_obra"].Value;
                //MessageBox.Show("Inserido com sucesso");
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

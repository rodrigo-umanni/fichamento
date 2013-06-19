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
    class OperacaoTDM : Registro
    {
        public List<Entidades.Tdm> listarTodos()
        {
            List<Entidades.Tdm> Lista = new List<Entidades.Tdm>();
            SqlDataReader reader = null;
            try
            {
                string select = @"select t.obra_id_obra, t.curso from TDM t, Obra o where
                    t.obra_id_obra = o.id_obra;";
                SqlCommand cmd = new SqlCommand(select, this.connection.Conex);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Entidades.Tdm tdm = new Entidades.Tdm();
                    tdm.obra_id_obra = reader.GetInt32(0);
                    tdm.curso = reader.GetString(1);

                    Lista.Add(tdm);
                }

                return Lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nenhuma Tdm encontrado");
                return Lista;
            }
            finally
            {
                reader.Close();
            }
        }
    }
}

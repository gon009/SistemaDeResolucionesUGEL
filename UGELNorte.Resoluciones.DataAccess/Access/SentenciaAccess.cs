using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UGELNorte.Resoluciones.DataAccess.BDConexiones;
using UGELNorte.Resoluciones.DataAccess.Access;
using UGELNorte.Resoluciones.Core.Models;
using UGELNorte.Resoluciones.DataAccess.SQL;
using UGELNorte.Resoluciones.DataAccess;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace UGELNorte.Resoluciones.DataAccess.Access
{
    public class SentenciaAccess : ConnectionAccess, ISentenciaAccess
    {
        public bool AddSentencia(SentenciaModel sentencia)
        {
            using (SqlConnection openConnection = new SqlConnection(this.ConnectionString))
            {

                using (SqlCommand sqlcommand = new SqlCommand())
                {
                    sqlcommand.CommandType = CommandType.Text;
                    sqlcommand.CommandText = Scripts.SqlInsertSentencia;
                    sqlcommand.Connection = openConnection;

                    sqlcommand.Parameters.AddWithValue("@ExpedienteJudicial", sentencia.ExpedienteJudicial);
                    sqlcommand.Parameters.AddWithValue("@Sentencia", sentencia.Sentencia);

                    sqlcommand.Parameters.AddWithValue("@FechaSentencia", sentencia.FechaSentencia.ToShortDateString());
                    sqlcommand.Parameters.AddWithValue("@Monto", sentencia.Monto);

                    sqlcommand.Connection.Open();
                    var rowsAffected = sqlcommand.ExecuteNonQuery();
                    sqlcommand.Connection.Close();

                    return rowsAffected > 0;
                }
            }


        }
    }

}

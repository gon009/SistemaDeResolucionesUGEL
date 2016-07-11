using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using UGELNorte.Resoluciones.DataAccess.Access;
using UGELNorte.Resoluciones.Core.Models;
using UGELNorte.Resoluciones.DataAccess.SQL;
using UGELNorte.Resoluciones.DataAccess.BDConexiones;

namespace UGELNorte.Resoluciones.DataAccess.Access
{
    public class DocenteAccess : ConnectionAccess, IDocenteAccess
    {
        public bool AddDocente(DocenteModel docente)
        {
            using (SqlConnection openConnection = new SqlConnection(this.ConnectionString))
            {

                using (SqlCommand sqlcommand = new SqlCommand())
                {
                    sqlcommand.CommandType = CommandType.Text;
                    sqlcommand.CommandText = Scripts.SqlInsertDocente;
                    sqlcommand.Connection = openConnection;

                    sqlcommand.Parameters.AddWithValue("@DNI",(int)docente.DNI);
                    sqlcommand.Parameters.AddWithValue("@Nombres", docente.Nombres);
                    sqlcommand.Parameters.AddWithValue("@ApellidoPaterno", docente.apellidoPaterno);
                    sqlcommand.Parameters.AddWithValue("@ApellidoMaterno", docente.apellidoMaterno);
                 
                    sqlcommand.Connection.Open();
                    var rowsAffected = sqlcommand.ExecuteNonQuery();
                    sqlcommand.Connection.Close();

                    return rowsAffected > 0;
                }
            }


        }
    }
}

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
using System.Data.OleDb;

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

                    sqlcommand.Parameters.AddWithValue("@DNI",(Int64)docente.DNI);
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

        public bool UpdateDocente(DocenteModel docente)
        {
            using (SqlConnection openConnection = new SqlConnection(this.ConnectionString))
            {

                using (SqlCommand sqlcommand = new SqlCommand())
                {
                    sqlcommand.CommandType = CommandType.Text;
                    sqlcommand.CommandText = Scripts.sqlUpdateDocente;
                    sqlcommand.Connection = openConnection;

                    sqlcommand.Parameters.AddWithValue("@DNI", (Int64)docente.DNI);
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

        public DataTable GetAllDocentes()
        {

            DataTable dataTable = new DataTable();

            using (SqlDataAdapter oleDbDataAdapter = new SqlDataAdapter())
            {
                // Create the command and set its properties
                oleDbDataAdapter.SelectCommand = new SqlCommand();
                oleDbDataAdapter.SelectCommand.Connection = new SqlConnection(this.ConnectionString);
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object
                oleDbDataAdapter.SelectCommand.CommandText = Scripts.SqlGetAllDocentes;

                // Fill the datatable from adapter
                oleDbDataAdapter.Fill(dataTable);
            }

            return dataTable;

        }

        public DataRow GetDocenteByDNI(string DNI)
        {
            DataTable dataTable = new DataTable();
            DataRow dataRow;

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
            {
                // Create the command and set its properties
                dataAdapter.SelectCommand = new SqlCommand();
                dataAdapter.SelectCommand.Connection = new SqlConnection(this.ConnectionString);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                dataAdapter.SelectCommand.CommandText = Scripts.sqlGetDocenteByDNI;

                // Add the parameter to the parameter collection
                dataAdapter.SelectCommand.Parameters.AddWithValue("@DNI", DNI);

                // Fill the datatable From adapter
                dataAdapter.Fill(dataTable);

                // Get the datarow from the table
                dataRow = dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;

                return dataRow;
            }
        }

    }
}

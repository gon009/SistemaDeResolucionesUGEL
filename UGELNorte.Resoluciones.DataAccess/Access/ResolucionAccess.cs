using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UGELNorte.Resoluciones.DataAccess.BDConexiones;
using UGELNorte.Resoluciones.DataAccess.Access;
using UGELNorte.Resoluciones.Core.Models;
using UGELNorte.Resoluciones.DataAccess.SQL;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace UGELNorte.Resoluciones.DataAccess
{
    public class ResolucionAccess : ConnectionAccess, IResolucionAccess
    {
        public DataRow GetResolucionByNro(string NroResolucion)
        {
            DataTable dataTable = new DataTable();
            DataRow dataRow;

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
            {
                // Create the command and set its properties
                dataAdapter.SelectCommand = new SqlCommand();
                dataAdapter.SelectCommand.Connection = new SqlConnection(this.ConnectionString);
                dataAdapter.SelectCommand.CommandType = CommandType.Text;
                dataAdapter.SelectCommand.CommandText = Scripts.sqlGetResolucionByNro;

                // Add the parameter to the parameter collection
                dataAdapter.SelectCommand.Parameters.AddWithValue("@NroResolucion", NroResolucion);

                // Fill the datatable From adapter
                dataAdapter.Fill(dataTable);

                // Get the datarow from the table
                dataRow = dataTable.Rows.Count > 0 ? dataTable.Rows[0] : null;

                return dataRow;
            }
        }

        public DataTable GetAllResoluciones()
        {
            
            DataTable dataTable = new DataTable();
            
            using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                oleDbDataAdapter.SelectCommand = new OleDbCommand();
                oleDbDataAdapter.SelectCommand.Connection = new OleDbConnection(this.ConnectionString);
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object
                oleDbDataAdapter.SelectCommand.CommandText = Scripts.SqlGetAllResolucion;

                // Fill the datatable from adapter
                oleDbDataAdapter.Fill(dataTable);
            }
            
            return dataTable;
            
        }


        public DataTable SearchResolucion(object NroProyecto, object NroResolucion)
        {
            DataTable dataTable = new DataTable();

            using (SqlDataAdapter sqlDbDataAdapter = new SqlDataAdapter())
            {

                // Create the command and set its properties
                sqlDbDataAdapter.SelectCommand = new SqlCommand();
                sqlDbDataAdapter.SelectCommand.Connection = new SqlConnection(this.ConnectionString);
                sqlDbDataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object
                sqlDbDataAdapter.SelectCommand.CommandText = string.Format(Scripts.SqlSearchResolucion);

                // Add the input parameters to the parameter collection
                sqlDbDataAdapter.SelectCommand.Parameters.AddWithValue("@NroResolucion", NroResolucion == null ? DBNull.Value : NroResolucion);
                sqlDbDataAdapter.SelectCommand.Parameters.AddWithValue("@NroProyecto", NroProyecto == null ? DBNull.Value : NroProyecto);

                // Fill the table from adapter
                sqlDbDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }


        public bool AddResolucion(ResolucionModel resolucion, SentenciaModel sentencia)
        {
            using (SqlConnection openConnection = new SqlConnection(this.ConnectionString))
            {
               
                using (SqlCommand sqlcommand = new SqlCommand())
                {
                    sqlcommand.CommandType = CommandType.Text;
                    sqlcommand.CommandText = Scripts.SqlInsertResolucion;
                    sqlcommand.Connection = openConnection;

                    sqlcommand.Parameters.AddWithValue("@NroResolucion", resolucion.NroResolucion);
                    sqlcommand.Parameters.AddWithValue("@NroProyecto", resolucion.NroProyecto);
                    sqlcommand.Parameters.AddWithValue("@TipoResolucion", (int)resolucion.TipoResolucion);
                    sqlcommand.Parameters.AddWithValue("@UGEL", (int)resolucion.TipoUGEL);
                    sqlcommand.Parameters.AddWithValue("@InstitucionEducativa", resolucion.InstitucionEducativa);
                    sqlcommand.Parameters.AddWithValue("@DNI", resolucion.DNI);
                    sqlcommand.Parameters.AddWithValue("@Situacion", (int)resolucion.SituacionResolucion);
                    sqlcommand.Parameters.AddWithValue("@Concepto", resolucion.ConceptoResolucion);

                    sqlcommand.Parameters.AddWithValue("@ExpedienteJudicial", sentencia.ExpedienteJudicial);
                    sqlcommand.Parameters.AddWithValue("@Sentencia", sentencia.Sentencia);
                    sqlcommand.Parameters.AddWithValue("@FechaSentencia", sentencia.FechaSentencia);
                    sqlcommand.Parameters.AddWithValue("@Monto", sentencia.Monto);

                    sqlcommand.Connection.Open();
                    var rowsAffected = sqlcommand.ExecuteNonQuery();
                    sqlcommand.Connection.Close();

                    return rowsAffected > 0;
                }
            }

      
        }


        public bool UpdateResolucion(ResolucionModel resolucion, SentenciaModel sentencia)
        {
            using (SqlConnection openConnection = new SqlConnection(this.ConnectionString))
            {

                using (SqlCommand sqlcommand = new SqlCommand())
                {
                    sqlcommand.CommandType = CommandType.Text;
                    sqlcommand.CommandText = Scripts.sqlUpdateResolucion;
                    sqlcommand.Connection = openConnection;

                    sqlcommand.Parameters.AddWithValue("@NroResolucion", resolucion.NroResolucion);
                    sqlcommand.Parameters.AddWithValue("@NroProyecto", resolucion.NroProyecto);
                    sqlcommand.Parameters.AddWithValue("@TipoResolucion", (int)resolucion.TipoResolucion);
                    sqlcommand.Parameters.AddWithValue("@UGEL", (int)resolucion.TipoUGEL);
                    sqlcommand.Parameters.AddWithValue("@InstitucionEducativa", resolucion.InstitucionEducativa);
                    sqlcommand.Parameters.AddWithValue("@DNI", resolucion.DNI);
                    sqlcommand.Parameters.AddWithValue("@Situacion", (int)resolucion.SituacionResolucion);
                    sqlcommand.Parameters.AddWithValue("@Concepto", resolucion.ConceptoResolucion);

                    sqlcommand.Parameters.AddWithValue("@ExpedienteJudicial", sentencia.ExpedienteJudicial);
                    sqlcommand.Parameters.AddWithValue("@Sentencia", sentencia.Sentencia);
                    sqlcommand.Parameters.AddWithValue("@FechaSentencia", sentencia.FechaSentencia);
                    sqlcommand.Parameters.AddWithValue("@Monto", sentencia.Monto);

                    sqlcommand.Connection.Open();
                    var rowsAffected = sqlcommand.ExecuteNonQuery();
                    sqlcommand.Connection.Close();

                    return rowsAffected > 0;
                }
            }

      
        }

        public bool DeleteResolucion(string resolucion)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                // Set the command object properties
                sqlCommand.Connection = new SqlConnection(this.ConnectionString);
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = Scripts.sqlDeleteResolucion;

                // Add the input parameter to the parameter collection
                sqlCommand.Parameters.AddWithValue("@NroResolucion", resolucion);

                // Open the connection, execute the query and close the connection
                sqlCommand.Connection.Open();
                var rowsAffected = sqlCommand.ExecuteNonQuery();
                sqlCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }
    }
}

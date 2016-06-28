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

namespace UGELNorte.Resoluciones.DataAccess
{
    public class ResolucionAccess : ConnectionAccess, IResolucionAccess
    {
        public DataRow GetResolucionByNro(string NroResolucion)
        {
            DataTable dataTable = new DataTable();
            DataRow dataRow;

            using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                dataAdapter.SelectCommand = new OleDbCommand();
                dataAdapter.SelectCommand.Connection = new OleDbConnection(this.ConnectionString);
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

        public DataTable SearchResolucion(object NroProyecto, object NroResolucion, string operand)
        {
            DataTable dataTable = new DataTable();

            using (OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter())
            {
                // Create the command and set its properties
                oleDbDataAdapter.SelectCommand = new OleDbCommand();
                oleDbDataAdapter.SelectCommand.Connection = new OleDbConnection(this.ConnectionString);
                oleDbDataAdapter.SelectCommand.CommandType = CommandType.Text;

                // Assign the SQL to the command object
                oleDbDataAdapter.SelectCommand.CommandText = string.Format(Scripts.SqlSearchResolucion, operand);

                // Add the input parameters to the parameter collection
                oleDbDataAdapter.SelectCommand.Parameters.AddWithValue("@NroResolucion", NroResolucion == null ? DBNull.Value : NroResolucion);
                oleDbDataAdapter.SelectCommand.Parameters.AddWithValue("@NroProyecto", NroProyecto == null ? DBNull.Value : NroProyecto);

                // Fill the table from adapter
                oleDbDataAdapter.Fill(dataTable);
            }

            return dataTable;
        }


        public bool AddResolucion(ResolucionModel resolucion)
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand())
            {
                // Set the command object properties
                oleDbCommand.Connection = new OleDbConnection(this.ConnectionString);
                oleDbCommand.CommandType = CommandType.Text;
                oleDbCommand.CommandText = Scripts.SqlInsertResolucion;

                // Add the input parameters to the parameter collection
                oleDbCommand.Parameters.AddWithValue("@NroResolucion", resolucion.NroResolucion);
                oleDbCommand.Parameters.AddWithValue("@NroProyecto", resolucion.NroProyecto);
                oleDbCommand.Parameters.AddWithValue("@TipoResolucion", (int)resolucion.TipoResolucion);
                oleDbCommand.Parameters.AddWithValue("@UGEL", (int)resolucion.TipoUGEL);
                oleDbCommand.Parameters.AddWithValue("@InstitucionEducativa", resolucion.InstitucionEducativa);
                oleDbCommand.Parameters.AddWithValue("@DNI", resolucion.DNI);
                oleDbCommand.Parameters.AddWithValue("@Situacion", (int)resolucion.SituacionResolucion);
                oleDbCommand.Parameters.AddWithValue("@Concepto", resolucion.ConceptoResolucion);
                oleDbCommand.Parameters.AddWithValue("@ExpedienteJudicial", resolucion.ExpedienteJudicial);
             

                // Open the connection, execute the query and close the connection
                oleDbCommand.Connection.Open();
                var rowsAffected = oleDbCommand.ExecuteNonQuery();
                oleDbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }


        public bool UpdateResolucion(ResolucionModel resolucion)
        {
            using (OleDbCommand dbCommand = new OleDbCommand())
            {
                // Set the command object properties
                dbCommand.Connection = new OleDbConnection(this.ConnectionString);
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandText = Scripts.sqlUpdateResolucion;

                // Add the input parameters to the parameter collection
                dbCommand.Parameters.AddWithValue("@NroResolucion", resolucion.NroResolucion);
                dbCommand.Parameters.AddWithValue("@NroProyecto", resolucion.NroProyecto);
                dbCommand.Parameters.AddWithValue("@TipoResolucion", (int)resolucion.TipoResolucion);
                dbCommand.Parameters.AddWithValue("@UGEL", (int)resolucion.TipoUGEL);
                dbCommand.Parameters.AddWithValue("@InstitucionEducativa", resolucion.InstitucionEducativa);
                dbCommand.Parameters.AddWithValue("@DNI", resolucion.DNI);
                dbCommand.Parameters.AddWithValue("@Situacion", (int)resolucion.SituacionResolucion);
                dbCommand.Parameters.AddWithValue("@Concepto", resolucion.ConceptoResolucion);
                dbCommand.Parameters.AddWithValue("@ExpedienteJudicial", resolucion.ExpedienteJudicial);
         

                // Open the connection, execute the query and close the connection
                dbCommand.Connection.Open();
                var rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }

        public bool DeleteResolucion(string resolucion)
        {
            using (OleDbCommand dbCommand = new OleDbCommand())
            {
                // Set the command object properties
                dbCommand.Connection = new OleDbConnection(this.ConnectionString);
                dbCommand.CommandType = CommandType.Text;
                dbCommand.CommandText = Scripts.sqlDeleteResolucion;

                // Add the input parameter to the parameter collection
                dbCommand.Parameters.AddWithValue("@NroResolucion", resolucion);

                // Open the connection, execute the query and close the connection
                dbCommand.Connection.Open();
                var rowsAffected = dbCommand.ExecuteNonQuery();
                dbCommand.Connection.Close();

                return rowsAffected > 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UGELNorte.Resoluciones.DataAccess.BDConexiones;
using UGELNorte.Resoluciones.DataAccess.Access;
using UGELNorte.Resoluciones.Core.Models;
using System.Data.OleDb;

namespace UGELNorte.Resoluciones.DataAccess
{
    public class ResolucionAccess : ConnectionAccess, IResolucionAccess
    {
        public DataRow GetResolucionByNro(string NroResolucion)
        {
            DataTable dataTable = new DataTable();
            DataRow dataRow = null; 


            return dataRow;
        }

        public DataTable GetAllResoluciones()
        {
            DataTable dataTable = new DataTable();


            return dataTable;
        }

        public DataTable SearchResolucion(string NroProyecto, string NroResolucion)
        {
            DataTable dataTable = new DataTable();


            return dataTable;
        }


        public bool AddResolucion(ResolucionModel resolucion)
        {
            using (OleDbCommand oleDbCommand = new OleDbCommand())
            {
              
                var rowsAffected = oleDbCommand.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }


        public bool UpdateResolucion(ResolucionModel resolucion)
        {
            using (OleDbCommand dbCommand = new OleDbCommand())
            {
                
                var rowsAffected = dbCommand.ExecuteNonQuery();
               

                return rowsAffected > 0;
            }
        }

        public bool DeleteResolucion(string resolucion)
        {
            using (OleDbCommand dbCommand = new OleDbCommand())
            {
                
                var rowsAffected = dbCommand.ExecuteNonQuery();
              

                return rowsAffected > 0;
            }
        }
    }
}

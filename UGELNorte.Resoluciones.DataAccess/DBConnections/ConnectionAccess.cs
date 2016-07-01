using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Collections.Specialized;
namespace UGELNorte.Resoluciones.DataAccess.BDConexiones
{

  
    public abstract class ConnectionAccess
    {
        
    
        protected string ConnectionString
        {
            get
            {

                 return ConfigurationManager
                      .ConnectionStrings["DBResolucionesConnectionString"]
                      .ConnectionString;
                      
                //return ConfigurationManager.AppSettings["connectionStringDB"];

                //return ("Provider=SQLNCLI11; Data Source=localhost;Initial Catalog=DBResoluciones;Integrated Security=SSPI");



            }
        }
    }

}

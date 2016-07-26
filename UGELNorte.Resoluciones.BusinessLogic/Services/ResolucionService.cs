using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UGELNorte.Resoluciones.DataAccess.Access;
using UGELNorte.Resoluciones.DataAccess;
using UGELNorte.Resoluciones.Core.Models;
namespace UGELNorte.Resoluciones.BusinessLogic.Services
{
    public class ResolucionService : IResolucionService
    {
        private IResolucionAccess resolucionAccess;

        public ResolucionService()
        {
            this.resolucionAccess = new ResolucionAccess();
        }

        public DataRow GetResolucionByNro(string NroResolucion)
        {
            return this.resolucionAccess.GetResolucionByNro(NroResolucion);
        }

        public DataTable GetAllResoluciones()
        {
            return this.resolucionAccess.GetAllResoluciones();
        }

        public DataTable SearchResolucion(object NroResolucion, object NroProyecto)
        {
            return this.resolucionAccess.SearchResolucion(NroProyecto, NroResolucion);
        }

        public bool RegisterResolucion(ResolucionModel resolucion, SentenciaModel sentencia)
        {
            return this.resolucionAccess.AddResolucion(resolucion,sentencia);
        }

        public bool UpdateResolucion(ResolucionModel resolucion, SentenciaModel sentencia )
        {
            return this.resolucionAccess.UpdateResolucion(resolucion, sentencia);
        }

        public bool DeleteResolucion(string resolucion)
        {
            return this.resolucionAccess.DeleteResolucion(resolucion);
        }
    }
}

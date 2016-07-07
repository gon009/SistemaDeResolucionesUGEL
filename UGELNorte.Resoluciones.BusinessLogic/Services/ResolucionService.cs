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

        public bool RegisterResolucion(ResolucionModel resolucion)
        {
            return this.resolucionAccess.AddResolucion(resolucion);
        }

        public bool UpdateResolucion(ResolucionModel resolucion)
        {
            return this.resolucionAccess.UpdateResolucion(resolucion);
        }

        public bool DeleteResolucion(string resolucion)
        {
            return this.resolucionAccess.DeleteResolucion(resolucion);
        }
    }
}

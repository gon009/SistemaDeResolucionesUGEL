using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UGELNorte.Resoluciones.Core.Models;
using UGELNorte.Resoluciones.DataAccess.Access;
using UGELNorte.Resoluciones.DataAccess;
using System.Data;

namespace UGELNorte.Resoluciones.BusinessLogic.Services
{
    public class DocenteService : IDocenteService
    {
        private IDocenteAccess docenteAccess;

        public DocenteService()
        {
            this.docenteAccess = new DocenteAccess();
        }
        public bool RegisterDocente(DocenteModel docente)
        {
            return this.docenteAccess.AddDocente(docente);
        }

        public bool UpdateDocente(DocenteModel docente)
        {
            return this.docenteAccess.UpdateDocente(docente);
        }

        public DataTable GetAllDocentes()
        {
            return this.docenteAccess.GetAllDocentes();
        }

        public DataRow GetDocenteByDNI(string DNI)
        {
            return this.docenteAccess.GetDocenteByDNI(DNI);

        }
    }
}

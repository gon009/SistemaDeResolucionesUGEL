using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UGELNorte.Resoluciones.Core.Models;

namespace UGELNorte.Resoluciones.BusinessLogic.Services
{
    public class DocenteService : IDocenteService
    {
        private IDocenteService docenteAccess;

        public bool RegisterDocente(DocenteModel docente)
        {

            return this.docenteAccess.RegisterDocente(docente);
        }
    }
}

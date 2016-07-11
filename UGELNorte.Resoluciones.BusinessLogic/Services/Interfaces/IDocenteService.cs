using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UGELNorte.Resoluciones.Core.Models;

namespace UGELNorte.Resoluciones.BusinessLogic.Services
{
    public interface IDocenteService
    {
        bool RegisterDocente(DocenteModel docente);

    }
}

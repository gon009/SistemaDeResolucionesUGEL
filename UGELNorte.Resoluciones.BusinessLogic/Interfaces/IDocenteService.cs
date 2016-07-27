using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UGELNorte.Resoluciones.Core.Models;

namespace UGELNorte.Resoluciones.BusinessLogic.Services
{
    public interface IDocenteService
    {
        bool RegisterDocente(DocenteModel docente);

        bool UpdateDocente(DocenteModel docente);

        DataTable GetAllDocentes();

        DataRow GetDocenteByDNI(string DNI);

    }
}

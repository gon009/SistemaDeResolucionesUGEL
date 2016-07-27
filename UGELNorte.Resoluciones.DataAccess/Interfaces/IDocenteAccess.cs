using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UGELNorte.Resoluciones.Core.Models;

namespace UGELNorte.Resoluciones.DataAccess.Access
{
    public interface IDocenteAccess
    {
        bool AddDocente(DocenteModel docente);

        bool UpdateDocente(DocenteModel docente);

        DataTable GetAllDocentes();

        DataRow GetDocenteByDNI(string DNI);
    }
}

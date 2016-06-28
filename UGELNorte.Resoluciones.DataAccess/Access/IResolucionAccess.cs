using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UGELNorte.Resoluciones.Core.Models;

namespace UGELNorte.Resoluciones.DataAccess.Access
{
    public interface IResolucionAccess
    {
        DataRow GetResolucionByNro(string NroResolucion);

        DataTable GetAllResoluciones();

        DataTable SearchResolucion(object NroProyecto, object NroResolucion , string operand);

        bool AddResolucion(ResolucionModel resolucion);

        bool UpdateResolucion(ResolucionModel resolucion);

        bool DeleteResolucion(string resolucion);
    }
}

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

        DataTable SearchResolucion(object NroProyecto, object NroResolucion);

        bool AddResolucion(ResolucionModel resolucion, SentenciaModel sentencia);

        bool UpdateResolucion(ResolucionModel resolucion, SentenciaModel sentencia);

        bool DeleteResolucion(string resolucion);
    }
}

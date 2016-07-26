using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using UGELNorte.Resoluciones.DataAccess.Access;
using UGELNorte.Resoluciones.Core.Models;
namespace UGELNorte.Resoluciones.BusinessLogic.Services
{
    public interface IResolucionService
    {
        DataRow GetResolucionByNro(string NroResolucion);

        DataTable GetAllResoluciones();

        DataTable SearchResolucion(object NroProyecto, object NroResolucion);

        bool RegisterResolucion(ResolucionModel resolucion, SentenciaModel sentencia);

        bool UpdateResolucion(ResolucionModel resolucion, SentenciaModel sentencia);

        bool DeleteResolucion(string resolucion);


    }
}

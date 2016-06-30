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

        DataTable SearchResolucion(object NroProyecto, object NroResolucion , string operand);

        bool RegisterResolucion(ResolucionModel resolucion);

        bool UpdateResolucion(ResolucionModel resolucion);

        bool DeleteResolucion(string resolucion);


    }
}

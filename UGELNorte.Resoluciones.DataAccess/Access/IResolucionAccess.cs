﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
//using UGELNorte.Resoluciones.DataAccess
namespace UGELNorte.Resoluciones.DataAccess.Access
{
    public interface IResolucionAccess
    {
        DataRow GetResolucionByNro(string NroResolucion);

        DataTable GetAllResoluciones();

        DataTable SearchResolucion(string NroProyecto, string NroResolucion);

        bool AddResolucion(ResolucionModel resolucion);

        bool UpdateResolucion(ResolucionModel resolucion);

        bool DeleteResolucion(ResolucionModel resolucion);
    }
}

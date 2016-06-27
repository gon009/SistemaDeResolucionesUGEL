using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UGELNorte.Resoluciones.BusinessLogic.Enums
{
    using System.ComponentModel;
    public enum SituacionResolucion
    {
        [Description("Activo")]
        Activo = 1,

        [Description("Cesante")]
        Cesante,
    }
}

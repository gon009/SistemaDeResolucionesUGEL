using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UGELNorte.Resoluciones.BusinessLogic.Enums
{
    using System.ComponentModel;
    public enum TipoResolucion
    {
        [Description("Administrativa")]
        Administrativa = 1,

        [Description("Judicial")]
        Judicial,
    }
}

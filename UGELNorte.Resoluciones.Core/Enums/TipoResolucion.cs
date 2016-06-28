using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UGELNorte.Resoluciones.Core.Enums
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

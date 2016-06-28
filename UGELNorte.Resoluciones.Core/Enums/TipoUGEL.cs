using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UGELNorte.Resoluciones.Core.Enums
{
    using System.ComponentModel;
    public enum TipoUGEL
    {
        [Description("Arequipa Norte")]
        Arequipa_Norte = 1,

        [Description("La Joya")]
        La_Joya,

        [Description("Caylloma")]
        Caylloma,
    }
}

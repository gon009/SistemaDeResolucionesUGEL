using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UGELNorte.Resoluciones.Core.Enums;
namespace UGELNorte.Resoluciones.Core.Enums
{

    using System.ComponentModel;

    // Tipo de Conversion para convertir de Enums a strings y asi separar espacios
    [TypeConverter(typeof(EnumToString.EnumToStringUsingDescription))]
   
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

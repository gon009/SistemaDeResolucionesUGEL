using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UGELNorte.Resoluciones.Core.Enums;

namespace UGELNorte.Resoluciones.Core.Models
{
    public class ResolucionModel
    {

        public string NroProyecto { get; set; }

        public string NroResolucion { get; set; }

        public TipoResolucion TipoResolucion { get; set; }

        public TipoUGEL TipoUGEL { get; set; }

        public int InstitucionEducativa { get; set; }

        public int ConceptoResolucion { get; set; }

        public SituacionResolucion SituacionResolucion { get; set; }

        public string DNI { get; set; } 

        public string ExpedienteJudicial { get; set; }



    }
}

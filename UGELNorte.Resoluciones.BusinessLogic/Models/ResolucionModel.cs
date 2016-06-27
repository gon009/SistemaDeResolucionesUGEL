using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UGELNorte.Resoluciones.BusinessLogic.Enums;

namespace UGELNorte.Resoluciones.BusinessLogic.Models
{
    public class ResolucionModel
    {

        public string NroProyecto { get; set; }

        public string NroResolucion { get; set; }

        public TipoResolucion TipoResolucion { get; set; }

        public TipoUGEL TipoUGEL { get; set; }

        public string InstitucionEducativa { get; set; }

        public string ConceptoResolucion {get; set; }
        
        public SituacionResolucion SituacionResolucion { get; set; }



    }
}

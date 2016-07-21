using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UGELNorte.Resoluciones.Core.Models;

namespace UGELNorte.Resoluciones.DataAccess.Access
{
    public interface ISentenciaAccess
    {
        bool AddSentencia(SentenciaModel sentencia);
    }
}

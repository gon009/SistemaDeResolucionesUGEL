using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UGELNorte.Resoluciones.Core.Models;
using UGELNorte.Resoluciones.DataAccess.Access;
using UGELNorte.Resoluciones.DataAccess;
namespace UGELNorte.Resoluciones.BusinessLogic.Services
{
    public class SentenciaService : ISentenciaService
    {
        private ISentenciaAccess sentenciaAccess;

        public SentenciaService()
        {
            this.sentenciaAccess = new SentenciaAccess();
        }

        public bool RegisterSentencia(SentenciaModel sentencia)
        {
            return this.sentenciaAccess.AddSentencia(sentencia);
        }
    }
}

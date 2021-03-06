﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UGELNorte.Resoluciones.DataAccess.SQL
{
    public static class Scripts
    {
        // Consulta SQL para obtener una Resolucion por su Numero
        public static readonly string sqlGetResolucionByNro = "Select" +
            " Resolucion.IN_NroProyecto, Resolucion.IN_NroResolucion, Resolucion.IN_Tipo_Resolucion, Resolucion.IN_UGEL," +
            " IIEE.DA_InstitucionEducativa, Concepto.DA_Concepto, Resolucion.IN_Situacion," +
            " Resolucion.DA_FechaSentencia, Resolucion.DA_Sentencia, Resolucion.DA_ExpedienteJudicial, Resolucion.DA_Monto," +
            " Docente.IN_DNI, Docente.DA_ApellidoPaterno, Docente.DA_ApellidoMaterno, Docente.DA_Nombres" +
            " From TBL_Resolucion Resolucion" +
            " INNER JOIN TBL_Docente Docente ON Resolucion.IN_DNI = Docente.IN_DNI" +
            " INNER JOIN TBL_Institucion_Educativa IIEE ON Resolucion.IN_InstitucionEducativa = IIEE.IN_InstitucionEducativa" +
            " INNER JOIN TBL_Concepto Concepto ON Resolucion.IN_Concepto = Concepto.IN_Concepto" +
            " Where IN_NroResolucion = @NroResolucion";

        // Consulta SQL para obtener un Docente por su numero

        public static readonly string sqlGetDocenteByDNI = "Select " +
            " IN_DNI, DA_Nombres, DA_ApellidoPaterno, DA_ApellidoMaterno " +
            " from TBL_Docente " +
            " Where IN_DNI = @DNI ";
   
        // Consulta SQL para obtener todas las Resoluciones
        //public static readonly string SqlGetAllResolucion = "Select" +
        //    " IN_NroResolucion, IN_NroProyecto, IN_Tipo_Resolucion, IN_UGEL, IN_InstitucionEducativa, " +
        //    " IN_DNI, IN_Situacion, IN_Concepto, IN_ExpedienteJudicial" +
        //    " From TBL_Resolucion";

        public static readonly string SqlGetAllResolucion = "Select" +
            " Resolucion.IN_NroProyecto, Resolucion.IN_NroResolucion, Resolucion.IN_Tipo_Resolucion, Resolucion.IN_UGEL," +
            " IIEE.DA_InstitucionEducativa, Concepto.DA_Concepto, Resolucion.IN_Situacion," +
            " Resolucion.DA_FechaSentencia, Resolucion.DA_Sentencia, Resolucion.DA_ExpedienteJudicial, Sentencia.DA_Monto," +
            " Docente.IN_DNI, Docente.DA_ApellidoPaterno, Docente.DA_ApellidoMaterno, Docente.DA_Nombres" +
            " From TBL_Resolucion Resolucion" +
            " INNER JOIN TBL_Docente Docente ON Resolucion.IN_DNI = Docente.IN_DNI" +
            " INNER JOIN TBL_Institucion_Educativa IIEE ON Resolucion.IN_InstitucionEducativa = IIEE.IN_InstitucionEducativa" +
            " INNER JOIN TBL_Concepto Concepto ON Resolucion.IN_Concepto = Concepto.IN_Concepto";

        // Consulta SQL para obtener todos los docentes
        public static readonly string SqlGetAllDocentes = "Select " +
            " IN_DNI, DA_Nombres, DA_ApellidoPaterno, DA_ApellidoMaterno " +
            " from TBL_Docente";

        // Consulta SQL para registrar una Resolucion
        public static readonly string SqlInsertResolucion = "Insert Into" +
            " TBL_Resolucion(IN_NroResolucion, IN_NroProyecto, IN_Tipo_Resolucion, IN_UGEL, IN_InstitucionEducativa, " +
            " IN_DNI, IN_Situacion, IN_Concepto, DA_ExpedienteJudicial, DA_Sentencia, DA_FechaSentencia, DA_Monto)" +
            " Values(@NroResolucion, @NroProyecto, @TipoResolucion, @UGEL, @InstitucionEducativa, "+
            " @DNI, @Situacion, @Concepto , @ExpedienteJudicial , @Sentencia, @FechaSentencia, @Monto)";

        // Consulta SQL para registrar un expediente judicial
        public static readonly string SqlInsertExpedienteJudicial = "Insert Into" +
            " TBL_Sentencia(IN_ExpedienteJudicial, DA_Sentencia, DA_FechaSentencia, DA_Monto )" +
            " Values(@ExpedienteJudicial, @Sentencia, @FechaSentencia, @Monto)";

        // Consulta SQL para registrar un docente
        public static readonly string SqlInsertDocente = "Insert Into" +
            " TBL_Docente (IN_DNI, DA_Nombres, DA_ApellidoPaterno, DA_ApellidoMaterno)" +
            " Values(@DNI, @Nombres, @ApellidoPaterno, @ApellidoMaterno)";

        // Consulta SQL para registrar una sentencia
        public static readonly string SqlInsertSentencia = "Insert Into" +
            " TBL_Sentencia (IN_ExpedienteJudicial, DA_Sentencia, DA_FechaSentencia, DA_Monto)" +
            " Values(@ExpedienteJudicial, @Sentencia, @FechaSentencia, @Monto)";

        // Consulta para buscar una Resolucion
        public static readonly string SqlSearchResolucion = "Select" +
            " Resolucion.IN_NroProyecto, Resolucion.IN_NroResolucion, Resolucion.IN_UGEL, Resolucion.IN_Tipo_Resolucion," +
            " IIEE.DA_InstitucionEducativa, Concepto.DA_Concepto, Resolucion.IN_Situacion," +
            " Resolucion.DA_FechaSentencia, Resolucion.DA_Sentencia, Resolucion.DA_ExpedienteJudicial, Resolucion.DA_Monto," +
            " Docente.IN_DNI, Docente.DA_ApellidoPaterno, Docente.DA_ApellidoMaterno, Docente.DA_Nombres" +
            " From TBL_Resolucion Resolucion" +
            " INNER JOIN TBL_Docente Docente ON Resolucion.IN_DNI = Docente.IN_DNI" +
            " INNER JOIN TBL_Institucion_Educativa IIEE ON Resolucion.IN_InstitucionEducativa = IIEE.IN_InstitucionEducativa" +
            " INNER JOIN TBL_Concepto Concepto ON Resolucion.IN_Concepto = Concepto.IN_Concepto" +
            " Where (@NroResolucion Is NULL OR @NroResolucion = IN_NroResolucion) OR" +
            " (@NroProyecto Is NULL OR @NroProyecto = IN_NroProyecto)";
        
         // Consulta para actualizar o modificar una Resolucion
        public static readonly string sqlUpdateResolucion = "Update TBL_Resolucion " +
            " Set [IN_NroResolucion] = @NroResolucion, [IN_NroProyecto] = @NroProyecto, [IN_Tipo_Resolucion] = @TipoResolucion, [IN_UGEL] = @UGEL, " +
            " [IN_InstitucionEducativa] = @InstitucionEducativa, [IN_DNI] = @DNI, [IN_Situacion] = @Situacion,  [IN_Concepto] = @Concepto, [DA_ExpedienteJudicial] = @ExpedienteJudicial," +
            " [DA_Sentencia] = @Sentencia, [DA_FechaSentencia] = @FechaSentencia, [DA_Monto] = @Monto " +
            " Where ([IN_NroResolucion] = @NroResolucion)";

        // Consulta para actualizar o modificar un Docente
        public static readonly string sqlUpdateDocente = "Update TBL_Docente " +
            " Set [IN_DNI] = @DNI , [DA_Nombres] = @Nombres, [DA_ApellidoPaterno] = @ApellidoPaterno , [DA_ApellidoMaterno] = @ApellidoMaterno " +
            " Where ([IN_DNI] = @DNI)";

        // Consulta para eliminar una Resolucion
        public static readonly string sqlDeleteResolucion = "Delete From TBL_Resolucion Where (IN_NroResolucion = @NroResolucion)";
    }
}


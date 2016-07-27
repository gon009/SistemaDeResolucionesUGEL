using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UGELNorte.Resoluciones.Presentation.Formularios;
using UGELNorte.Resoluciones.Core.Models;
using UGELNorte.Resoluciones.Core.Enums;
using UGELNorte.Resoluciones.Core;
using UGELNorte.Resoluciones.BusinessLogic.Services;
using System.IO;

namespace UGELNorte.Resoluciones.Presentation.Formularios
{
    public partial class ModificarResolucion : Form
    {
        private string errorMessage;
      

        public ModificarResolucion()
        {
            InitializeComponent();
            this.InitializeUpdate();
            this.resolucionService = new ResolucionService();
        }
        private void InitializeUpdate()
        {
            // Cargar valores a los combobox
            cmbModTipo.DataSource = Enum.GetValues(typeof(TipoResolucion));
            cmbModUGEL.DataSource = Enum.GetValues(typeof(TipoUGEL));
            cmbModSituacion.DataSource = Enum.GetValues(typeof(SituacionResolucion));
        }

        private void ModificarResolucion_Load(object sender, EventArgs e)
        {
          
        }

        private IResolucionService resolucionService;


        
        private void btnModificarResolucion_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar resolucion y sentencia
                if (this.ValidateUpdate())
                {
                    ResolucionModel resolucionModel = new ResolucionModel()
                    {
                        NroProyecto = txtModNroProyecto.Text.Trim(),
                        NroResolucion = txtModNroResolucion.Text.Trim(),
                        TipoResolucion = (TipoResolucion)cmbModTipo.SelectedValue,
                        TipoUGEL = (TipoUGEL)cmbModUGEL.SelectedValue,
                        InstitucionEducativa = cmbModIIEE.SelectedIndex + 1,
                        ConceptoResolucion = cmbModConcepto.SelectedIndex + 1,
                        SituacionResolucion = (SituacionResolucion)cmbModSituacion.SelectedValue,
                        DNI = txtModDNI.Text.Trim(),

                    };

                    SentenciaModel sentenciaModel = new SentenciaModel()
                    {
                        FechaSentencia = dtModFechaSentencia.Value,
                        Sentencia = txtModSentencia.Text.Trim(),
                        ExpedienteJudicial = txtModExpedienteJudicial.Text.Trim(),
                        Monto = txtModMonto.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(txtModMonto.Text),
                    };

                    // LLama al metodo de servicio y lo asigna a una variable de retorno

                    var flag = this.resolucionService.UpdateResolucion(resolucionModel, sentenciaModel);

                    if (flag)
                    {
                        //DataTable data = this.resolucionService.GetAllResoluciones();
                        //this.LoadDataGridView(data);


                        // Mensaje de modificacion satisfactorio
                        MessageBox.Show(
                            Resources.Update_Satisfactorio_Mensaje,
                            Resources.Update_Satisfactorio_Mensaje_Titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Mensaje de error al modificar
                    MessageBox.Show(
                        this.errorMessage,
                        Resources.Registration_Error_Mensaje_Titulo,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        // Metodo para validar la modificacion de Resolucion ,sentencia
        private bool ValidateUpdate()
        {
            this.errorMessage = string.Empty;

            if (txtModNroProyecto.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_NroProyecto_Requerido);
            }

            if (txtModNroResolucion.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_NroResolucion_Requerido);
            }

            if (cmbModTipo.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_TipoResolucion_Requerido);
            }

            if (cmbModUGEL.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_TipoUGEL_Requerido);
            }

            if (cmbModIIEE.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_IIEE_Requerido);
            }

            if (cmbModConcepto.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_Concepto_Requerido);
            }

            if (cmbModSituacion.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_Situacion_Requerido);
            }


            if (txtModDNI.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_DNI_Requerido);
            }

            if (txtModExpedienteJudicial.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_ExpedienteJudicial_Requerido);
            }

            return this.errorMessage != string.Empty ? false : true;
        }

        // Metodo para crear el mensaje de error
        private void AddErrorMessage(string error)
        {
            if (this.errorMessage == string.Empty)
            {
                this.errorMessage = Resources.Error_Mensaje_Cabecera + "\n\n";
            }

            this.errorMessage += error + "\n";
        }

        // Metodo para mostrar el mensaje de error
        private void ShowErrorMessage(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                //Resources.System_Error_Message, 
                Resources.Sistema_Error_Mensaje_Titulo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {
            string resolucionesPath = "D:\\Resoluciones";
            string resolucion = txtModNroResolucion.Text.Trim() + ".pdf";
            string resolucionPath = Path.Combine(resolucionesPath, resolucion);
            System.Diagnostics.Process.Start(resolucionPath);
        }
    }
}

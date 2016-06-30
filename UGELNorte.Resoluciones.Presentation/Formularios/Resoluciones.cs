using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UGELNorte.Resoluciones.Core.Models;
using UGELNorte.Resoluciones.Core.Enums;
using UGELNorte.Resoluciones.BusinessLogic.Services;
using UGELNorte.Resoluciones.Core;

namespace UGELNorte.Resoluciones.Presentation
{
    public partial class FormResoluciones : Form
    {
        public FormResoluciones()
        {

            this.InitializeComponent();
            this.InitializeDropDownList();
            this.resolucionService = new ResolucionService();
            this.ResetRegistration();

        }
    
        private void FormResoluciones_Load(object sender, EventArgs e)
        {

        }

        //ValidateRegistration validateRegistration = new ValidateRegistration();
        private IResolucionService resolucionService;
        public string errorMessage;

        private void btnRegistrarResolucion_Click(object sender, EventArgs e)
        {
        
            try
            {
              
                // Check if the validation passes
                if (this.ValidateRegistrationResolucion())
                {
                    // Assign the values to the model
                    ResolucionModel resolucionModel = new ResolucionModel()
                    {
                        NroProyecto = txtNroProyecto.Text.Trim(),
                        NroResolucion = txtNroResolucion.Text.Trim(),
                        TipoResolucion = (TipoResolucion)cmbTipo.SelectedValue,
                        TipoUGEL = (TipoUGEL)cmbUGEL.SelectedValue,
                        InstitucionEducativa = txtIIEE.Text.Trim(),
                        ConceptoResolucion = txtConcepto.Text.Trim(),
                        SituacionResolucion = (SituacionResolucion)cmbSituacion.SelectedValue,
                        DNI = txtDNI.Text.Trim(),
                        ExpedienteJudicial = txtExpedienteJudicial.Text.Trim()
                    };

                    // Call the service method and assign the return status to variable
                    var success = this.resolucionService.RegisterResolucion(resolucionModel);

                    // if status of success variable is true then display a information else display the error message
                    if (success)
                    {
                        // display the message box
                        MessageBox.Show(
                            Resources.Registration_Satisfactorio_Mensaje,
                            Resources.Registration_Satisfactorio_Mensaje_Titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // Reset the screen
                        this.ResetRegistration();
                    }
                    else
                    {
                        // display the error messge
                        MessageBox.Show(
                            Resources.Registration_Error_Mensaje,
                            Resources.Registration_Error_Mensaje_Titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Display the validation failed message
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

        public void ResetRegistration()
        {
            txtNroProyecto.Text = string.Empty;
            txtNroResolucion.Text = string.Empty;
            cmbTipo.SelectedIndex = -1;
            cmbUGEL.SelectedIndex = -1;
            txtIIEE.Text = string.Empty;
            txtConcepto.Text = string.Empty;
            cmbSituacion.SelectedIndex = -1;
            txtDNI.Text = string.Empty;
            txtExpedienteJudicial.Text = string.Empty;
      
        }

        public bool ValidateRegistrationResolucion()
        {
            this.errorMessage = string.Empty;

            if (txtNroProyecto.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_NroProyecto_Requerido);
            }

            if (txtNroResolucion.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_NroResolucion_Requerido);
            }

            if (cmbTipo.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_TipoResolucion_Requerido);
            }

            if (cmbUGEL.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_TipoUGEL_Requerido);
            }

            if (txtIIEE.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_IIEE_Requerido);
            }

            if (txtConcepto.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_Concepto_Requerido);
            }

            if (cmbSituacion.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_Situacion_Requerido);
            }


            if (txtDNI.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_DNI_Requerido);
            }

            if (txtExpedienteJudicial.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_ExpedienteJudicial_Requerido);
            }

            return this.errorMessage != string.Empty ? false : true;
        }

        private void AddErrorMessage(string error)
        {
            if (this.errorMessage == string.Empty)
            {
                this.errorMessage = Resources.Error_Mensaje_Cabecera + "\n\n";
            }

            this.errorMessage += error + "\n";
        }

        private void ShowErrorMessage(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
                //Resources.System_Error_Message, 
                Resources.Sistema_Error_Mensaje_Titulo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void InitializeDropDownList()
        {
            cmbSituacion.DataSource = Enum.GetValues(typeof(SituacionResolucion));
            cmbTipo.DataSource = Enum.GetValues(typeof(TipoResolucion));
            cmbUGEL.DataSource = Enum.GetValues(typeof(TipoUGEL));

            
        }
    }
}

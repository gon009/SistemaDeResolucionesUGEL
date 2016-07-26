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
using UGELNorte.Resoluciones.Core.Utilities;
using UGELNorte.Resoluciones.BusinessLogic.Services;
using UGELNorte.Resoluciones.Core;
using UGELNorte.Resoluciones.Presentation.Formularios;

namespace UGELNorte.Resoluciones.Presentation
{
    public partial class FormResoluciones : Form
    {
        public FormResoluciones()
        {

            this.InitializeComponent();
            this.InitializeDropDownList();
            this.resolucionService = new ResolucionService();
            this.docenteService = new DocenteService();
            this.sentenciaService = new SentenciaService();
            this.formModificarResolucion = new ModificarResolucion();
            ControlUtilities.ResetAllControls(groupBoxInfoResoluciones);
            ControlUtilities.ResetAllControls(groupBoxInfoSentencia);
            ControlUtilities.ResetAllControls(groupBoxInfoDocente);

        }

      

        private void FormResoluciones_Load(object sender, EventArgs e)
        {

        }

       



        //ValidateRegistration validateRegistration = new ValidateRegistration();
        private IResolucionService resolucionService;
        private IDocenteService docenteService;
        private ISentenciaService sentenciaService;
        ControlUtilities controlUtilities = new ControlUtilities();
        public string errorMessage;
        private string nroResolucionDelete;
        ModificarResolucion formModificarResolucion;

     
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
                        InstitucionEducativa = cmbIIEE.SelectedIndex + 1,
                        ConceptoResolucion = cmbConcepto.SelectedIndex + 1,
                        SituacionResolucion = (SituacionResolucion)cmbSituacion.SelectedValue,
                        DNI = txtDNIDocenteResolucion.Text.Trim(),
                        //ExpedienteJudicial = txtExpedienteJudicial.Text.Trim()
                    };

                    SentenciaModel sentenciaModel = new SentenciaModel()
                    {
                        FechaSentencia = dtFechaSentencia.Value,
                        Sentencia = txtSentencia.Text.Trim(),
                        ExpedienteJudicial = txtExpedienteJudicial.Text.Trim(),
                        Monto = txtMonto.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(txtMonto.Text),
                    };

                    // Call the service method and assign the return status to variable
                    var successResolucion = this.resolucionService.RegisterResolucion(resolucionModel,sentenciaModel);
              
                    // if status of success variable is true then display a information else display the error message
                    if (successResolucion)
                    {
                        // display the message box
                        MessageBox.Show(
                            Resources.Registration_Satisfactorio_Mensaje,
                            Resources.Registration_Satisfactorio_Mensaje_Titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // Reset the screen
                        ControlUtilities.ResetAllControls(groupBoxInfoResoluciones);
                        ControlUtilities.ResetAllControls(groupBoxInfoSentencia);
                        ControlUtilities.ResetAllControls(groupBoxInfoDocente);
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

            if (cmbIIEE.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_IIEE_Requerido);
            }

            if (cmbConcepto.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_Concepto_Requerido);
            }

            if (cmbSituacion.SelectedIndex == -1)
            {
                this.AddErrorMessage(Resources.Registration_Situacion_Requerido);
            }


            if (txtDNIDocenteResolucion.Text.Trim() == string.Empty)
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

        private void btnImportarPDF_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscarResolucion_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = this.resolucionService.SearchResolucion(txtBuscarNroProyecto.Text.Trim(), txtBuscarNroResolucion.Text.Trim());
                this.LoadDataGridView(data);
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }

        }

        private void LoadDataGridView(DataTable data)
        {
            // Data grid view column setting            
            dataGridViewResoluciones.DataSource = data;
            dataGridViewResoluciones.DataMember = data.TableName;
            dataGridViewResoluciones.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnEliminarResolucion_Click(object sender, EventArgs e)
        {
      
            try
            {
                var flag = this.resolucionService.DeleteResolucion(this.nroResolucionDelete);

                if (flag)
                {
                    DataTable data = this.resolucionService.SearchResolucion(txtBuscarNroProyecto.Text.Trim(), txtBuscarNroResolucion.Text.Trim());
                    this.LoadDataGridView(data);

                    MessageBox.Show(
                        Resources.Delete_Satisfactorio_Mensaje,
                        Resources.Delete_Satisfactorio_Mensaje_Titulo,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private void dataGridViewResoluciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridViewResoluciones_SelectionChanged(object sender, EventArgs e)
        {


          
        }

        private void dataGridViewResoluciones_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int currentRow = dataGridViewResoluciones.SelectedCells[0].RowIndex;
            //MessageBox.Show("cell content click");
            DataGridView dgv = (DataGridView)sender;

            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    string nroResolucion = dgv.SelectedRows[0].Cells[1].Value.ToString();
                   
                    nroResolucionDelete = nroResolucion;
                    DataRow dataRow = this.resolucionService.GetResolucionByNro(nroResolucionDelete);
                    formModificarResolucion.txtModNroResolucion.Text = dataRow["IN_NroResolucion"].ToString().Trim();
                    formModificarResolucion.txtModNroProyecto.Text = dataRow["IN_NroProyecto"].ToString().Trim();
                    formModificarResolucion.cmbModTipo.SelectedItem = (TipoResolucion)dataRow["IN_Tipo_Resolucion"];
                    formModificarResolucion.cmbModUGEL.SelectedItem = (TipoUGEL)dataRow["IN_UGEL"];
                    formModificarResolucion.cmbModIIEE.Text = dataRow["DA_InstitucionEducativa"].ToString().Trim(); ;
                    formModificarResolucion.cmbModConcepto.Text = dataRow["DA_Concepto"].ToString().Trim(); ;
                    formModificarResolucion.cmbModSituacion.SelectedItem = (SituacionResolucion)dataRow["IN_Situacion"];

                    formModificarResolucion.txtModDNI.Text = dataRow["IN_DNI"].ToString().Trim();
                    formModificarResolucion.dtModFechaSentencia.Value = Convert.ToDateTime(dataRow["DA_FechaSentencia"]);
                    formModificarResolucion.txtModSentencia.Text = dataRow["DA_Sentencia"].ToString().Trim();
                    formModificarResolucion.txtModExpedienteJudicial.Text = dataRow["DA_ExpedienteJudicial"].ToString().Trim();
                    formModificarResolucion.txtModMonto.Text = dataRow["DA_Monto"].ToString() == "0.0000" ? string.Empty : dataRow["DA_Monto"].ToString();

                    //formModificarResolucion.txtModDNI.Text = dataRow["IN_DNI"].ToString().Trim();
                    //formModificarResolucion.txtModApellidoPaterno.Text = dataRow["DA_ApellidoPaterno"].ToString().Trim();
                    //formModificarResolucion.txtModApellidoMaterno.Text = dataRow["DA_ApellidoMaterno"].ToString().Trim();
                    //formModificarResolucion.txtModNombres.Text = dataRow["DA_Nombres"].ToString().Trim();

                    /*

                    dt2DateOfBirth.Value = Convert.ToDateTime(dataRow["DateOfBirth"]);
                    cmb2Occupation.SelectedItem = (Occupation)dataRow["Occupation"];
                    txt2Name.Text = dataRow["Name"].ToString();
                    cmb2MaritalStatus.SelectedItem = (MaritalStatus)dataRow["MaritalStatus"];
                    cmb2HealthStatus.SelectedItem = (HealthStatus)dataRow["HealthStatus"];
                    txt2Salary.Text = dataRow["Salary"].ToString() == "0.0000" ? string.Empty : dataRow["Salary"].ToString();
                    txt2NoOfChildren.Text = dataRow["NumberOfChildren"].ToString(); */
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
           

        }

        private void dataGridViewResoluciones_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
     
            formModificarResolucion.ShowDialog();
        }

        private void FormResoluciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewResoluciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                    
                if (e.ColumnIndex == 2)
                {
                    string value = Enum.GetName(typeof(TipoUGEL), e.Value).ToString();
                    e.Value = value.Replace("_", " ");

                }

                if (e.ColumnIndex == 3)
                {
                    string value = Enum.GetName(typeof(TipoResolucion), e.Value).ToString();
                    e.Value = value.Replace("_", " ");
                }

                if (e.ColumnIndex == 6)
                {
                    string value = Enum.GetName(typeof(SituacionResolucion), e.Value).ToString();
                    e.Value = value.Replace("_", " ");
                }

            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private void btnRegistrarDocente_Click(object sender, EventArgs e)
        {
            try
            {

                // Check if the validation passes
                //if (this.ValidateRegistrationResolucion())
                //{
                    // Assign the values to the model
                   
                    DocenteModel docenteModel = new DocenteModel()
                    {
                        DNI = Convert.ToInt64(txtDNI.Text.ToString().Trim()),
                        apellidoMaterno = txtApellidoMaterno.Text.Trim(),
                        apellidoPaterno = txtApellidoPaterno.Text.Trim(),
                        Nombres = txtNombres.Text.Trim(),
                    };

               
                    // Call the service method and assign the return status to variable
            
                    var successDocente = this.docenteService.RegisterDocente(docenteModel);
                
                    // if status of success variable is true then display a information else display the error message
                    if (successDocente)
                    {
                        // display the message box
                        MessageBox.Show(
                            Resources.Registration_Satisfactorio_Mensaje,
                            Resources.Registration_Satisfactorio_Mensaje_Titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // Reset the screen    
                        ControlUtilities.ResetAllControls(groupBoxInfoDocente);
                    }
                    //else
                    //{
                    //    // display the error messge
                    //    MessageBox.Show(
                    //        Resources.Registration_Error_Mensaje,
                    //        Resources.Registration_Error_Mensaje_Titulo,
                    //        MessageBoxButtons.OK,
                    //        MessageBoxIcon.Error);
                    //}
                //}
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

        private void btnRegistrarIIEE_Click(object sender, EventArgs e)
        {

        }
    }
    
}

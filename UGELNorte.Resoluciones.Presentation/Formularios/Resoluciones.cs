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
using System.IO;


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
        private string nuevoDNI;
        ModificarResolucion formModificarResolucion;

     
        private void btnRegistrarResolucion_Click(object sender, EventArgs e)
        {
       
            try
            {
              
                // Verifica si la validacion paso
                if (this.ValidateRegistrationResolucion())
                {
                    // Asignar controles a el modelo
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
               
                    };

                    SentenciaModel sentenciaModel = new SentenciaModel()
                    {
                        FechaSentencia = dtFechaSentencia.Value,
                        Sentencia = txtSentencia.Text.Trim(),
                        ExpedienteJudicial = txtExpedienteJudicial.Text.Trim(),
                        Monto = txtMonto.Text.Trim() == string.Empty ? 0 : Convert.ToDecimal(txtMonto.Text),
                    };

                    // Llama para el registro de solucion por el metodo de servicio y asigna el valor retornado
                    var successResolucion = this.resolucionService.RegisterResolucion(resolucionModel,sentenciaModel);
              
                    // Si es verdadero se hizo el registro y se muestra el mensaje
                    if (successResolucion)
                    {
                        // Muestra la cajita con el mensaje de registro satisfactorio
                        MessageBox.Show(
                            Resources.Registration_Satisfactorio_Mensaje,
                            Resources.Registration_Satisfactorio_Mensaje_Titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // Limpia los controles
                        ControlUtilities.ResetAllControls(groupBoxInfoResoluciones);
                        ControlUtilities.ResetAllControls(groupBoxInfoSentencia);
                
                    }
                    else
                    {
                        // Muestral el mensaje de error
                        MessageBox.Show(
                            Resources.Registration_Error_Mensaje,
                            Resources.Registration_Error_Mensaje_Titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Muestra el mensaje de valifacion fallido
                    MessageBox.Show(
                        this.errorMessage,
                        Resources.Registration_Error_Mensaje_Titulo,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(new Exception(Resources.Error_DNIDocent_NotExist + ex ));
            }

        }

        // Metodo para validar el registro de resolucion
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

         

            if (txtSentencia.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_Sentencia_Requerido);
            }

            if (txtMonto.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Registration_Monto_Requerido);
            }



            return this.errorMessage != string.Empty ? false : true;
        }


        // Creacion del mensaje de error
        private void AddErrorMessage(string error)
        {
            if (this.errorMessage == string.Empty)
            {
                this.errorMessage = Resources.Error_Mensaje_Cabecera + "\n\n";
            }

            this.errorMessage += error + "\n";
        }

        // Mostrar mensaje de error
        private void ShowErrorMessage(Exception ex)
        {
            MessageBox.Show(
                ex.Message,
             
                Resources.Sistema_Error_Mensaje_Titulo,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        // Cargo valores a los combobox
        private void InitializeDropDownList()
        {
            cmbSituacion.DataSource = Enum.GetValues(typeof(SituacionResolucion));
            cmbTipo.DataSource = Enum.GetValues(typeof(TipoResolucion));
            cmbUGEL.DataSource = Enum.GetValues(typeof(TipoUGEL));        
        }

        private void btnImportarPDF_Click(object sender, EventArgs e)
        {
            string resolucionesPath = "D:\\Resoluciones";
            string resolucionImportada = string.Empty;
            string destinoFinal = string.Empty;
            string nombreResolucion = string.Empty;

            using (OpenFileDialog OpenFileDialogImportPDF = new OpenFileDialog())
            {
                if (OpenFileDialogImportPDF.ShowDialog() == DialogResult.OK)
                {
                    // Filtro para aceptar extesiones .pdf
                    OpenFileDialogImportPDF.Filter = "Pdf Files|*.pdf";

                    // Obtengo la ubicacion de la resolucion importada , y SOLO el nombre de la misma
                    resolucionImportada = Path.GetFullPath(OpenFileDialogImportPDF.FileName);
                    nombreResolucion = Path.GetFileName(OpenFileDialogImportPDF.FileName);

                    // Verifico si la carpeta Resoluciones ya esta creada, si no es asi la creo
                    if (!Directory.Exists(resolucionesPath))
                    {
                        Directory.CreateDirectory(resolucionesPath);
                    }
                    // Combino el directorio de Resoluciones con el nombre de la resolucion importada
                    destinoFinal = Path.Combine("D:\\Resoluciones", nombreResolucion);

                    //Verifico que la resolucion no se encuentre en D:\\Resoluciones
                    if (File.Exists(destinoFinal))
                    {
                        MessageBox.Show(
                         Resources.Importacion_PDF_Error,
                         Resources.Importacion_PDF_Error_Titulo,
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                        
                    }
                    // Si no existe  copio la resolucion a D:\\Resoluciones
                    else
                    { 

                    File.Copy(resolucionImportada, destinoFinal);

                    MessageBox.Show(
                          Resources.Importacion_PDF_Satisfactoria,
                          Resources.Importacion_PDF_Satisfactoria_Titulo,
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                    }
                }
            }

        }

        // Metodo para buscar la resulolucion
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

        // Metodo Cargar datagridview  con resoluciones
        private void LoadDataGridView(DataTable data)
        {
                    
            dataGridViewResoluciones.DataSource = data;
            dataGridViewResoluciones.DataMember = data.TableName;
            dataGridViewResoluciones.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        // Metodo cargar datagridview con docentes
        private void LoadDataGridViewDocentes(DataTable data)
        {
            dataGridViewDocentes.DataSource = data;
            dataGridViewDocentes.DataMember = data.TableName;
            dataGridViewDocentes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }


        // Metodo para Eliminar resolucion
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


        private void dataGridViewResoluciones_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int currentRow = dataGridViewResoluciones.SelectedCells[0].RowIndex;

            DataGridView dgv = (DataGridView)sender;

            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    // Mostrar valores despues de hacer doble click en alguna fila del datagridview de resoluciones
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

            
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
           

        }

        private void dataGridViewResoluciones_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Mostrar formulario de modificacion
            formModificarResolucion.ShowDialog();
        }

        private void FormResoluciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewResoluciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Cambiar el formato cuando existe algun '_'
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

                // Verifica si la validacion pasa
                if (this.ValidateUpdate())
                {
                    // Asignar valores al modelo
                   
                    DocenteModel docenteModel = new DocenteModel()
                    {
                        DNI = Convert.ToInt64(txtDNI.Text.ToString().Trim()),
                        apellidoMaterno = txtApellidoMaterno.Text.Trim(),
                        apellidoPaterno = txtApellidoPaterno.Text.Trim(),
                        Nombres = txtNombres.Text.Trim(),
                    };

               
                    // LLama al metodo de servicio y lo asigna a una variable de retorno
            
                    var successDocente = this.docenteService.RegisterDocente(docenteModel);
                
                    // Si es verdadero , muestra el mensaje de registro satisfactorio, sino uno de error
                    if (successDocente)
                    {
                        // Muestra el mensaje de registro satisfactoriodisplay the message box
                        MessageBox.Show(
                            Resources.Registration_Satisfactorio_Mensaje,
                            Resources.Registration_Satisfactorio_Mensaje_Titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // Resetea los controles de docentes  
                        ControlUtilities.ResetAllControls(groupBoxInfoDocente);
                    }
                    else
                    {
                        // Muestra mensaje de error
                        MessageBox.Show(
                            Resources.Registration_Error_Mensaje,
                            Resources.Registration_Error_Mensaje_Titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Muestra mensaje de validacion fallida
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

        private void btnActualizarDocente_Click(object sender, EventArgs e)
        {
            try
            {
                // Valida para que se actualicen los datos
                if (this.ValidateUpdate())
                {
                    // Asigna los valores a el modelo Docente
                    DocenteModel docenteModel = new DocenteModel()
                    {
                        DNI = Convert.ToInt64(txtDNI.Text.ToString().Trim()),
                        apellidoMaterno = txtApellidoMaterno.Text.Trim(),
                        apellidoPaterno = txtApellidoPaterno.Text.Trim(),
                        Nombres = txtNombres.Text.Trim(),
                    };

                    // LLama al metodo de servicio y lo asigna a una variable de retorno
                    var flag = this.docenteService.UpdateDocente(docenteModel);

                    if (flag)
                    {
                        // Carga otra vez todo el datagridview despues de  eliminar
                        DataTable data = this.docenteService.GetAllDocentes();
                        this.LoadDataGridViewDocentes(data);

                        // Muestra mensaje de modificacion correcta
                        MessageBox.Show(
                            Resources.Update_Satisfactorio_Mensaje,
                            Resources.Update_Satisfactorio_Mensaje_Titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Muestra mensaje de error de registro
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

        private bool ValidateUpdate()
        {
            // Metodo para validacion al actualizar Docente
            this.errorMessage = string.Empty;

            if (txtDNI.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Update_DNIDocente_Requerido);
            }

            if (txtApellidoPaterno.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Update_ApellidoPaterno_Requerido);
            }

            if (txtApellidoMaterno.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Update_ApellidoMaterno_Requerido);
            }

            if (txtNombres.Text.Trim() == string.Empty)
            {
                this.AddErrorMessage(Resources.Update_Nombres_Requerido);
            }

            return this.errorMessage != string.Empty ? false : true;
        }

        private void tabCtrlResoluciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evento para que muestre todos los Docentes en el gridview
            try
            {
                if (tabCtrlResoluciones.SelectedIndex == 2)
                {
                    DataTable data = this.docenteService.GetAllDocentes();
                    //this.InitializeUpdate();
                    this.LoadDataGridViewDocentes(data);
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }

        private void dataGridViewDocentes_SelectionChanged(object sender, EventArgs e)
        {
            // Evento cada ves que seleccione otra fila se muestre en los controles
            DataGridView dgv = (DataGridView)sender;

            try
            {
                if (dgv.SelectedRows.Count > 0)
                {
                    string DNI = dgv.SelectedRows[0].Cells[0].Value.ToString();

                    nuevoDNI = DNI;

                    DataRow dataRow = this.docenteService.GetDocenteByDNI(nuevoDNI);

                    // Asignacion de la fila del gridview a los controles
                    txtDNI.Text = dataRow["IN_DNI"].ToString().Trim();
                    txtApellidoPaterno.Text = dataRow["DA_ApellidoPaterno"].ToString().Trim();
                    txtApellidoMaterno.Text = dataRow["DA_ApellidoMaterno"].ToString().Trim();
                    txtNombres.Text = dataRow["DA_Nombres"].ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex);
            }
        }
    }
    
}

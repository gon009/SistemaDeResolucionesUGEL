namespace UGELNorte.Resoluciones.Presentation
{
    partial class FormResoluciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResoluciones));
            this.panelResoluciones = new System.Windows.Forms.Panel();
            this.tabCtrlResoluciones = new System.Windows.Forms.TabControl();
            this.tabPageRegResoluciones = new System.Windows.Forms.TabPage();
            this.btnImportarPDF = new System.Windows.Forms.Button();
            this.btnRegistrarResolucion = new System.Windows.Forms.Button();
            this.groupBoxInfoSentencia = new System.Windows.Forms.GroupBox();
            this.lblDNIDocente = new System.Windows.Forms.Label();
            this.txtDNIDocenteResolucion = new System.Windows.Forms.TextBox();
            this.lblFechaSentencia = new System.Windows.Forms.Label();
            this.lblSentencia = new System.Windows.Forms.Label();
            this.lblExpedienteJudicial = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtSentencia = new System.Windows.Forms.TextBox();
            this.txtExpedienteJudicial = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.dtFechaSentencia = new System.Windows.Forms.DateTimePicker();
            this.groupBoxInfoResoluciones = new System.Windows.Forms.GroupBox();
            this.lblNroProyecto = new System.Windows.Forms.Label();
            this.lblNroResolucion = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblUGEL = new System.Windows.Forms.Label();
            this.lblIIEE = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.lblSituacion = new System.Windows.Forms.Label();
            this.txtNroProyecto = new System.Windows.Forms.TextBox();
            this.txtNroResolucion = new System.Windows.Forms.MaskedTextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbUGEL = new System.Windows.Forms.ComboBox();
            this.cmbSituacion = new System.Windows.Forms.ComboBox();
            this.cmbIIEE = new System.Windows.Forms.ComboBox();
            this.cmbConcepto = new System.Windows.Forms.ComboBox();
            this.tabPageBuscarModificarResol = new System.Windows.Forms.TabPage();
            this.dataGridViewResoluciones = new System.Windows.Forms.DataGridView();
            this.d = new System.Windows.Forms.GroupBox();
            this.btnEliminarResolucion = new System.Windows.Forms.Button();
            this.lblBuscarNroResolucion = new System.Windows.Forms.Label();
            this.txtBuscarNroProyecto = new System.Windows.Forms.MaskedTextBox();
            this.txtBuscarNroResolucion = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarResolucion = new System.Windows.Forms.Button();
            this.lblBuscarNroProyecto = new System.Windows.Forms.Label();
            this.tabPageDocentesEIIEE = new System.Windows.Forms.TabPage();
            this.dataGridViewDocentes = new System.Windows.Forms.DataGridView();
            this.groupBoxInfoDocente = new System.Windows.Forms.GroupBox();
            this.btnActualizarDocente = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnRegistrarDocente = new System.Windows.Forms.Button();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelResoluciones.SuspendLayout();
            this.tabCtrlResoluciones.SuspendLayout();
            this.tabPageRegResoluciones.SuspendLayout();
            this.groupBoxInfoSentencia.SuspendLayout();
            this.groupBoxInfoResoluciones.SuspendLayout();
            this.tabPageBuscarModificarResol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResoluciones)).BeginInit();
            this.d.SuspendLayout();
            this.tabPageDocentesEIIEE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocentes)).BeginInit();
            this.groupBoxInfoDocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelResoluciones
            // 
            this.panelResoluciones.Controls.Add(this.tabCtrlResoluciones);
            this.panelResoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelResoluciones.Location = new System.Drawing.Point(12, 134);
            this.panelResoluciones.Name = "panelResoluciones";
            this.panelResoluciones.Size = new System.Drawing.Size(924, 491);
            this.panelResoluciones.TabIndex = 0;
            // 
            // tabCtrlResoluciones
            // 
            this.tabCtrlResoluciones.Controls.Add(this.tabPageRegResoluciones);
            this.tabCtrlResoluciones.Controls.Add(this.tabPageBuscarModificarResol);
            this.tabCtrlResoluciones.Controls.Add(this.tabPageDocentesEIIEE);
            this.tabCtrlResoluciones.Location = new System.Drawing.Point(3, 6);
            this.tabCtrlResoluciones.Name = "tabCtrlResoluciones";
            this.tabCtrlResoluciones.SelectedIndex = 0;
            this.tabCtrlResoluciones.Size = new System.Drawing.Size(918, 483);
            this.tabCtrlResoluciones.TabIndex = 0;
            this.tabCtrlResoluciones.SelectedIndexChanged += new System.EventHandler(this.tabCtrlResoluciones_SelectedIndexChanged);
            // 
            // tabPageRegResoluciones
            // 
            this.tabPageRegResoluciones.Controls.Add(this.btnImportarPDF);
            this.tabPageRegResoluciones.Controls.Add(this.btnRegistrarResolucion);
            this.tabPageRegResoluciones.Controls.Add(this.groupBoxInfoSentencia);
            this.tabPageRegResoluciones.Controls.Add(this.groupBoxInfoResoluciones);
            this.tabPageRegResoluciones.Location = new System.Drawing.Point(4, 27);
            this.tabPageRegResoluciones.Name = "tabPageRegResoluciones";
            this.tabPageRegResoluciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegResoluciones.Size = new System.Drawing.Size(910, 452);
            this.tabPageRegResoluciones.TabIndex = 0;
            this.tabPageRegResoluciones.Text = "Registro de Resoluciones";
            this.tabPageRegResoluciones.UseVisualStyleBackColor = true;
            // 
            // btnImportarPDF
            // 
            this.btnImportarPDF.Location = new System.Drawing.Point(674, 305);
            this.btnImportarPDF.Name = "btnImportarPDF";
            this.btnImportarPDF.Size = new System.Drawing.Size(180, 49);
            this.btnImportarPDF.TabIndex = 33;
            this.btnImportarPDF.Text = "Importar PDF";
            this.btnImportarPDF.UseVisualStyleBackColor = true;
            this.btnImportarPDF.Click += new System.EventHandler(this.btnImportarPDF_Click);
            // 
            // btnRegistrarResolucion
            // 
            this.btnRegistrarResolucion.Location = new System.Drawing.Point(504, 305);
            this.btnRegistrarResolucion.Name = "btnRegistrarResolucion";
            this.btnRegistrarResolucion.Size = new System.Drawing.Size(164, 49);
            this.btnRegistrarResolucion.TabIndex = 32;
            this.btnRegistrarResolucion.Text = "Registrar Resolucion";
            this.btnRegistrarResolucion.UseVisualStyleBackColor = true;
            this.btnRegistrarResolucion.Click += new System.EventHandler(this.btnRegistrarResolucion_Click);
            // 
            // groupBoxInfoSentencia
            // 
            this.groupBoxInfoSentencia.Controls.Add(this.lblDNIDocente);
            this.groupBoxInfoSentencia.Controls.Add(this.txtDNIDocenteResolucion);
            this.groupBoxInfoSentencia.Controls.Add(this.lblFechaSentencia);
            this.groupBoxInfoSentencia.Controls.Add(this.lblSentencia);
            this.groupBoxInfoSentencia.Controls.Add(this.lblExpedienteJudicial);
            this.groupBoxInfoSentencia.Controls.Add(this.lblMonto);
            this.groupBoxInfoSentencia.Controls.Add(this.txtSentencia);
            this.groupBoxInfoSentencia.Controls.Add(this.txtExpedienteJudicial);
            this.groupBoxInfoSentencia.Controls.Add(this.txtMonto);
            this.groupBoxInfoSentencia.Controls.Add(this.dtFechaSentencia);
            this.groupBoxInfoSentencia.Location = new System.Drawing.Point(491, 21);
            this.groupBoxInfoSentencia.Name = "groupBoxInfoSentencia";
            this.groupBoxInfoSentencia.Size = new System.Drawing.Size(402, 264);
            this.groupBoxInfoSentencia.TabIndex = 2;
            this.groupBoxInfoSentencia.TabStop = false;
            this.groupBoxInfoSentencia.Text = "Informacion de Sentencia";
            // 
            // lblDNIDocente
            // 
            this.lblDNIDocente.AutoSize = true;
            this.lblDNIDocente.Location = new System.Drawing.Point(23, 35);
            this.lblDNIDocente.Name = "lblDNIDocente";
            this.lblDNIDocente.Size = new System.Drawing.Size(97, 18);
            this.lblDNIDocente.TabIndex = 26;
            this.lblDNIDocente.Text = "DNI Docente:";
            // 
            // txtDNIDocenteResolucion
            // 
            this.txtDNIDocenteResolucion.Location = new System.Drawing.Point(132, 38);
            this.txtDNIDocenteResolucion.Name = "txtDNIDocenteResolucion";
            this.txtDNIDocenteResolucion.Size = new System.Drawing.Size(200, 24);
            this.txtDNIDocenteResolucion.TabIndex = 27;
            // 
            // lblFechaSentencia
            // 
            this.lblFechaSentencia.AutoSize = true;
            this.lblFechaSentencia.Location = new System.Drawing.Point(23, 75);
            this.lblFechaSentencia.Name = "lblFechaSentencia";
            this.lblFechaSentencia.Size = new System.Drawing.Size(77, 36);
            this.lblFechaSentencia.TabIndex = 18;
            this.lblFechaSentencia.Text = "Fecha de \r\nSentencia:";
            // 
            // lblSentencia
            // 
            this.lblSentencia.AutoSize = true;
            this.lblSentencia.Location = new System.Drawing.Point(23, 116);
            this.lblSentencia.Name = "lblSentencia";
            this.lblSentencia.Size = new System.Drawing.Size(77, 18);
            this.lblSentencia.TabIndex = 19;
            this.lblSentencia.Text = "Sentencia:";
            // 
            // lblExpedienteJudicial
            // 
            this.lblExpedienteJudicial.AutoSize = true;
            this.lblExpedienteJudicial.Location = new System.Drawing.Point(23, 157);
            this.lblExpedienteJudicial.Name = "lblExpedienteJudicial";
            this.lblExpedienteJudicial.Size = new System.Drawing.Size(80, 36);
            this.lblExpedienteJudicial.TabIndex = 20;
            this.lblExpedienteJudicial.Text = "Expediente\r\nJudicial:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(23, 198);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(55, 18);
            this.lblMonto.TabIndex = 21;
            this.lblMonto.Text = "Monto:";
            // 
            // txtSentencia
            // 
            this.txtSentencia.Location = new System.Drawing.Point(132, 119);
            this.txtSentencia.Name = "txtSentencia";
            this.txtSentencia.Size = new System.Drawing.Size(200, 24);
            this.txtSentencia.TabIndex = 29;
            // 
            // txtExpedienteJudicial
            // 
            this.txtExpedienteJudicial.Location = new System.Drawing.Point(132, 160);
            this.txtExpedienteJudicial.Name = "txtExpedienteJudicial";
            this.txtExpedienteJudicial.Size = new System.Drawing.Size(249, 24);
            this.txtExpedienteJudicial.TabIndex = 30;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(132, 201);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(106, 24);
            this.txtMonto.TabIndex = 31;
            // 
            // dtFechaSentencia
            // 
            this.dtFechaSentencia.CustomFormat = "dd/MM/yyyy";
            this.dtFechaSentencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaSentencia.Location = new System.Drawing.Point(132, 78);
            this.dtFechaSentencia.Name = "dtFechaSentencia";
            this.dtFechaSentencia.Size = new System.Drawing.Size(119, 24);
            this.dtFechaSentencia.TabIndex = 28;
            // 
            // groupBoxInfoResoluciones
            // 
            this.groupBoxInfoResoluciones.Controls.Add(this.lblNroProyecto);
            this.groupBoxInfoResoluciones.Controls.Add(this.lblNroResolucion);
            this.groupBoxInfoResoluciones.Controls.Add(this.lblTipo);
            this.groupBoxInfoResoluciones.Controls.Add(this.lblUGEL);
            this.groupBoxInfoResoluciones.Controls.Add(this.lblIIEE);
            this.groupBoxInfoResoluciones.Controls.Add(this.lblConcepto);
            this.groupBoxInfoResoluciones.Controls.Add(this.lblSituacion);
            this.groupBoxInfoResoluciones.Controls.Add(this.txtNroProyecto);
            this.groupBoxInfoResoluciones.Controls.Add(this.txtNroResolucion);
            this.groupBoxInfoResoluciones.Controls.Add(this.cmbTipo);
            this.groupBoxInfoResoluciones.Controls.Add(this.cmbUGEL);
            this.groupBoxInfoResoluciones.Controls.Add(this.cmbSituacion);
            this.groupBoxInfoResoluciones.Controls.Add(this.cmbIIEE);
            this.groupBoxInfoResoluciones.Controls.Add(this.cmbConcepto);
            this.groupBoxInfoResoluciones.Location = new System.Drawing.Point(19, 16);
            this.groupBoxInfoResoluciones.Name = "groupBoxInfoResoluciones";
            this.groupBoxInfoResoluciones.Size = new System.Drawing.Size(452, 342);
            this.groupBoxInfoResoluciones.TabIndex = 1;
            this.groupBoxInfoResoluciones.TabStop = false;
            this.groupBoxInfoResoluciones.Text = "Informacion de Resolucion";
            // 
            // lblNroProyecto
            // 
            this.lblNroProyecto.AutoSize = true;
            this.lblNroProyecto.Location = new System.Drawing.Point(23, 28);
            this.lblNroProyecto.Name = "lblNroProyecto";
            this.lblNroProyecto.Size = new System.Drawing.Size(72, 36);
            this.lblNroProyecto.TabIndex = 16;
            this.lblNroProyecto.Text = "Nro de \r\nProyecto:";
            // 
            // lblNroResolucion
            // 
            this.lblNroResolucion.AutoSize = true;
            this.lblNroResolucion.Location = new System.Drawing.Point(23, 71);
            this.lblNroResolucion.Name = "lblNroResolucion";
            this.lblNroResolucion.Size = new System.Drawing.Size(87, 36);
            this.lblNroResolucion.TabIndex = 17;
            this.lblNroResolucion.Text = "Nro De \r\nResolucion:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(23, 114);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(41, 18);
            this.lblTipo.TabIndex = 18;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblUGEL
            // 
            this.lblUGEL.AutoSize = true;
            this.lblUGEL.Location = new System.Drawing.Point(23, 157);
            this.lblUGEL.Name = "lblUGEL";
            this.lblUGEL.Size = new System.Drawing.Size(53, 18);
            this.lblUGEL.TabIndex = 19;
            this.lblUGEL.Text = "UGEL:";
            // 
            // lblIIEE
            // 
            this.lblIIEE.AutoSize = true;
            this.lblIIEE.Location = new System.Drawing.Point(23, 200);
            this.lblIIEE.Name = "lblIIEE";
            this.lblIIEE.Size = new System.Drawing.Size(76, 36);
            this.lblIIEE.TabIndex = 20;
            this.lblIIEE.Text = "Institucion\r\nEducativa:";
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(23, 243);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(77, 18);
            this.lblConcepto.TabIndex = 21;
            this.lblConcepto.Text = "Concepto:";
            // 
            // lblSituacion
            // 
            this.lblSituacion.AutoSize = true;
            this.lblSituacion.Location = new System.Drawing.Point(23, 286);
            this.lblSituacion.Name = "lblSituacion";
            this.lblSituacion.Size = new System.Drawing.Size(73, 18);
            this.lblSituacion.TabIndex = 22;
            this.lblSituacion.Text = "Situacion:";
            // 
            // txtNroProyecto
            // 
            this.txtNroProyecto.Location = new System.Drawing.Point(119, 31);
            this.txtNroProyecto.Name = "txtNroProyecto";
            this.txtNroProyecto.Size = new System.Drawing.Size(100, 24);
            this.txtNroProyecto.TabIndex = 20;
            // 
            // txtNroResolucion
            // 
            this.txtNroResolucion.Location = new System.Drawing.Point(119, 74);
            this.txtNroResolucion.Name = "txtNroResolucion";
            this.txtNroResolucion.Size = new System.Drawing.Size(100, 24);
            this.txtNroResolucion.TabIndex = 21;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(119, 117);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 26);
            this.cmbTipo.TabIndex = 22;
            // 
            // cmbUGEL
            // 
            this.cmbUGEL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUGEL.FormattingEnabled = true;
            this.cmbUGEL.Location = new System.Drawing.Point(119, 160);
            this.cmbUGEL.Name = "cmbUGEL";
            this.cmbUGEL.Size = new System.Drawing.Size(121, 26);
            this.cmbUGEL.TabIndex = 23;
            // 
            // cmbSituacion
            // 
            this.cmbSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacion.FormattingEnabled = true;
            this.cmbSituacion.Location = new System.Drawing.Point(119, 289);
            this.cmbSituacion.Name = "cmbSituacion";
            this.cmbSituacion.Size = new System.Drawing.Size(121, 26);
            this.cmbSituacion.TabIndex = 26;
            // 
            // cmbIIEE
            // 
            this.cmbIIEE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIIEE.FormattingEnabled = true;
            this.cmbIIEE.Items.AddRange(new object[] {
            "12 de Octubre ",
            "40001",
            "40002 AL Aire Libre",
            "40007 Gilberto Ochoa",
            "40020",
            "40025 Santa Dorotea",
            "40035 Víctor Andrés Belaunde",
            "40039 Santa María",
            "40040 José Trinidad Morán",
            "40040 José Trinidad Morán",
            "40042 República de Francia",
            "40045 Livia Bernal de Baltazar",
            "40046 José Cornejo Acosta",
            "40046 José Cornejo Acosta",
            "40048 Antonio José de Sucre",
            "40049 Francisco Bolognesi",
            "40049 Francisco Bolognesi",
            "40052 El Peruano del Milenio",
            "40052 El Peruano del Milenio",
            "40053 Manuel Tapia Fuentes",
            "40055 Romeo Luna Victoria",
            "40056 Horacio Zeballos Gamez",
            "40056 Horacio Zeballos Gamez",
            "40058 Ignacio Álvarez Thomas",
            "40061 Estado de Suecia",
            "40078 Sagrado Corazón",
            "40081 Mazeyra Acosta",
            "40092 José Domingo Zuzunaga",
            "40099",
            "40103 Libertadores de América",
            "40106",
            "40141 Virgen de Guadalupe",
            "40173 Divino Niño Jesús",
            "40202 Charlotte",
            "40616",
            "40616",
            "40669 Deán Valdivia",
            "40670 El Edén Fe y Alegría",
            "40672 DoreanWillians",
            "40677 San Miguel Febres Cordero",
            "40694 Centro de Innovación Pedagógico ISPA",
            "40705 Peruarbo",
            "41003 Almirante Miguel Grau",
            "41005 Héroes de Angamos ",
            "41014 Fortunata Gutiérrez",
            "41019 República de Venezuela",
            "41024",
            "41025 Doscientas Millas Peruanas",
            "41026 María Murillo de Bernal",
            "Arequipa",
            "Casa de Caridad Artes y Oficios",
            "Ciudad de Dios",
            "Cristo Morado",
            "Cristo Rey",
            "Gran Pachacutec",
            "Honorio Delgado Espinoza",
            "Inicial Honorio Delgado Espinoza",
            "Jose Canzina",
            "José Caruana",
            "La Recoleta",
            "León XIII",
            "León XIII – CIRCA",
            "Mayta Capac",
            "Micaela Bastidas",
            "Newton (IEP) Gestion Privada",
            "Nuestra Señora de la Asunción",
            "Nuestra Señora de los Dolores",
            "San Bernardo",
            "San Juan Apóstol",
            "San Juan Apóstol",
            "San Pio X",
            "Santo Tomás de Aquino",
            "Santo Tomás de Aquino",
            "Señor de los Milagros"});
            this.cmbIIEE.Location = new System.Drawing.Point(119, 203);
            this.cmbIIEE.Name = "cmbIIEE";
            this.cmbIIEE.Size = new System.Drawing.Size(258, 26);
            this.cmbIIEE.Sorted = true;
            this.cmbIIEE.TabIndex = 24;
            // 
            // cmbConcepto
            // 
            this.cmbConcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConcepto.FormattingEnabled = true;
            this.cmbConcepto.Items.AddRange(new object[] {
            "Adeudo Bonificacion Familiar",
            "Adeudo Bonificacion Preparacion de Clases",
            "Adeudo DU 037",
            "Adeudo Maestria",
            "Ascenso",
            "Asignación por Tiempo de Servicio",
            "Bonificacion Familiar",
            "Bonificacion Personal",
            "Bono de Desepeño Escolar ECE",
            "Bonos de Atracción",
            "Cese",
            "Compensatoria por Tiempo de Servicio",
            "Contrato",
            "Maestria",
            "Nombramiento",
            "Permuta",
            "Reajuste de Bonificacion Personal",
            "Reasignación",
            "Reubicación",
            "Rotación",
            "Sepelio y Luto",
            "Vacaciones Truncas"});
            this.cmbConcepto.Location = new System.Drawing.Point(119, 243);
            this.cmbConcepto.Name = "cmbConcepto";
            this.cmbConcepto.Size = new System.Drawing.Size(313, 26);
            this.cmbConcepto.Sorted = true;
            this.cmbConcepto.TabIndex = 25;
            // 
            // tabPageBuscarModificarResol
            // 
            this.tabPageBuscarModificarResol.Controls.Add(this.dataGridViewResoluciones);
            this.tabPageBuscarModificarResol.Controls.Add(this.d);
            this.tabPageBuscarModificarResol.Location = new System.Drawing.Point(4, 27);
            this.tabPageBuscarModificarResol.Name = "tabPageBuscarModificarResol";
            this.tabPageBuscarModificarResol.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscarModificarResol.Size = new System.Drawing.Size(910, 452);
            this.tabPageBuscarModificarResol.TabIndex = 1;
            this.tabPageBuscarModificarResol.Text = "Gestion de Resoluciones";
            this.tabPageBuscarModificarResol.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResoluciones
            // 
            this.dataGridViewResoluciones.AllowUserToAddRows = false;
            this.dataGridViewResoluciones.AllowUserToDeleteRows = false;
            this.dataGridViewResoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResoluciones.Location = new System.Drawing.Point(16, 119);
            this.dataGridViewResoluciones.Name = "dataGridViewResoluciones";
            this.dataGridViewResoluciones.ReadOnly = true;
            this.dataGridViewResoluciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResoluciones.Size = new System.Drawing.Size(875, 313);
            this.dataGridViewResoluciones.TabIndex = 1;
            this.dataGridViewResoluciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResoluciones_CellContentClick);
            this.dataGridViewResoluciones.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewResoluciones_CellFormatting);
            this.dataGridViewResoluciones.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewResoluciones_CellMouseClick);
            this.dataGridViewResoluciones.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewResoluciones_CellMouseDoubleClick);
            this.dataGridViewResoluciones.SelectionChanged += new System.EventHandler(this.dataGridViewResoluciones_SelectionChanged);
            // 
            // d
            // 
            this.d.Controls.Add(this.btnEliminarResolucion);
            this.d.Controls.Add(this.lblBuscarNroResolucion);
            this.d.Controls.Add(this.txtBuscarNroProyecto);
            this.d.Controls.Add(this.txtBuscarNroResolucion);
            this.d.Controls.Add(this.btnBuscarResolucion);
            this.d.Controls.Add(this.lblBuscarNroProyecto);
            this.d.Location = new System.Drawing.Point(16, 18);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(875, 83);
            this.d.TabIndex = 0;
            this.d.TabStop = false;
            this.d.Text = "Buscar Resolucion";
            // 
            // btnEliminarResolucion
            // 
            this.btnEliminarResolucion.Location = new System.Drawing.Point(705, 32);
            this.btnEliminarResolucion.Name = "btnEliminarResolucion";
            this.btnEliminarResolucion.Size = new System.Drawing.Size(140, 36);
            this.btnEliminarResolucion.TabIndex = 6;
            this.btnEliminarResolucion.Text = "Eliminar";
            this.btnEliminarResolucion.UseVisualStyleBackColor = true;
            this.btnEliminarResolucion.Click += new System.EventHandler(this.btnEliminarResolucion_Click);
            // 
            // lblBuscarNroResolucion
            // 
            this.lblBuscarNroResolucion.AutoSize = true;
            this.lblBuscarNroResolucion.Location = new System.Drawing.Point(271, 32);
            this.lblBuscarNroResolucion.Name = "lblBuscarNroResolucion";
            this.lblBuscarNroResolucion.Size = new System.Drawing.Size(87, 36);
            this.lblBuscarNroResolucion.TabIndex = 5;
            this.lblBuscarNroResolucion.Text = "Numero de \r\nResolucion:";
            // 
            // txtBuscarNroProyecto
            // 
            this.txtBuscarNroProyecto.Location = new System.Drawing.Point(364, 37);
            this.txtBuscarNroProyecto.Name = "txtBuscarNroProyecto";
            this.txtBuscarNroProyecto.Size = new System.Drawing.Size(150, 24);
            this.txtBuscarNroProyecto.TabIndex = 4;
            // 
            // txtBuscarNroResolucion
            // 
            this.txtBuscarNroResolucion.Location = new System.Drawing.Point(106, 37);
            this.txtBuscarNroResolucion.Name = "txtBuscarNroResolucion";
            this.txtBuscarNroResolucion.Size = new System.Drawing.Size(150, 24);
            this.txtBuscarNroResolucion.TabIndex = 3;
            // 
            // btnBuscarResolucion
            // 
            this.btnBuscarResolucion.Location = new System.Drawing.Point(553, 32);
            this.btnBuscarResolucion.Name = "btnBuscarResolucion";
            this.btnBuscarResolucion.Size = new System.Drawing.Size(111, 36);
            this.btnBuscarResolucion.TabIndex = 2;
            this.btnBuscarResolucion.Text = "Buscar";
            this.btnBuscarResolucion.UseVisualStyleBackColor = true;
            this.btnBuscarResolucion.Click += new System.EventHandler(this.btnBuscarResolucion_Click);
            // 
            // lblBuscarNroProyecto
            // 
            this.lblBuscarNroProyecto.AutoSize = true;
            this.lblBuscarNroProyecto.Location = new System.Drawing.Point(18, 32);
            this.lblBuscarNroProyecto.Name = "lblBuscarNroProyecto";
            this.lblBuscarNroProyecto.Size = new System.Drawing.Size(82, 36);
            this.lblBuscarNroProyecto.TabIndex = 0;
            this.lblBuscarNroProyecto.Text = "Numero de\r\n Proyecto:";
            // 
            // tabPageDocentesEIIEE
            // 
            this.tabPageDocentesEIIEE.Controls.Add(this.dataGridViewDocentes);
            this.tabPageDocentesEIIEE.Controls.Add(this.groupBoxInfoDocente);
            this.tabPageDocentesEIIEE.Location = new System.Drawing.Point(4, 27);
            this.tabPageDocentesEIIEE.Name = "tabPageDocentesEIIEE";
            this.tabPageDocentesEIIEE.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocentesEIIEE.Size = new System.Drawing.Size(910, 452);
            this.tabPageDocentesEIIEE.TabIndex = 2;
            this.tabPageDocentesEIIEE.Text = "Docentes e Instituciones";
            this.tabPageDocentesEIIEE.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDocentes
            // 
            this.dataGridViewDocentes.AllowUserToAddRows = false;
            this.dataGridViewDocentes.AllowUserToDeleteRows = false;
            this.dataGridViewDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocentes.Location = new System.Drawing.Point(339, 27);
            this.dataGridViewDocentes.Name = "dataGridViewDocentes";
            this.dataGridViewDocentes.ReadOnly = true;
            this.dataGridViewDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDocentes.Size = new System.Drawing.Size(547, 403);
            this.dataGridViewDocentes.TabIndex = 5;
            this.dataGridViewDocentes.SelectionChanged += new System.EventHandler(this.dataGridViewDocentes_SelectionChanged);
            // 
            // groupBoxInfoDocente
            // 
            this.groupBoxInfoDocente.Controls.Add(this.btnActualizarDocente);
            this.groupBoxInfoDocente.Controls.Add(this.lblDNI);
            this.groupBoxInfoDocente.Controls.Add(this.btnRegistrarDocente);
            this.groupBoxInfoDocente.Controls.Add(this.lblApellidoPaterno);
            this.groupBoxInfoDocente.Controls.Add(this.lblApellidoMaterno);
            this.groupBoxInfoDocente.Controls.Add(this.lblNombres);
            this.groupBoxInfoDocente.Controls.Add(this.txtDNI);
            this.groupBoxInfoDocente.Controls.Add(this.txtApellidoPaterno);
            this.groupBoxInfoDocente.Controls.Add(this.txtApellidoMaterno);
            this.groupBoxInfoDocente.Controls.Add(this.txtNombres);
            this.groupBoxInfoDocente.Location = new System.Drawing.Point(20, 27);
            this.groupBoxInfoDocente.Name = "groupBoxInfoDocente";
            this.groupBoxInfoDocente.Size = new System.Drawing.Size(299, 266);
            this.groupBoxInfoDocente.TabIndex = 4;
            this.groupBoxInfoDocente.TabStop = false;
            this.groupBoxInfoDocente.Text = "Informacion de Docente";
            // 
            // btnActualizarDocente
            // 
            this.btnActualizarDocente.Location = new System.Drawing.Point(164, 204);
            this.btnActualizarDocente.Name = "btnActualizarDocente";
            this.btnActualizarDocente.Size = new System.Drawing.Size(119, 41);
            this.btnActualizarDocente.TabIndex = 30;
            this.btnActualizarDocente.Text = "Actualizar";
            this.btnActualizarDocente.UseVisualStyleBackColor = true;
            this.btnActualizarDocente.Click += new System.EventHandler(this.btnActualizarDocente_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(21, 32);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(37, 18);
            this.lblDNI.TabIndex = 22;
            this.lblDNI.Text = "DNI:";
            // 
            // btnRegistrarDocente
            // 
            this.btnRegistrarDocente.Location = new System.Drawing.Point(24, 204);
            this.btnRegistrarDocente.Name = "btnRegistrarDocente";
            this.btnRegistrarDocente.Size = new System.Drawing.Size(117, 41);
            this.btnRegistrarDocente.TabIndex = 5;
            this.btnRegistrarDocente.Text = "Registrar";
            this.btnRegistrarDocente.UseVisualStyleBackColor = true;
            this.btnRegistrarDocente.Click += new System.EventHandler(this.btnRegistrarDocente_Click);
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(21, 73);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(64, 36);
            this.lblApellidoPaterno.TabIndex = 23;
            this.lblApellidoPaterno.Text = "Apellido\r\nPaterno:";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(21, 114);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(67, 36);
            this.lblApellidoMaterno.TabIndex = 24;
            this.lblApellidoMaterno.Text = "Apellido \r\nMaterno:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(21, 155);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(74, 18);
            this.lblNombres.TabIndex = 25;
            this.lblNombres.Text = "Nombres:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(130, 35);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(92, 24);
            this.txtDNI.TabIndex = 26;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(130, 76);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(115, 24);
            this.txtApellidoPaterno.TabIndex = 27;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(130, 117);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(115, 24);
            this.txtApellidoMaterno.TabIndex = 28;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(130, 158);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(153, 24);
            this.txtNombres.TabIndex = 29;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(208, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(520, 31);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Sistema de Resoluciones - UGEL NORTE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UGELNorte.Resoluciones.Presentation.Properties.Resources.LogoUGEL;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 108);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormResoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 621);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelResoluciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResoluciones";
            this.Text = "Sistema de Resoluciones v1.0 - UGEL NORTE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormResoluciones_FormClosing);
            this.Load += new System.EventHandler(this.FormResoluciones_Load);
            this.panelResoluciones.ResumeLayout(false);
            this.tabCtrlResoluciones.ResumeLayout(false);
            this.tabPageRegResoluciones.ResumeLayout(false);
            this.groupBoxInfoSentencia.ResumeLayout(false);
            this.groupBoxInfoSentencia.PerformLayout();
            this.groupBoxInfoResoluciones.ResumeLayout(false);
            this.groupBoxInfoResoluciones.PerformLayout();
            this.tabPageBuscarModificarResol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResoluciones)).EndInit();
            this.d.ResumeLayout(false);
            this.d.PerformLayout();
            this.tabPageDocentesEIIEE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocentes)).EndInit();
            this.groupBoxInfoDocente.ResumeLayout(false);
            this.groupBoxInfoDocente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelResoluciones;
        private System.Windows.Forms.TabControl tabCtrlResoluciones;
        private System.Windows.Forms.TabPage tabPageRegResoluciones;
        private System.Windows.Forms.TabPage tabPageBuscarModificarResol;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxInfoSentencia;
        private System.Windows.Forms.GroupBox groupBoxInfoResoluciones;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRegistrarResolucion;
        private System.Windows.Forms.GroupBox d;
        private System.Windows.Forms.Label lblBuscarNroProyecto;
        private System.Windows.Forms.Button btnBuscarResolucion;
        private System.Windows.Forms.Button btnImportarPDF;
        private System.Windows.Forms.Label lblFechaSentencia;
        private System.Windows.Forms.Label lblSentencia;
        private System.Windows.Forms.Label lblExpedienteJudicial;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtSentencia;
        private System.Windows.Forms.TextBox txtExpedienteJudicial;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.DateTimePicker dtFechaSentencia;
        private System.Windows.Forms.Label lblNroProyecto;
        private System.Windows.Forms.Label lblNroResolucion;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblUGEL;
        private System.Windows.Forms.Label lblIIEE;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.Label lblSituacion;
        private System.Windows.Forms.TextBox txtNroProyecto;
        private System.Windows.Forms.MaskedTextBox txtNroResolucion;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbUGEL;
        private System.Windows.Forms.ComboBox cmbSituacion;
        private System.Windows.Forms.ComboBox cmbIIEE;
        private System.Windows.Forms.ComboBox cmbConcepto;
        private System.Windows.Forms.MaskedTextBox txtBuscarNroResolucion;
        private System.Windows.Forms.MaskedTextBox txtBuscarNroProyecto;
        private System.Windows.Forms.Label lblBuscarNroResolucion;
        private System.Windows.Forms.Button btnEliminarResolucion;
        private System.Windows.Forms.DataGridView dataGridViewResoluciones;
        private System.Windows.Forms.Label lblDNIDocente;
        private System.Windows.Forms.TextBox txtDNIDocenteResolucion;
        private System.Windows.Forms.TabPage tabPageDocentesEIIEE;
        private System.Windows.Forms.GroupBox groupBoxInfoDocente;
        private System.Windows.Forms.Button btnActualizarDocente;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnRegistrarDocente;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.DataGridView dataGridViewDocentes;
    }
}


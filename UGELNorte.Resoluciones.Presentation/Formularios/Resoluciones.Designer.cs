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
            this.btnRegistrarResolucion = new System.Windows.Forms.Button();
            this.groupBoxInfoDocente = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.txtApellidoMaterno = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.groupBoxInfoSentencia = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFechaSentencia = new System.Windows.Forms.Label();
            this.lblSentencia = new System.Windows.Forms.Label();
            this.lblExpedienteJudicial = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtSentencia = new System.Windows.Forms.TextBox();
            this.txtExpedienteJudicial = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.dtFechaSentencia = new System.Windows.Forms.DateTimePicker();
            this.groupBoxInfoResoluciones = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.cmbConcepto = new System.Windows.Forms.ComboBox();
            this.cmbSituacion = new System.Windows.Forms.ComboBox();
            this.txtIIEE = new System.Windows.Forms.TextBox();
            this.tabPageBuscarModificarResol = new System.Windows.Forms.TabPage();
            this.dataGridViewResoluciones = new System.Windows.Forms.DataGridView();
            this.d = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBuscarResolucion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnBuscarResolucion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelResoluciones.SuspendLayout();
            this.tabCtrlResoluciones.SuspendLayout();
            this.tabPageRegResoluciones.SuspendLayout();
            this.groupBoxInfoDocente.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBoxInfoSentencia.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxInfoResoluciones.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageBuscarModificarResol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResoluciones)).BeginInit();
            this.d.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelResoluciones
            // 
            this.panelResoluciones.Controls.Add(this.tabCtrlResoluciones);
            this.panelResoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelResoluciones.Location = new System.Drawing.Point(12, 134);
            this.panelResoluciones.Name = "panelResoluciones";
            this.panelResoluciones.Size = new System.Drawing.Size(924, 518);
            this.panelResoluciones.TabIndex = 0;
            // 
            // tabCtrlResoluciones
            // 
            this.tabCtrlResoluciones.Controls.Add(this.tabPageRegResoluciones);
            this.tabCtrlResoluciones.Controls.Add(this.tabPageBuscarModificarResol);
            this.tabCtrlResoluciones.Location = new System.Drawing.Point(3, 6);
            this.tabCtrlResoluciones.Name = "tabCtrlResoluciones";
            this.tabCtrlResoluciones.SelectedIndex = 0;
            this.tabCtrlResoluciones.Size = new System.Drawing.Size(918, 509);
            this.tabCtrlResoluciones.TabIndex = 0;
            // 
            // tabPageRegResoluciones
            // 
            this.tabPageRegResoluciones.Controls.Add(this.btnRegistrarResolucion);
            this.tabPageRegResoluciones.Controls.Add(this.groupBoxInfoDocente);
            this.tabPageRegResoluciones.Controls.Add(this.groupBoxInfoSentencia);
            this.tabPageRegResoluciones.Controls.Add(this.groupBoxInfoResoluciones);
            this.tabPageRegResoluciones.Location = new System.Drawing.Point(4, 27);
            this.tabPageRegResoluciones.Name = "tabPageRegResoluciones";
            this.tabPageRegResoluciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegResoluciones.Size = new System.Drawing.Size(910, 478);
            this.tabPageRegResoluciones.TabIndex = 0;
            this.tabPageRegResoluciones.Text = "Registro de Resoluciones";
            this.tabPageRegResoluciones.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarResolucion
            // 
            this.btnRegistrarResolucion.Location = new System.Drawing.Point(139, 380);
            this.btnRegistrarResolucion.Name = "btnRegistrarResolucion";
            this.btnRegistrarResolucion.Size = new System.Drawing.Size(180, 49);
            this.btnRegistrarResolucion.TabIndex = 4;
            this.btnRegistrarResolucion.Text = "Registrar Resolucion";
            this.btnRegistrarResolucion.UseVisualStyleBackColor = true;
            // 
            // groupBoxInfoDocente
            // 
            this.groupBoxInfoDocente.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxInfoDocente.Location = new System.Drawing.Point(438, 234);
            this.groupBoxInfoDocente.Name = "groupBoxInfoDocente";
            this.groupBoxInfoDocente.Size = new System.Drawing.Size(437, 195);
            this.groupBoxInfoDocente.TabIndex = 3;
            this.groupBoxInfoDocente.TabStop = false;
            this.groupBoxInfoDocente.Text = "Informacion de Docente";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.64756F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.35243F));
            this.tableLayoutPanel3.Controls.Add(this.lblDNI, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblApellidoPaterno, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblApellidoMaterno, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblNombres, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtDNI, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtApellidoPaterno, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtApellidoMaterno, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtNombres, 1, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(19, 23);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(412, 166);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(3, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(37, 18);
            this.lblDNI.TabIndex = 0;
            this.lblDNI.Text = "DNI:";
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(3, 41);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(64, 36);
            this.lblApellidoPaterno.TabIndex = 1;
            this.lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(3, 82);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(67, 36);
            this.lblApellidoMaterno.TabIndex = 2;
            this.lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(3, 123);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(74, 18);
            this.lblNombres.TabIndex = 3;
            this.lblNombres.Text = "Nombres:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(112, 3);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(140, 24);
            this.txtDNI.TabIndex = 18;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(112, 44);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(201, 24);
            this.txtApellidoPaterno.TabIndex = 19;
            // 
            // txtApellidoMaterno
            // 
            this.txtApellidoMaterno.Location = new System.Drawing.Point(112, 85);
            this.txtApellidoMaterno.Name = "txtApellidoMaterno";
            this.txtApellidoMaterno.Size = new System.Drawing.Size(201, 24);
            this.txtApellidoMaterno.TabIndex = 20;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(112, 126);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(286, 24);
            this.txtNombres.TabIndex = 21;
            // 
            // groupBoxInfoSentencia
            // 
            this.groupBoxInfoSentencia.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxInfoSentencia.Location = new System.Drawing.Point(438, 21);
            this.groupBoxInfoSentencia.Name = "groupBoxInfoSentencia";
            this.groupBoxInfoSentencia.Size = new System.Drawing.Size(437, 207);
            this.groupBoxInfoSentencia.TabIndex = 2;
            this.groupBoxInfoSentencia.TabStop = false;
            this.groupBoxInfoSentencia.Text = "Informacion de Sentencia";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.64756F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.35243F));
            this.tableLayoutPanel2.Controls.Add(this.lblFechaSentencia, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSentencia, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblExpedienteJudicial, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblMonto, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtSentencia, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtExpedienteJudicial, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtMonto, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.dtFechaSentencia, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(19, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(412, 166);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // lblFechaSentencia
            // 
            this.lblFechaSentencia.AutoSize = true;
            this.lblFechaSentencia.Location = new System.Drawing.Point(3, 0);
            this.lblFechaSentencia.Name = "lblFechaSentencia";
            this.lblFechaSentencia.Size = new System.Drawing.Size(77, 36);
            this.lblFechaSentencia.TabIndex = 0;
            this.lblFechaSentencia.Text = "Fecha de Sentencia:";
            // 
            // lblSentencia
            // 
            this.lblSentencia.AutoSize = true;
            this.lblSentencia.Location = new System.Drawing.Point(3, 41);
            this.lblSentencia.Name = "lblSentencia";
            this.lblSentencia.Size = new System.Drawing.Size(77, 18);
            this.lblSentencia.TabIndex = 1;
            this.lblSentencia.Text = "Sentencia:";
            // 
            // lblExpedienteJudicial
            // 
            this.lblExpedienteJudicial.AutoSize = true;
            this.lblExpedienteJudicial.Location = new System.Drawing.Point(3, 82);
            this.lblExpedienteJudicial.Name = "lblExpedienteJudicial";
            this.lblExpedienteJudicial.Size = new System.Drawing.Size(84, 36);
            this.lblExpedienteJudicial.TabIndex = 2;
            this.lblExpedienteJudicial.Text = "Expediente Judicial:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(3, 123);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(55, 18);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "Monto:";
            // 
            // txtSentencia
            // 
            this.txtSentencia.Location = new System.Drawing.Point(112, 44);
            this.txtSentencia.Name = "txtSentencia";
            this.txtSentencia.Size = new System.Drawing.Size(200, 24);
            this.txtSentencia.TabIndex = 15;
            // 
            // txtExpedienteJudicial
            // 
            this.txtExpedienteJudicial.Location = new System.Drawing.Point(112, 85);
            this.txtExpedienteJudicial.Name = "txtExpedienteJudicial";
            this.txtExpedienteJudicial.Size = new System.Drawing.Size(286, 24);
            this.txtExpedienteJudicial.TabIndex = 16;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(112, 126);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(106, 24);
            this.txtMonto.TabIndex = 17;
            // 
            // dtFechaSentencia
            // 
            this.dtFechaSentencia.CustomFormat = "dd/MM/yyyy";
            this.dtFechaSentencia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaSentencia.Location = new System.Drawing.Point(112, 3);
            this.dtFechaSentencia.Name = "dtFechaSentencia";
            this.dtFechaSentencia.Size = new System.Drawing.Size(119, 24);
            this.dtFechaSentencia.TabIndex = 14;
            // 
            // groupBoxInfoResoluciones
            // 
            this.groupBoxInfoResoluciones.Controls.Add(this.tableLayoutPanel1);
            this.groupBoxInfoResoluciones.Location = new System.Drawing.Point(19, 16);
            this.groupBoxInfoResoluciones.Name = "groupBoxInfoResoluciones";
            this.groupBoxInfoResoluciones.Size = new System.Drawing.Size(398, 342);
            this.groupBoxInfoResoluciones.TabIndex = 1;
            this.groupBoxInfoResoluciones.TabStop = false;
            this.groupBoxInfoResoluciones.Text = "Informacion de Resolucion";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.53763F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.46236F));
            this.tableLayoutPanel1.Controls.Add(this.lblNroProyecto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNroResolucion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTipo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblUGEL, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblIIEE, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblConcepto, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSituacion, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtNroProyecto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNroResolucion, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbTipo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbUGEL, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbConcepto, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbSituacion, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtIIEE, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 308);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblNroProyecto
            // 
            this.lblNroProyecto.AutoSize = true;
            this.lblNroProyecto.Location = new System.Drawing.Point(3, 0);
            this.lblNroProyecto.Name = "lblNroProyecto";
            this.lblNroProyecto.Size = new System.Drawing.Size(72, 36);
            this.lblNroProyecto.TabIndex = 0;
            this.lblNroProyecto.Text = "Nro de Proyecto:";
            // 
            // lblNroResolucion
            // 
            this.lblNroResolucion.AutoSize = true;
            this.lblNroResolucion.Location = new System.Drawing.Point(3, 43);
            this.lblNroResolucion.Name = "lblNroResolucion";
            this.lblNroResolucion.Size = new System.Drawing.Size(87, 36);
            this.lblNroResolucion.TabIndex = 1;
            this.lblNroResolucion.Text = "Nro De Resolucion:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(3, 86);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(41, 18);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblUGEL
            // 
            this.lblUGEL.AutoSize = true;
            this.lblUGEL.Location = new System.Drawing.Point(3, 129);
            this.lblUGEL.Name = "lblUGEL";
            this.lblUGEL.Size = new System.Drawing.Size(53, 18);
            this.lblUGEL.TabIndex = 3;
            this.lblUGEL.Text = "UGEL:";
            // 
            // lblIIEE
            // 
            this.lblIIEE.AutoSize = true;
            this.lblIIEE.Location = new System.Drawing.Point(3, 172);
            this.lblIIEE.Name = "lblIIEE";
            this.lblIIEE.Size = new System.Drawing.Size(78, 36);
            this.lblIIEE.TabIndex = 4;
            this.lblIIEE.Text = "Institucion Educativa:";
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(3, 215);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(77, 18);
            this.lblConcepto.TabIndex = 5;
            this.lblConcepto.Text = "Concepto:";
            // 
            // lblSituacion
            // 
            this.lblSituacion.AutoSize = true;
            this.lblSituacion.Location = new System.Drawing.Point(3, 258);
            this.lblSituacion.Name = "lblSituacion";
            this.lblSituacion.Size = new System.Drawing.Size(73, 18);
            this.lblSituacion.TabIndex = 6;
            this.lblSituacion.Text = "Situacion:";
            // 
            // txtNroProyecto
            // 
            this.txtNroProyecto.Location = new System.Drawing.Point(97, 3);
            this.txtNroProyecto.Name = "txtNroProyecto";
            this.txtNroProyecto.Size = new System.Drawing.Size(100, 24);
            this.txtNroProyecto.TabIndex = 7;
            // 
            // txtNroResolucion
            // 
            this.txtNroResolucion.Location = new System.Drawing.Point(97, 46);
            this.txtNroResolucion.Name = "txtNroResolucion";
            this.txtNroResolucion.Size = new System.Drawing.Size(100, 24);
            this.txtNroResolucion.TabIndex = 8;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(97, 89);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 26);
            this.cmbTipo.TabIndex = 9;
            // 
            // cmbUGEL
            // 
            this.cmbUGEL.FormattingEnabled = true;
            this.cmbUGEL.Location = new System.Drawing.Point(97, 132);
            this.cmbUGEL.Name = "cmbUGEL";
            this.cmbUGEL.Size = new System.Drawing.Size(121, 26);
            this.cmbUGEL.TabIndex = 10;
            // 
            // cmbConcepto
            // 
            this.cmbConcepto.FormattingEnabled = true;
            this.cmbConcepto.Location = new System.Drawing.Point(97, 218);
            this.cmbConcepto.Name = "cmbConcepto";
            this.cmbConcepto.Size = new System.Drawing.Size(121, 26);
            this.cmbConcepto.TabIndex = 12;
            // 
            // cmbSituacion
            // 
            this.cmbSituacion.FormattingEnabled = true;
            this.cmbSituacion.Location = new System.Drawing.Point(97, 261);
            this.cmbSituacion.Name = "cmbSituacion";
            this.cmbSituacion.Size = new System.Drawing.Size(121, 26);
            this.cmbSituacion.TabIndex = 13;
            // 
            // txtIIEE
            // 
            this.txtIIEE.Location = new System.Drawing.Point(97, 175);
            this.txtIIEE.Name = "txtIIEE";
            this.txtIIEE.Size = new System.Drawing.Size(272, 24);
            this.txtIIEE.TabIndex = 11;
            // 
            // tabPageBuscarModificarResol
            // 
            this.tabPageBuscarModificarResol.Controls.Add(this.dataGridViewResoluciones);
            this.tabPageBuscarModificarResol.Controls.Add(this.d);
            this.tabPageBuscarModificarResol.Location = new System.Drawing.Point(4, 27);
            this.tabPageBuscarModificarResol.Name = "tabPageBuscarModificarResol";
            this.tabPageBuscarModificarResol.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscarModificarResol.Size = new System.Drawing.Size(910, 478);
            this.tabPageBuscarModificarResol.TabIndex = 1;
            this.tabPageBuscarModificarResol.Text = "Buscar / Modificar Resoluciones";
            this.tabPageBuscarModificarResol.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResoluciones
            // 
            this.dataGridViewResoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResoluciones.Location = new System.Drawing.Point(16, 119);
            this.dataGridViewResoluciones.Name = "dataGridViewResoluciones";
            this.dataGridViewResoluciones.Size = new System.Drawing.Size(875, 330);
            this.dataGridViewResoluciones.TabIndex = 1;
            // 
            // d
            // 
            this.d.Controls.Add(this.btnBuscarResolucion);
            this.d.Controls.Add(this.textBox1);
            this.d.Controls.Add(this.lblBuscarResolucion);
            this.d.Location = new System.Drawing.Point(16, 18);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(875, 83);
            this.d.TabIndex = 0;
            this.d.TabStop = false;
            this.d.Text = "Buscar Resolucion";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 24);
            this.textBox1.TabIndex = 1;
            // 
            // lblBuscarResolucion
            // 
            this.lblBuscarResolucion.AutoSize = true;
            this.lblBuscarResolucion.Location = new System.Drawing.Point(18, 40);
            this.lblBuscarResolucion.Name = "lblBuscarResolucion";
            this.lblBuscarResolucion.Size = new System.Drawing.Size(59, 18);
            this.lblBuscarResolucion.TabIndex = 0;
            this.lblBuscarResolucion.Text = "Buscar:";
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
            // btnBuscarResolucion
            // 
            this.btnBuscarResolucion.Location = new System.Drawing.Point(245, 38);
            this.btnBuscarResolucion.Name = "btnBuscarResolucion";
            this.btnBuscarResolucion.Size = new System.Drawing.Size(148, 23);
            this.btnBuscarResolucion.TabIndex = 2;
            this.btnBuscarResolucion.Text = "Buscar Resolucion";
            this.btnBuscarResolucion.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(948, 664);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelResoluciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormResoluciones";
            this.Text = "Sistema de Resoluciones v1.0 - UGEL NORTE";
            this.Load += new System.EventHandler(this.FormResoluciones_Load);
            this.panelResoluciones.ResumeLayout(false);
            this.tabCtrlResoluciones.ResumeLayout(false);
            this.tabPageRegResoluciones.ResumeLayout(false);
            this.groupBoxInfoDocente.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupBoxInfoSentencia.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBoxInfoResoluciones.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPageBuscarModificarResol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResoluciones)).EndInit();
            this.d.ResumeLayout(false);
            this.d.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxInfoDocente;
        private System.Windows.Forms.GroupBox groupBoxInfoSentencia;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxInfoResoluciones;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnRegistrarResolucion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.TextBox txtApellidoMaterno;
        private System.Windows.Forms.TextBox txtNombres;
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
        private System.Windows.Forms.ComboBox cmbConcepto;
        private System.Windows.Forms.ComboBox cmbSituacion;
        private System.Windows.Forms.TextBox txtIIEE;
        private System.Windows.Forms.GroupBox d;
        private System.Windows.Forms.Label lblBuscarResolucion;
        private System.Windows.Forms.DataGridView dataGridViewResoluciones;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBuscarResolucion;
    }
}


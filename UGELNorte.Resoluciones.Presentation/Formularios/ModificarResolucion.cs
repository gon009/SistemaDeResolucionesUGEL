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

namespace UGELNorte.Resoluciones.Presentation.Formularios
{
    public partial class ModificarResolucion : Form
    {
        public ModificarResolucion()
        {
            InitializeComponent();
            this.InitializeUpdate();

        }
        private void InitializeUpdate()
        {

            cmbModTipo.DataSource = Enum.GetValues(typeof(TipoResolucion));
            cmbModUGEL.DataSource = Enum.GetValues(typeof(TipoUGEL));
            cmbModSituacion.DataSource = Enum.GetValues(typeof(SituacionResolucion));
        }

        private void ModificarResolucion_Load(object sender, EventArgs e)
        {
          
        }


        private void ModificarResolucion_FormClosing(object sender, FormClosingEventArgs e)
        {
            //FormResoluciones formResoluciones = new FormResoluciones();
            //formResoluciones.Enabled = true;
        }

        private void btnModificarResolucion_Click(object sender, EventArgs e)
        {

        }
    }
}

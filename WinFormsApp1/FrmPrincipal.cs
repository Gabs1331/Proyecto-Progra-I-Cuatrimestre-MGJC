using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class FrmPrincipal: Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
        }

        private void btnTecnicos_Click(object sender, EventArgs e)
        {
            FrmTecnicos frmTecnicos = new FrmTecnicos();
            frmTecnicos.ShowDialog();
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            FrmEquipos frmEquipos = new FrmEquipos();
            frmEquipos.ShowDialog();
        }

        private void btnAsignaciones_Click(object sender, EventArgs e)
        {
            FrmAsignaciones frmAsignaciones = new FrmAsignaciones();
            frmAsignaciones.ShowDialog();
        }

        private void btnReparaciones_Click(object sender, EventArgs e)
        {
            FrmReparaciones frmReparaciones = new FrmReparaciones();
            frmReparaciones.ShowDialog();
        }

        private void btnDetallesReparacion_Click(object sender, EventArgs e)
        {
            FrmDetallesReparacion frmDetalles = new FrmDetallesReparacion();
            frmDetalles.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
   

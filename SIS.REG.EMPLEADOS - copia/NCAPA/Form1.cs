using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCAPA
{
    public partial class Frm_Presentacion : Form
    {
        public Frm_Presentacion()
        {
            InitializeComponent();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nuevoRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_EMPLEADOS NuevoEmpleado = new Frm_EMPLEADOS();
            NuevoEmpleado.ShowDialog();
        }



        private void departamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_DEPARTAMENTO NuevoDepartamento = new FRM_DEPARTAMENTO();
            NuevoDepartamento.ShowDialog();
        }

        private void pUESTOToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            FRM_PUESTO NuevoPuesto = new FRM_PUESTO();
            NuevoPuesto.ShowDialog();
        }

        private void cONTRATOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CONTRATO NuevoContrato = new FRM_CONTRATO();
            NuevoContrato.ShowDialog();
        }

        private void asistenciaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_ASISTENCIAS NuevoAsistencia = new FRM_ASISTENCIAS();
            NuevoAsistencia.ShowDialog();
        }

        private void aUSENCIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_AUSENCIAS NuevoAusencias = new FRM_AUSENCIAS();
            NuevoAusencias.ShowDialog();   
        }

        private void nominasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_NOMINAS NuevoNominas = new FRM_NOMINAS();
            NuevoNominas.ShowDialog();
        }

        private void newUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_USUARIO NuevoUsuarios = new FRM_USUARIO();
            NuevoUsuarios.ShowDialog();
        }
    }
}

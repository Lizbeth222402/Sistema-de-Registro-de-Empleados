using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_ENTIDAD;
using CAPA_NEGOCIO;

namespace NCAPA
{
    public partial class FRM_NUEVO_EMPLEADO : Form
    {
        CN_EMPLEADOS cN_EMPLEADOS = new CN_EMPLEADOS();
        CE_MEMPLEADOS mEMPLEADOS = new CE_MEMPLEADOS();

        public FRM_NUEVO_EMPLEADO()
        {
            InitializeComponent();
        }

        private void FRM_NUEVO_EMPLEADO_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void GUARDARempleado()
        {

            if (!int.TryParse(txt_iddepa.Text, out int idDep))
            {
                MessageBox.Show("El Id_departamento no es válido");
                return;
            }

            if (!int.TryParse(txt_Puesto.Text, out int idPuesto))
            {
                MessageBox.Show("El Id_puesto no es válido");
                return;
            }

            mEMPLEADOS.Id_departamento = idDep;
            mEMPLEADOS.Id_puesto = idPuesto;


            mEMPLEADOS.Nombres = txtNombre_emple.Text.Trim();
            mEMPLEADOS.Apellidos = txtapellido_Emple.Text.Trim();
            mEMPLEADOS.Fecha_nacimiento = Convert.ToDateTime(dtp_FechaN.Value);
            mEMPLEADOS.Direccion = txtdireccion_Emple.Text.Trim();
            mEMPLEADOS.Telefono = txttelefono_Emple.Text.Trim();
            mEMPLEADOS.Email = txtgmail_Emple.Text.Trim();
            mEMPLEADOS.Fecha_ingreso = Convert.ToDateTime(dtp_FechaIng.Value);
            mEMPLEADOS.Id_departamento = Convert.ToInt32(txt_iddepa.Text);
            mEMPLEADOS.Id_puesto = Convert.ToInt32(txt_Puesto.Text);



            /*MDEPARTAMENTOS.FechaINGRESO = Convert.ToDateTime(dptFecha.Value);*/


            cN_EMPLEADOS.InsertarEmpleados(mEMPLEADOS);
        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            GUARDARempleado();
        }
    }
}

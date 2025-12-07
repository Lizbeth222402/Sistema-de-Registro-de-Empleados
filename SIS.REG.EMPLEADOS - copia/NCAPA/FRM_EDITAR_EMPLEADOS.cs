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
    public partial class FRM_EDITAR_EMPLEADOS : Frm_Base
    {

        CN_EMPLEADOS XEmpleados = new CN_EMPLEADOS();
        CE_MEMPLEADOS mEMPLEADOS = new CE_MEMPLEADOS();

        public FRM_EDITAR_EMPLEADOS()
        {
            InitializeComponent();
        }

        private void FRM_EDITAR_EMPLEADOS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtNombre_emple.Text) || string.IsNullOrWhiteSpace(txtapellido_Emple.Text) || string.IsNullOrWhiteSpace(dtp_FechaN.Text) || string.IsNullOrWhiteSpace(txtdireccion_Emple.Text)
                    || string.IsNullOrWhiteSpace(txttelefono_Emple.Text) || string.IsNullOrWhiteSpace(txtgmail_Emple.Text) || string.IsNullOrWhiteSpace(dtp_FechaIng.Text))
                {
                    MessageBox.Show("Tienes que llenar todos los campos", "Editar Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     
                }
                else
                {

                    mEMPLEADOS.Id_empleado = Convert.ToInt32(txtid.Text);
                    mEMPLEADOS.Nombres = txtNombre_emple.Text;
                    mEMPLEADOS.Apellidos = txtapellido_Emple.Text;
                    mEMPLEADOS.Fecha_nacimiento = dtp_FechaN.Value;
                    mEMPLEADOS.Direccion = txtdireccion_Emple.Text;
                    mEMPLEADOS.Telefono = txttelefono_Emple.Text;
                    mEMPLEADOS.Email = txtdireccion_Emple.Text;
                    mEMPLEADOS.Fecha_ingreso = dtp_FechaIng.Value;
                    mEMPLEADOS.Id_departamento = Convert.ToInt32(txt_iddepa.Text);
                    mEMPLEADOS.Id_puesto = Convert.ToInt32(txt_Puesto.Text);


                    XEmpleados.EditarEmpleados(mEMPLEADOS);

                    MessageBox.Show("Se actualizo correctamente", "Editar Ausencias", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo Editar El Empleado" + ex.Message, "Editar Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
    }
}

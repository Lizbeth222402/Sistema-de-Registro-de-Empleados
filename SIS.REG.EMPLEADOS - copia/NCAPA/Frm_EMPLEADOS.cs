using CAPA_ENTIDAD;
using CAPA_NEGOCIO;
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
    public partial class Frm_EMPLEADOS : Frm_Base
    {

        CN_PROCEDIMIENTOS cn_Procedimientos = new CN_PROCEDIMIENTOS(); 
        CN_EMPLEADOS cN_Empleados = new CN_EMPLEADOS();
        CE_MEMPLEADOS cE_MEMPLEADOS = new CE_MEMPLEADOS();

        public Frm_EMPLEADOS()
        {
            InitializeComponent();
        }

        private void Frm_EMPLEADOS_Load(object sender, EventArgs e)
        {
            LISTAR_EMPLEADOS();
            //Evita que no esta seleccionado por defecto//
            DataGriEmpleados.ClearSelection();
            //PARA QUE NO APAREZCA EL ID//
            //DataGriEmpleados.Columns[0].Visible = false;
            //PARA EL TAMAÑO DE LAS FILAS DEL DATA GRID//
            DataGriEmpleados.Columns[1].Width = 130;
            DataGriEmpleados.Columns[2].Width = 130;
            DataGriEmpleados.Columns[3].Width = 130;
            DataGriEmpleados.Columns[4].Width = 130;
            DataGriEmpleados.Columns[5].Width = 130;
            DataGriEmpleados.Columns[6].Width = 130;
            DataGriEmpleados.Columns[7].Width = 130;
            DataGriEmpleados.Columns[8].Width = 130;
            DataGriEmpleados.Columns[9].Width = 130;



            // Cabecera
            DataGriEmpleados.EnableHeadersVisualStyles = false;
            DataGriEmpleados.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            DataGriEmpleados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGriEmpleados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Color de fondo de la tabla
            DataGriEmpleados.BackgroundColor = Color.White;

            // Filas alternadas
            DataGriEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Color selección de fila
            DataGriEmpleados.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            DataGriEmpleados.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fuente general
            DataGriEmpleados.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Borde
            DataGriEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGriEmpleados.GridColor = Color.LightGray;


            cboBuscar.Items.Add("Nombre");
            cboBuscar.Items.Add("Departamento");
            cboBuscar.SelectedIndex = 0;


        }

        //metodo para alistar//
        private void LISTAR_EMPLEADOS()
        {
            DataGriEmpleados.DataSource = cn_Procedimientos.ListarEmpleados("Sp_ListarEmpleados");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void DataGriEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            FRM_NUEVO_EMPLEADO AbrirVentanaNuevoempleado = new FRM_NUEVO_EMPLEADO();
            AbrirVentanaNuevoempleado.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }


        private void Editar()
        {
            if (DataGriEmpleados.CurrentRow == null)
            {
                MessageBox.Show("Tienes que seleccionar un empleado");
                return;
            }

            try
            {
                FRM_EDITAR_EMPLEADOS eDITAR_EMPLEADOS = new FRM_EDITAR_EMPLEADOS();

                // ID empleado (pk)
                eDITAR_EMPLEADOS.txtid.Text =
                    DataGriEmpleados.CurrentRow.Cells["Id_empleado"].Value.ToString();

                eDITAR_EMPLEADOS.txtNombre_emple.Text =
                    DataGriEmpleados.CurrentRow.Cells["Nombres"].Value.ToString();

                eDITAR_EMPLEADOS.txtapellido_Emple.Text =
                    DataGriEmpleados.CurrentRow.Cells["Apellidos"].Value.ToString();

                eDITAR_EMPLEADOS.dtp_FechaN.Value =
                    Convert.ToDateTime(DataGriEmpleados.CurrentRow.Cells["Fecha_nacimiento"].Value);

                eDITAR_EMPLEADOS.txtdireccion_Emple.Text =
                    DataGriEmpleados.CurrentRow.Cells["Direccion"].Value.ToString();

                eDITAR_EMPLEADOS.txttelefono_Emple.Text =
                    DataGriEmpleados.CurrentRow.Cells["Telefono"].Value.ToString();

                eDITAR_EMPLEADOS.txtgmail_Emple.Text =
                    DataGriEmpleados.CurrentRow.Cells["Email"].Value.ToString();

                eDITAR_EMPLEADOS.dtp_FechaIng.Value =
                    Convert.ToDateTime(DataGriEmpleados.CurrentRow.Cells["Fecha_ingreso"].Value);

                // !!! Aquí están los IDs reales, deben existir en el DataSource
                eDITAR_EMPLEADOS.txt_iddepa.Text =
                    DataGriEmpleados.CurrentRow.Cells["Id_departamento"].Value.ToString();

                eDITAR_EMPLEADOS.txt_Puesto.Text =
                    DataGriEmpleados.CurrentRow.Cells["Id_puesto"].Value.ToString();

                eDITAR_EMPLEADOS.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se seleccionó por el error : {ex.Message}", "Editar Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleados();
        }


        private void EliminarEmpleados()

        {
            if (DataGriEmpleados.Rows.Count == 0)
            {
                MessageBox.Show("Mira bien , tienes que seleccionar un Empleado", "Eliminar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    if (DataGriEmpleados.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("Deseas Empleado", "Eliminar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            cE_MEMPLEADOS.Id_empleado = Convert.ToInt32(DataGriEmpleados.SelectedRows[0].Cells[0].Value.ToString());
                            cN_Empleados.ELIMINAREmpleados(cE_MEMPLEADOS);
                            MessageBox.Show("Muy bien!! Se elimino corretamente", "Eliminar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch
                (Exception ex)
                {
                    MessageBox.Show("No se pudo Eliminar", "Eliminar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text.Trim();
            string criterio = cboBuscar.Text; // Tu ComboBox con opciones "Nombre", "Departamento"

            if (criterio == "Nombre")
            {
                DataGriEmpleados.DataSource = cN_Empleados.FiltrarPorNombre(filtro);
            }
            else if (criterio == "Departamento")
            {
                DataGriEmpleados.DataSource = cN_Empleados.FiltrarPorDepartamento(filtro);
            }
        }
    }
}

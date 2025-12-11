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
    public partial class FRM_ASISTENCIAS : Frm_Base
    {

        CN_PROCEDIMIENTOS cn_Procedimientos = new CN_PROCEDIMIENTOS();
        CN_ASISTENCIAS cN_ASISTENCIAS = new CN_ASISTENCIAS();
        CE_MASISTENCIAS cE_MASISTENCIAS = new CE_MASISTENCIAS();
        public FRM_ASISTENCIAS()
        {
            InitializeComponent();
        }

        private void FRM_ASISTENCIAS_Load(object sender, EventArgs e)
        {
            LISTAR_ASISTENCIA();

            DataGridAsistencia.ClearSelection();
            //Evita que no esta seleccionado por defecto//
            DataGridAsistencia.ClearSelection();
            //PARA QUE NO APAREZCA EL ID//
            //DataGridAsistencia.Columns[0].Visible = false;
            //PARA EL TAMAÑO DE LAS FILAS DEL DATA GRID//
            DataGridAsistencia.Columns[1].Width = 130;
            DataGridAsistencia.Columns[2].Width = 200;
            DataGridAsistencia.Columns[3].Width = 200;
            DataGridAsistencia.Columns[4].Width = 205;



               // Cabecera
            DataGridAsistencia.EnableHeadersVisualStyles = false;
            DataGridAsistencia.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            DataGridAsistencia.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridAsistencia.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                
            // Color de fondo de la tabla
            DataGridAsistencia.BackgroundColor = Color.White;

            // Filas alternadas
            DataGridAsistencia.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                
            // Color selección de fila
            DataGridAsistencia.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            DataGridAsistencia.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fuente general
            DataGridAsistencia.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Borde
            DataGridAsistencia.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridAsistencia.GridColor = Color.LightGray;

            cboBuscar.SelectedIndex = 0;

        }




        //metodo para alistar//
        private void LISTAR_ASISTENCIA()
        {
            DataGridAsistencia.DataSource = cn_Procedimientos.ListarAsistencias("SP_LISTAR_ASISTENCIAS");


        }

        private void BtncerrarD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuveo_Click(object sender, EventArgs e)
        {
            FRM_NUEVO_ASISTENCIA AbrirNuevoAsistencia = new FRM_NUEVO_ASISTENCIA();
            AbrirNuevoAsistencia.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {


            if (DataGridAsistencia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tienes que seleccionar una Asistencia");
                return;
            }
            else
            {
                try
                {
                    FRM_EDITAR_ASISTENCIAS eDITAR_ASISTENCIAS = new FRM_EDITAR_ASISTENCIAS();


                    //ID ASISTENCIA
                    eDITAR_ASISTENCIAS.txtIdAsistencia.Text =
                    DataGridAsistencia.CurrentRow.Cells[0].Value.ToString(); // Id_asistencia (PK)

                    // ID ASISTENCIA empleado
                    eDITAR_ASISTENCIAS.txtid_emp_asistencia.Text =
                        DataGridAsistencia.CurrentRow.Cells[0].Value.ToString();



                    // FECHA
                    eDITAR_ASISTENCIAS.dtp_FechaAsis.Value =
                        Convert.ToDateTime(DataGridAsistencia.CurrentRow.Cells[1].Value);

                    // HORA ENTRADA (PUEDE SER NULL)
                    if (DataGridAsistencia.CurrentRow.Cells[2].Value != DBNull.Value)
                        eDITAR_ASISTENCIAS.dtp_HoraEntra.Value =
                            DateTime.Today.Add((TimeSpan)DataGridAsistencia.CurrentRow.Cells[2].Value);

                    // HORA SALIDA (PUEDE SER NULL)
                    if (DataGridAsistencia.CurrentRow.Cells[3].Value != DBNull.Value)
                        eDITAR_ASISTENCIAS.dtp_HoraSalidadAsistencia.Value =
                            DateTime.Today.Add((TimeSpan)DataGridAsistencia.CurrentRow.Cells[3].Value);

                    // ESTADO
                    eDITAR_ASISTENCIAS.txtEstado.Text =
                        DataGridAsistencia.CurrentRow.Cells[4].Value.ToString();

                    eDITAR_ASISTENCIAS.ShowDialog();

                    eDITAR_ASISTENCIAS.ShowDialog();
                    LISTAR_ASISTENCIA(); // ✅ RECARGA AUTOMÁTICA
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "No se pudo cargar la asistencia por este error: " + ex.Message,
                        "Editar Asistencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }


        }

        private void btnEliminar_Asistencia_Click(object sender, EventArgs e)
        {
            EliminarAsistencia();
        }

        private void EliminarAsistencia()

        {
            if (DataGridAsistencia.Rows.Count == 0)
            {
                MessageBox.Show("Mira bien , tienes que seleccionar un Asistencia", "Eliminar Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    if (DataGridAsistencia.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("Deseas Asistencia", "Eliminar Asistencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            cE_MASISTENCIAS.Id_asistencia = Convert.ToInt32(DataGridAsistencia.SelectedRows[0].Cells[0].Value.ToString());
                            cN_ASISTENCIAS.ELIMINARASISTENCIA(cE_MASISTENCIAS);
                            MessageBox.Show("Muy bien!! Se elimino corretamente", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                catch
                (Exception ex)
                {
                    MessageBox.Show("No se Elimino", "Eliminar Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string criterio = cboBuscar.Text; // ComboBox con opciones "Fecha" o "Empleado"
            string valor = txtBusqueda.Text.Trim();

            DataGridAsistencia.DataSource = cN_ASISTENCIAS.FiltrarAsistencias(criterio, valor);
        }
    }
}


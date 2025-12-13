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
    public partial class FRM_AUSENCIAS : Frm_Base
    {

        CN_PROCEDIMIENTOS cn_Procedimientos = new CN_PROCEDIMIENTOS();
        CN_AUSENCIAS cN_AUSENCIAS= new CN_AUSENCIAS();
        CE_MAUSENCIAS cE_MAUSENCIAS = new CE_MAUSENCIAS();
        public FRM_AUSENCIAS()
        {
            InitializeComponent();
        }

        private void FRM_AUSENCIAS_Load(object sender, EventArgs e)
        {
            LISTAR_AUSENCIAS();

            //Evita que no esta seleccionado por defecto//
            DataGridAUSENCIAS.ClearSelection();

            //PARA EL TAMAÑO DE LAS FILAS DEL DATA GRID//
            DataGridAUSENCIAS.Columns[1].Width = 130;
            DataGridAUSENCIAS.Columns[2].Width = 200;
            DataGridAUSENCIAS.Columns[3].Width = 200;
            DataGridAUSENCIAS.Columns[4].Width = 195;




            // Cabecera
            DataGridAUSENCIAS.EnableHeadersVisualStyles = false;
            DataGridAUSENCIAS.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            DataGridAUSENCIAS.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGridAUSENCIAS.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Color de fondo de la tabla
            DataGridAUSENCIAS.BackgroundColor = Color.White;

            // Filas alternadas
            DataGridAUSENCIAS.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Color selección de fila
            DataGridAUSENCIAS.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            DataGridAUSENCIAS.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fuente general
            DataGridAUSENCIAS.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Borde
            DataGridAUSENCIAS.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridAUSENCIAS.GridColor = Color.LightGray;



        }


        //metodo para alistar AUSENCIAS//
        private void LISTAR_AUSENCIAS()
        {
            DataGridAUSENCIAS.DataSource = cn_Procedimientos.ListarAusencias("SP_LISTAR_AUSENCIAS");


        }

        private void BtncerrarD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuveo_Click(object sender, EventArgs e)
        {
            FRM_NUEVO_AUSENCIAS AbrirNuevaAusencias = new FRM_NUEVO_AUSENCIAS();
            AbrirNuevaAusencias.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void DataGridAUSENCIAS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Editar()
        {
            if (DataGridAUSENCIAS.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tienes que seleccionar una Asistencia");

            }
            else
            {
                try
                {
                    FRM_EDITAR_AUSENCIAS eDITAR_Ausencias = new FRM_EDITAR_AUSENCIAS();

                    //ID AUSENCIAS
                    eDITAR_Ausencias.txtid_Ausencia.Text =
                    DataGridAUSENCIAS.CurrentRow.Cells[0].Value.ToString();
                        

                    //ID EMPLEADO
                    eDITAR_Ausencias.txt_IdEmP.Text =
                    DataGridAUSENCIAS.CurrentRow.Cells[0].Value.ToString();

                    //NOMBRE USENCIAS
                    eDITAR_Ausencias.txtNombre_AUSENCIAS.Text =
                    DataGridAUSENCIAS.CurrentRow.Cells[1].Value.ToString();

                    //FECHA INICIO
                    eDITAR_Ausencias.dtp_FechaInic.Value =
                    Convert.ToDateTime(DataGridAUSENCIAS.CurrentRow.Cells[2].Value);

                    //FECHA FINAL
                    eDITAR_Ausencias.dtp_FechaFinal.Value =
                    Convert.ToDateTime(DataGridAUSENCIAS.CurrentRow.Cells[3].Value);

                    //MOTIVO DE AUSENCIAS
                    eDITAR_Ausencias.txt_motivoAusencias.Text =
                    DataGridAUSENCIAS.CurrentRow.Cells[4].Value.ToString();


                    eDITAR_Ausencias.ShowDialog();
                    LISTAR_AUSENCIAS(); // ✅ RECARGA AUTOMÁTICA

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarAusencia();
        }
        private void EliminarAusencia()

        {
            if (DataGridAUSENCIAS.Rows.Count == 0)
            {
                MessageBox.Show("Mira bien , tienes que seleccionar un Cliente", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    if (DataGridAUSENCIAS.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("Deseas Eliminar", "Eliminar Ausencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            cE_MAUSENCIAS.Id_ausencia = Convert.ToInt32(DataGridAUSENCIAS.SelectedRows[0].Cells[0].Value.ToString());
                            cN_AUSENCIAS.ELIMINARAUSENSIA(cE_MAUSENCIAS);
                            MessageBox.Show("Muy bien!! Se elimino corretamente", "Eliminar Ausencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                catch
                (Exception ex)
                {
                    MessageBox.Show("No se pudo Eliminar", "Eliminar Ausencia", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string criterio = cboBuscar.Text; // ComboBox con opciones "Tipo" o "Motivo"
            string valor = txtBusqueda.Text.Trim();

            DataGridAUSENCIAS.DataSource = cN_AUSENCIAS.FiltrarAusencias(criterio, valor);
        }
    }
}


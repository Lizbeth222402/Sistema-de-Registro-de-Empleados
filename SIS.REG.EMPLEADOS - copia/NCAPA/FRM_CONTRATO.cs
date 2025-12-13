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
    public partial class FRM_CONTRATO : Frm_Base
    {
        CN_PROCEDIMIENTOS cn_Procedimientos = new CN_PROCEDIMIENTOS();
        CN_CONTRATOS cN_CONTRATOS = new CN_CONTRATOS();
        CE_MCONTRATOS cE_MCONTRATOS = new CE_MCONTRATOS();


        public FRM_CONTRATO()
        {
            InitializeComponent();
        }

        private void FRM_CONTRATO_Load(object sender, EventArgs e)
        {
            LISTAR_CONTRATOS();
            //Evita que no esta seleccionado por defecto//
            DataGriContratos.ClearSelection();
            
            //PARA EL TAMAÑO DE LAS FILAS DEL DATA GRID//
            DataGriContratos.Columns[1].Width = 145;
            DataGriContratos.Columns[2].Width = 170;
            DataGriContratos.Columns[3].Width = 170;
            DataGriContratos.Columns[4].Width = 170;


            // Cabecera
            DataGriContratos.EnableHeadersVisualStyles = false;
            DataGriContratos.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            DataGriContratos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            DataGriContratos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Color de fondo de la tabla
            DataGriContratos.BackgroundColor = Color.White;

            // Filas alternadas
            DataGriContratos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // Color selección de fila
            DataGriContratos.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            DataGriContratos.DefaultCellStyle.SelectionForeColor = Color.White;

            // Fuente general
            DataGriContratos.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Borde
            DataGriContratos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGriContratos.GridColor = Color.LightGray;

        }


        //metodo para alistar//
        private void LISTAR_CONTRATOS()
        {
            DataGriContratos.DataSource = cn_Procedimientos.ListarContratos("Sp_ListarContratos");


        }

        private void BtncerrarD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuveo_Click(object sender, EventArgs e)
        {
            FRM_NUEVO_CONTRATO AbrirNuevoContrato = new FRM_NUEVO_CONTRATO();
            AbrirNuevoContrato.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }


        private void Editar()
        {

            // Validación completa: sin filas o sin selección
            if (DataGriContratos.Rows.Count == 0 || DataGriContratos.SelectedRows.Count == 0)
            {
                MessageBox.Show("No hay contratos seleccionados o visibles.", "Editar Contrato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                FRM_EDITAR_CONTRATO editar = new FRM_EDITAR_CONTRATO();

                editar.txtid_CONTRATO.Text = DataGriContratos.SelectedRows[0].Cells[0].Value?.ToString();
                editar.txt_IdeMPLEADO.Text = DataGriContratos.SelectedRows[0].Cells[1].Value?.ToString();
                editar.txtNombreCon.Text = DataGriContratos.SelectedRows[0].Cells[2].Value?.ToString();
                editar.dtp_fechaInicio.Value = Convert.ToDateTime(DataGriContratos.SelectedRows[0].Cells[3].Value);
                editar.dtp_FechaFin.Value = Convert.ToDateTime(DataGriContratos.SelectedRows[0].Cells[4].Value);
                editar.txt_sALARIO.Text = DataGriContratos.SelectedRows[0].Cells[5].Value?.ToString();

                editar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar: {ex.Message}", "Editar Contrato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void DataGriContratos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarCONTRATO();
        }

        private void EliminarCONTRATO()

        {
            if (DataGriContratos.Rows.Count == 0)
            {
                MessageBox.Show("Tienes que seleccionar un Contrato", "Eliminar Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    if (DataGriContratos.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        DialogResult resultado = MessageBox.Show("Deseas Eliminar", "Eliminar Contrato", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            cE_MCONTRATOS.Id_contrato = Convert.ToInt32(DataGriContratos.SelectedRows[0].Cells[0].Value.ToString());
                            cN_CONTRATOS.ELIMINARCONTRATO(cE_MCONTRATOS);
                            
                            MessageBox.Show("Muy bien!! Se elimino corretamente", "Eliminar Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                catch
                (Exception ex)
                {
                    MessageBox.Show("No se pudo Eliminar", "Eliminar contrato", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text.Trim();
            string criterio = cboBuscar.Text;

            if (string.IsNullOrEmpty(filtro))
            {
                DataTable dt = cN_CONTRATOS.ListarContrato();
                if (dt.Rows.Count > 0)
                {
                    DataGriContratos.DataSource = dt;
                }
                else
                {
                    DataGriContratos.DataSource = null;
                }
                return;
            }

            if (criterio == "Tipo")
            {
                DataTable dt = cN_CONTRATOS.FiltrarPorTipo(filtro);
                if (dt.Rows.Count > 0)
                {
                    DataGriContratos.DataSource = dt;
                }
                else
                {
                    DataGriContratos.DataSource = null;
                }
            }
        }
    }
}

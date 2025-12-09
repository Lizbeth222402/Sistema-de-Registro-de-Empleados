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

            if (DataGriContratos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Tienes que seleccionar una Contrato");

            }
            else
            {
                try
                {
                    FRM_EDITAR_CONTRATO eDITAR_CONTRATO = new FRM_EDITAR_CONTRATO();

                    eDITAR_CONTRATO.txtid.Text = DataGriContratos.SelectedRows[0].          Cells[0].Value.ToString();
                    eDITAR_CONTRATO.txt_IdeMPLEADO.Text = DataGriContratos.SelectedRows[0]. Cells[1].Value.ToString();
                    eDITAR_CONTRATO.txtNombreCon.Text = DataGriContratos.SelectedRows[0].   Cells[2].Value.ToString();
                    eDITAR_CONTRATO.dtp_fechaInicio.Text = DataGriContratos.SelectedRows[0].Cells[3].Value.ToString();
                    eDITAR_CONTRATO.dtp_FechaFin.Text = DataGriContratos.SelectedRows[0].   Cells[4].Value.ToString();
                    eDITAR_CONTRATO.txt_sALARIO.Text = DataGriContratos.SelectedRows[0].    Cells[5].Value.ToString();

                    eDITAR_CONTRATO.ShowDialog();

                    //eDITAR_CONTRATO.ShowDialog();
                    //LISTAR_CONTRATOS(); // ✅ RECARGA AUTOMÁTICA
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se selecciono por el error : {ex.Message}", "Editar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

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
    }
}

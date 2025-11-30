namespace NCAPA
{
    partial class Frm_EMPLEADOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EMPLEADOS));
            this.button1 = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuevoEmpleado = new System.Windows.Forms.Button();
            this.DataGriEmpleados = new System.Windows.Forms.DataGridView();
            this.textboxEMPLEADOS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(1477, 719);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1064, 546);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "CERRAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.White;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBusqueda.Location = new System.Drawing.Point(822, 87);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBusqueda.Multiline = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(355, 29);
            this.txtBusqueda.TabIndex = 20;
            // 
            // cboBuscar
            // 
            this.cboBuscar.BackColor = System.Drawing.Color.White;
            this.cboBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "Nombre",
            "Departamento"});
            this.cboBuscar.Location = new System.Drawing.Point(603, 87);
            this.cboBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(200, 39);
            this.cboBuscar.TabIndex = 19;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(194, 552);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 40);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.LightBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(357, 552);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(134, 40);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoEmpleado.BackColor = System.Drawing.Color.LightBlue;
            this.btnNuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoEmpleado.Image")));
            this.btnNuevoEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(39, 552);
            this.btnNuevoEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(124, 40);
            this.btnNuevoEmpleado.TabIndex = 16;
            this.btnNuevoEmpleado.Text = "Nuevo";
            this.btnNuevoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoEmpleado.UseVisualStyleBackColor = false;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // DataGriEmpleados
            // 
            this.DataGriEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGriEmpleados.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.DataGriEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriEmpleados.Location = new System.Drawing.Point(39, 153);
            this.DataGriEmpleados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGriEmpleados.Name = "DataGriEmpleados";
            this.DataGriEmpleados.ReadOnly = true;
            this.DataGriEmpleados.RowHeadersVisible = false;
            this.DataGriEmpleados.RowHeadersWidth = 62;
            this.DataGriEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGriEmpleados.Size = new System.Drawing.Size(1138, 361);
            this.DataGriEmpleados.TabIndex = 15;
            this.DataGriEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGriEmpleados_CellContentClick);
            // 
            // textboxEMPLEADOS
            // 
            this.textboxEMPLEADOS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textboxEMPLEADOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxEMPLEADOS.ForeColor = System.Drawing.SystemColors.Window;
            this.textboxEMPLEADOS.Location = new System.Drawing.Point(39, 86);
            this.textboxEMPLEADOS.Name = "textboxEMPLEADOS";
            this.textboxEMPLEADOS.Size = new System.Drawing.Size(368, 39);
            this.textboxEMPLEADOS.TabIndex = 34;
            this.textboxEMPLEADOS.Text = "GESTION DE EMPLEADOS";
            // 
            // Frm_EMPLEADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 674);
            this.Controls.Add(this.textboxEMPLEADOS);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevoEmpleado);
            this.Controls.Add(this.DataGriEmpleados);
            this.Controls.Add(this.button1);
            this.Name = "Frm_EMPLEADOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_EMPLEADOS";
            this.Load += new System.EventHandler(this.Frm_EMPLEADOS_Load);
            this.Controls.SetChildIndex(this.btncerrar, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.DataGriEmpleados, 0);
            this.Controls.SetChildIndex(this.btnNuevoEmpleado, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.cboBuscar, 0);
            this.Controls.SetChildIndex(this.txtBusqueda, 0);
            this.Controls.SetChildIndex(this.textboxEMPLEADOS, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataGriEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBuscar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnNuevoEmpleado;
        private System.Windows.Forms.DataGridView DataGriEmpleados;
        private System.Windows.Forms.TextBox textboxEMPLEADOS;
    }
}
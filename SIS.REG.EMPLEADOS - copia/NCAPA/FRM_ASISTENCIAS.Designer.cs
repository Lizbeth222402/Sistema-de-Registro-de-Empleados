namespace NCAPA
{
    partial class FRM_ASISTENCIAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ASISTENCIAS));
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar_Asistencia = new System.Windows.Forms.Button();
            this.btnNuveo = new System.Windows.Forms.Button();
            this.DataGridAsistencia = new System.Windows.Forms.DataGridView();
            this.BtncerrarD = new System.Windows.Forms.Button();
            this.textboxASISTENCIA = new System.Windows.Forms.TextBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(1439, 697);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(195, 512);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 40);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar_Asistencia
            // 
            this.btnEliminar_Asistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar_Asistencia.BackColor = System.Drawing.Color.LightBlue;
            this.btnEliminar_Asistencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar_Asistencia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar_Asistencia.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar_Asistencia.Image")));
            this.btnEliminar_Asistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar_Asistencia.Location = new System.Drawing.Point(361, 512);
            this.btnEliminar_Asistencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar_Asistencia.Name = "btnEliminar_Asistencia";
            this.btnEliminar_Asistencia.Size = new System.Drawing.Size(134, 40);
            this.btnEliminar_Asistencia.TabIndex = 27;
            this.btnEliminar_Asistencia.Text = "Eliminar";
            this.btnEliminar_Asistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar_Asistencia.UseVisualStyleBackColor = false;
            this.btnEliminar_Asistencia.Click += new System.EventHandler(this.btnEliminar_Asistencia_Click);
            // 
            // btnNuveo
            // 
            this.btnNuveo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuveo.BackColor = System.Drawing.Color.LightBlue;
            this.btnNuveo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuveo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuveo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuveo.Image")));
            this.btnNuveo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuveo.Location = new System.Drawing.Point(36, 512);
            this.btnNuveo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuveo.Name = "btnNuveo";
            this.btnNuveo.Size = new System.Drawing.Size(124, 40);
            this.btnNuveo.TabIndex = 26;
            this.btnNuveo.Text = "Nuevo";
            this.btnNuveo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuveo.UseVisualStyleBackColor = false;
            this.btnNuveo.Click += new System.EventHandler(this.btnNuveo_Click);
            // 
            // DataGridAsistencia
            // 
            this.DataGridAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridAsistencia.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAsistencia.Location = new System.Drawing.Point(36, 122);
            this.DataGridAsistencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridAsistencia.Name = "DataGridAsistencia";
            this.DataGridAsistencia.ReadOnly = true;
            this.DataGridAsistencia.RowHeadersVisible = false;
            this.DataGridAsistencia.RowHeadersWidth = 62;
            this.DataGridAsistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridAsistencia.Size = new System.Drawing.Size(1108, 361);
            this.DataGridAsistencia.TabIndex = 25;
            // 
            // BtncerrarD
            // 
            this.BtncerrarD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtncerrarD.BackColor = System.Drawing.Color.LightBlue;
            this.BtncerrarD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtncerrarD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtncerrarD.Image = ((System.Drawing.Image)(resources.GetObject("BtncerrarD.Image")));
            this.BtncerrarD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtncerrarD.Location = new System.Drawing.Point(1003, 506);
            this.BtncerrarD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtncerrarD.Name = "BtncerrarD";
            this.BtncerrarD.Size = new System.Drawing.Size(141, 51);
            this.BtncerrarD.TabIndex = 24;
            this.BtncerrarD.Text = "CERRAR";
            this.BtncerrarD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtncerrarD.UseVisualStyleBackColor = false;
            this.BtncerrarD.Click += new System.EventHandler(this.BtncerrarD_Click);
            // 
            // textboxASISTENCIA
            // 
            this.textboxASISTENCIA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textboxASISTENCIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxASISTENCIA.ForeColor = System.Drawing.SystemColors.Window;
            this.textboxASISTENCIA.Location = new System.Drawing.Point(36, 59);
            this.textboxASISTENCIA.Name = "textboxASISTENCIA";
            this.textboxASISTENCIA.Size = new System.Drawing.Size(369, 39);
            this.textboxASISTENCIA.TabIndex = 30;
            this.textboxASISTENCIA.Text = "GESTION DE ASISTENCIA";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.White;
            this.txtBusqueda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBusqueda.Location = new System.Drawing.Point(789, 69);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBusqueda.Multiline = true;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(355, 29);
            this.txtBusqueda.TabIndex = 32;
            // 
            // cboBuscar
            // 
            this.cboBuscar.BackColor = System.Drawing.Color.White;
            this.cboBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "Departamento"});
            this.cboBuscar.Location = new System.Drawing.Point(570, 69);
            this.cboBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(200, 39);
            this.cboBuscar.TabIndex = 31;
            // 
            // FRM_ASISTENCIAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 652);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.textboxASISTENCIA);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar_Asistencia);
            this.Controls.Add(this.btnNuveo);
            this.Controls.Add(this.DataGridAsistencia);
            this.Controls.Add(this.BtncerrarD);
            this.Name = "FRM_ASISTENCIAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_ASISTENCIAS";
            this.Load += new System.EventHandler(this.FRM_ASISTENCIAS_Load);
            this.Controls.SetChildIndex(this.btncerrar, 0);
            this.Controls.SetChildIndex(this.BtncerrarD, 0);
            this.Controls.SetChildIndex(this.DataGridAsistencia, 0);
            this.Controls.SetChildIndex(this.btnNuveo, 0);
            this.Controls.SetChildIndex(this.btnEliminar_Asistencia, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.textboxASISTENCIA, 0);
            this.Controls.SetChildIndex(this.cboBuscar, 0);
            this.Controls.SetChildIndex(this.txtBusqueda, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAsistencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnEliminar_Asistencia;
        public System.Windows.Forms.Button btnNuveo;
        private System.Windows.Forms.DataGridView DataGridAsistencia;
        public System.Windows.Forms.Button BtncerrarD;
        private System.Windows.Forms.TextBox textboxASISTENCIA;
        public System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cboBuscar;
    }
}
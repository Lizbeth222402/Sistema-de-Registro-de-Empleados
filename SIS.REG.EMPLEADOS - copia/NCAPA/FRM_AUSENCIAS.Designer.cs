namespace NCAPA
{
    partial class FRM_AUSENCIAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_AUSENCIAS));
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnNuveo = new System.Windows.Forms.Button();
            this.DataGridAUSENCIAS = new System.Windows.Forms.DataGridView();
            this.BtncerrarD = new System.Windows.Forms.Button();
            this.textboxAUSENCIAS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAUSENCIAS)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(1430, 677);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(182, 518);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 40);
            this.btnEditar.TabIndex = 31;
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
            this.btnEliminar.Location = new System.Drawing.Point(345, 518);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(134, 40);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnNuveo
            // 
            this.btnNuveo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuveo.BackColor = System.Drawing.Color.LightBlue;
            this.btnNuveo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuveo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuveo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuveo.Image")));
            this.btnNuveo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuveo.Location = new System.Drawing.Point(32, 518);
            this.btnNuveo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuveo.Name = "btnNuveo";
            this.btnNuveo.Size = new System.Drawing.Size(124, 40);
            this.btnNuveo.TabIndex = 29;
            this.btnNuveo.Text = "Nuevo";
            this.btnNuveo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuveo.UseVisualStyleBackColor = false;
            this.btnNuveo.Click += new System.EventHandler(this.btnNuveo_Click);
            // 
            // DataGridAUSENCIAS
            // 
            this.DataGridAUSENCIAS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridAUSENCIAS.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridAUSENCIAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAUSENCIAS.Location = new System.Drawing.Point(32, 130);
            this.DataGridAUSENCIAS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridAUSENCIAS.Name = "DataGridAUSENCIAS";
            this.DataGridAUSENCIAS.ReadOnly = true;
            this.DataGridAUSENCIAS.RowHeadersVisible = false;
            this.DataGridAUSENCIAS.RowHeadersWidth = 62;
            this.DataGridAUSENCIAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridAUSENCIAS.Size = new System.Drawing.Size(1093, 357);
            this.DataGridAUSENCIAS.TabIndex = 28;
            // 
            // BtncerrarD
            // 
            this.BtncerrarD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtncerrarD.BackColor = System.Drawing.Color.LightBlue;
            this.BtncerrarD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtncerrarD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtncerrarD.Image = ((System.Drawing.Image)(resources.GetObject("BtncerrarD.Image")));
            this.BtncerrarD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtncerrarD.Location = new System.Drawing.Point(964, 518);
            this.BtncerrarD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtncerrarD.Name = "BtncerrarD";
            this.BtncerrarD.Size = new System.Drawing.Size(141, 40);
            this.BtncerrarD.TabIndex = 27;
            this.BtncerrarD.Text = "CERRAR";
            this.BtncerrarD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtncerrarD.UseVisualStyleBackColor = false;
            this.BtncerrarD.Click += new System.EventHandler(this.BtncerrarD_Click);
            // 
            // textboxAUSENCIAS
            // 
            this.textboxAUSENCIAS.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textboxAUSENCIAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxAUSENCIAS.ForeColor = System.Drawing.SystemColors.Window;
            this.textboxAUSENCIAS.Location = new System.Drawing.Point(32, 63);
            this.textboxAUSENCIAS.Name = "textboxAUSENCIAS";
            this.textboxAUSENCIAS.Size = new System.Drawing.Size(369, 39);
            this.textboxAUSENCIAS.TabIndex = 32;
            this.textboxAUSENCIAS.Text = "GESTION DE AUSENCIAS";
            // 
            // FRM_AUSENCIAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 632);
            this.Controls.Add(this.textboxAUSENCIAS);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuveo);
            this.Controls.Add(this.DataGridAUSENCIAS);
            this.Controls.Add(this.BtncerrarD);
            this.Name = "FRM_AUSENCIAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_AUSENCIAS";
            this.Load += new System.EventHandler(this.FRM_AUSENCIAS_Load);
            this.Controls.SetChildIndex(this.btncerrar, 0);
            this.Controls.SetChildIndex(this.BtncerrarD, 0);
            this.Controls.SetChildIndex(this.DataGridAUSENCIAS, 0);
            this.Controls.SetChildIndex(this.btnNuveo, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.textboxAUSENCIAS, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAUSENCIAS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnNuveo;
        private System.Windows.Forms.DataGridView DataGridAUSENCIAS;
        public System.Windows.Forms.Button BtncerrarD;
        private System.Windows.Forms.TextBox textboxAUSENCIAS;
    }
}
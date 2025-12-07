namespace NCAPA
{
    partial class FRM_EDITAR_ASISTENCIAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_EDITAR_ASISTENCIAS));
            this.txx_cerrar = new System.Windows.Forms.Button();
            this.btnActualizarAsistencia = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dtp_FechaAsis = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dtp_HoraEntra = new System.Windows.Forms.DateTimePicker();
            this.dtp_HoraSalidadAsistencia = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(951, 694);
            // 
            // txx_cerrar
            // 
            this.txx_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txx_cerrar.BackColor = System.Drawing.Color.LightBlue;
            this.txx_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txx_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txx_cerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txx_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txx_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("txx_cerrar.Image")));
            this.txx_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txx_cerrar.Location = new System.Drawing.Point(441, 505);
            this.txx_cerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txx_cerrar.Name = "txx_cerrar";
            this.txx_cerrar.Size = new System.Drawing.Size(146, 40);
            this.txx_cerrar.TabIndex = 43;
            this.txx_cerrar.Text = "CERRAR";
            this.txx_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txx_cerrar.UseVisualStyleBackColor = false;
            this.txx_cerrar.Click += new System.EventHandler(this.txx_cerrar_Click);
            // 
            // btnActualizarAsistencia
            // 
            this.btnActualizarAsistencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnActualizarAsistencia.BackColor = System.Drawing.Color.LightBlue;
            this.btnActualizarAsistencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarAsistencia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarAsistencia.Image")));
            this.btnActualizarAsistencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarAsistencia.Location = new System.Drawing.Point(86, 505);
            this.btnActualizarAsistencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizarAsistencia.Name = "btnActualizarAsistencia";
            this.btnActualizarAsistencia.Size = new System.Drawing.Size(141, 43);
            this.btnActualizarAsistencia.TabIndex = 42;
            this.btnActualizarAsistencia.Text = "Actualizar";
            this.btnActualizarAsistencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizarAsistencia.UseVisualStyleBackColor = false;
            this.btnActualizarAsistencia.Click += new System.EventHandler(this.btnActualizarAsistencia_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.Silver;
            this.txtEstado.Location = new System.Drawing.Point(281, 406);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(140, 26);
            this.txtEstado.TabIndex = 41;
            // 
            // dtp_FechaAsis
            // 
            this.dtp_FechaAsis.Location = new System.Drawing.Point(281, 182);
            this.dtp_FechaAsis.Name = "dtp_FechaAsis";
            this.dtp_FechaAsis.Size = new System.Drawing.Size(260, 26);
            this.dtp_FechaAsis.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(132, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "HORA SALIDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(132, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "ESTADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(132, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "HORA ENTRADA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(132, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "FECHA";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(281, 131);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(86, 26);
            this.txtid.TabIndex = 44;
            // 
            // dtp_HoraEntra
            // 
            this.dtp_HoraEntra.Location = new System.Drawing.Point(281, 245);
            this.dtp_HoraEntra.Name = "dtp_HoraEntra";
            this.dtp_HoraEntra.Size = new System.Drawing.Size(259, 26);
            this.dtp_HoraEntra.TabIndex = 45;
            // 
            // dtp_HoraSalidadAsistencia
            // 
            this.dtp_HoraSalidadAsistencia.Location = new System.Drawing.Point(282, 326);
            this.dtp_HoraSalidadAsistencia.Name = "dtp_HoraSalidadAsistencia";
            this.dtp_HoraSalidadAsistencia.Size = new System.Drawing.Size(259, 26);
            this.dtp_HoraSalidadAsistencia.TabIndex = 46;
            // 
            // FRM_EDITAR_ASISTENCIAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(692, 649);
            this.Controls.Add(this.dtp_HoraSalidadAsistencia);
            this.Controls.Add(this.dtp_HoraEntra);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txx_cerrar);
            this.Controls.Add(this.btnActualizarAsistencia);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.dtp_FechaAsis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_EDITAR_ASISTENCIAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_EDITAR_ASISTENCIAS";
            this.Load += new System.EventHandler(this.FRM_EDITAR_ASISTENCIAS_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dtp_FechaAsis, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.btnActualizarAsistencia, 0);
            this.Controls.SetChildIndex(this.txx_cerrar, 0);
            this.Controls.SetChildIndex(this.txtid, 0);
            this.Controls.SetChildIndex(this.btncerrar, 0);
            this.Controls.SetChildIndex(this.dtp_HoraEntra, 0);
            this.Controls.SetChildIndex(this.dtp_HoraSalidadAsistencia, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button txx_cerrar;
        public System.Windows.Forms.Button btnActualizarAsistencia;
        public System.Windows.Forms.TextBox txtEstado;
        public System.Windows.Forms.DateTimePicker dtp_FechaAsis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.DateTimePicker dtp_HoraEntra;
        public System.Windows.Forms.DateTimePicker dtp_HoraSalidadAsistencia;
    }
}
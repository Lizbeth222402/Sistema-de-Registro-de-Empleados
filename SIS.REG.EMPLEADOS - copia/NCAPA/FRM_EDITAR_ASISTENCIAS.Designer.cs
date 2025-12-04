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
            this.btnGuardarAsis = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dtp_HoraSalida = new System.Windows.Forms.DateTimePicker();
            this.dtp_HoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaAsis = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
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
            // btnGuardarAsis
            // 
            this.btnGuardarAsis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarAsis.BackColor = System.Drawing.Color.LightBlue;
            this.btnGuardarAsis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarAsis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarAsis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAsis.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarAsis.Image")));
            this.btnGuardarAsis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarAsis.Location = new System.Drawing.Point(86, 505);
            this.btnGuardarAsis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarAsis.Name = "btnGuardarAsis";
            this.btnGuardarAsis.Size = new System.Drawing.Size(141, 43);
            this.btnGuardarAsis.TabIndex = 42;
            this.btnGuardarAsis.Text = "GUARDAR";
            this.btnGuardarAsis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarAsis.UseVisualStyleBackColor = false;
            // 
            // txtEstado
            // 
            this.txtEstado.BackColor = System.Drawing.Color.Silver;
            this.txtEstado.Location = new System.Drawing.Point(281, 406);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(140, 26);
            this.txtEstado.TabIndex = 41;
            // 
            // dtp_HoraSalida
            // 
            this.dtp_HoraSalida.Location = new System.Drawing.Point(281, 322);
            this.dtp_HoraSalida.Name = "dtp_HoraSalida";
            this.dtp_HoraSalida.Size = new System.Drawing.Size(260, 26);
            this.dtp_HoraSalida.TabIndex = 40;
            // 
            // dtp_HoraEntrada
            // 
            this.dtp_HoraEntrada.Location = new System.Drawing.Point(281, 248);
            this.dtp_HoraEntrada.Name = "dtp_HoraEntrada";
            this.dtp_HoraEntrada.Size = new System.Drawing.Size(260, 26);
            this.dtp_HoraEntrada.TabIndex = 39;
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
            this.txtid.Visible = false;
            // 
            // FRM_EDITAR_ASISTENCIAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(692, 649);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txx_cerrar);
            this.Controls.Add(this.btnGuardarAsis);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.dtp_HoraSalida);
            this.Controls.Add(this.dtp_HoraEntrada);
            this.Controls.Add(this.dtp_FechaAsis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRM_EDITAR_ASISTENCIAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_EDITAR_ASISTENCIAS";
            this.Load += new System.EventHandler(this.FRM_EDITAR_ASISTENCIAS_Load);
            this.Controls.SetChildIndex(this.btncerrar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.dtp_FechaAsis, 0);
            this.Controls.SetChildIndex(this.dtp_HoraEntrada, 0);
            this.Controls.SetChildIndex(this.dtp_HoraSalida, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.btnGuardarAsis, 0);
            this.Controls.SetChildIndex(this.txx_cerrar, 0);
            this.Controls.SetChildIndex(this.txtid, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button txx_cerrar;
        public System.Windows.Forms.Button btnGuardarAsis;
        public System.Windows.Forms.TextBox txtEstado;
        public System.Windows.Forms.DateTimePicker dtp_HoraSalida;
        public System.Windows.Forms.DateTimePicker dtp_HoraEntrada;
        public System.Windows.Forms.DateTimePicker dtp_FechaAsis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtid;
    }
}
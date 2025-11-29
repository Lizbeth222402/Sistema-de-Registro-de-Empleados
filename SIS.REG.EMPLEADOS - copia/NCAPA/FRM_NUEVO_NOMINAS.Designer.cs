namespace NCAPA
{
    partial class FRM_NUEVO_NOMINAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_NUEVO_NOMINAS));
            this.dtp_FechaPago = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Salario_Bru = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Deducc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Salari_Neto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNewNominas = new System.Windows.Forms.Button();
            this.txt_IdemplNominas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_FechaPago
            // 
            this.dtp_FechaPago.Location = new System.Drawing.Point(272, 124);
            this.dtp_FechaPago.Name = "dtp_FechaPago";
            this.dtp_FechaPago.Size = new System.Drawing.Size(277, 26);
            this.dtp_FechaPago.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(70, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "FECHA PAGO";
            // 
            // txt_Salario_Bru
            // 
            this.txt_Salario_Bru.BackColor = System.Drawing.Color.Silver;
            this.txt_Salario_Bru.Location = new System.Drawing.Point(272, 208);
            this.txt_Salario_Bru.Name = "txt_Salario_Bru";
            this.txt_Salario_Bru.Size = new System.Drawing.Size(277, 26);
            this.txt_Salario_Bru.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(69, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "SALARIO BRUTO";
            // 
            // txt_Deducc
            // 
            this.txt_Deducc.BackColor = System.Drawing.Color.Silver;
            this.txt_Deducc.Location = new System.Drawing.Point(272, 274);
            this.txt_Deducc.Name = "txt_Deducc";
            this.txt_Deducc.Size = new System.Drawing.Size(277, 26);
            this.txt_Deducc.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(69, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "DEDUCCIONES";
            // 
            // txt_Salari_Neto
            // 
            this.txt_Salari_Neto.BackColor = System.Drawing.Color.Silver;
            this.txt_Salari_Neto.Location = new System.Drawing.Point(272, 364);
            this.txt_Salari_Neto.Name = "txt_Salari_Neto";
            this.txt_Salari_Neto.Size = new System.Drawing.Size(277, 26);
            this.txt_Salari_Neto.TabIndex = 46;
            this.txt_Salari_Neto.TextChanged += new System.EventHandler(this.txt_Salari_Neto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(70, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "SALARIO NETO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(382, 446);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 43);
            this.button1.TabIndex = 48;
            this.button1.Text = "CERRAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNewNominas
            // 
            this.btnNewNominas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewNominas.BackColor = System.Drawing.Color.LightBlue;
            this.btnNewNominas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewNominas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewNominas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewNominas.Image = ((System.Drawing.Image)(resources.GetObject("btnNewNominas.Image")));
            this.btnNewNominas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewNominas.Location = new System.Drawing.Point(129, 446);
            this.btnNewNominas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNewNominas.Name = "btnNewNominas";
            this.btnNewNominas.Size = new System.Drawing.Size(141, 43);
            this.btnNewNominas.TabIndex = 47;
            this.btnNewNominas.Text = "GUARDAR";
            this.btnNewNominas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewNominas.UseVisualStyleBackColor = false;
            this.btnNewNominas.Click += new System.EventHandler(this.btnNewNominas_Click);
            // 
            // txt_IdemplNominas
            // 
            this.txt_IdemplNominas.BackColor = System.Drawing.Color.Silver;
            this.txt_IdemplNominas.Location = new System.Drawing.Point(272, 59);
            this.txt_IdemplNominas.Name = "txt_IdemplNominas";
            this.txt_IdemplNominas.Size = new System.Drawing.Size(277, 26);
            this.txt_IdemplNominas.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(69, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 49;
            this.label5.Text = "Id Empleado";
            // 
            // FRM_NUEVO_NOMINAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(612, 524);
            this.Controls.Add(this.txt_IdemplNominas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewNominas);
            this.Controls.Add(this.txt_Salari_Neto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Deducc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Salario_Bru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_FechaPago);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_NUEVO_NOMINAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_NUEVO_NOMINAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_FechaPago;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_Salario_Bru;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Deducc;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_Salari_Neto;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnNewNominas;
        public System.Windows.Forms.TextBox txt_IdemplNominas;
        private System.Windows.Forms.Label label5;
    }
}
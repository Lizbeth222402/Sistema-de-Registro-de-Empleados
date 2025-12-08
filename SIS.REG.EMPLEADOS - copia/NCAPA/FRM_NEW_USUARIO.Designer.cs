namespace NCAPA
{
    partial class FRM_NEW_USUARIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_NEW_USUARIO));
            this.txt_Nameusuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpasswork = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txx_cerrarUsuario = new System.Windows.Forms.Button();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.chk_ACTIVO = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_Nameusuario
            // 
            this.txt_Nameusuario.Location = new System.Drawing.Point(225, 56);
            this.txt_Nameusuario.Name = "txt_Nameusuario";
            this.txt_Nameusuario.Size = new System.Drawing.Size(301, 26);
            this.txt_Nameusuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // txtpasswork
            // 
            this.txtpasswork.Location = new System.Drawing.Point(225, 160);
            this.txtpasswork.Name = "txtpasswork";
            this.txtpasswork.Size = new System.Drawing.Size(301, 26);
            this.txtpasswork.TabIndex = 2;
            this.txtpasswork.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Activo";
            // 
            // txx_cerrarUsuario
            // 
            this.txx_cerrarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txx_cerrarUsuario.BackColor = System.Drawing.Color.LightBlue;
            this.txx_cerrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txx_cerrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txx_cerrarUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txx_cerrarUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txx_cerrarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("txx_cerrarUsuario.Image")));
            this.txx_cerrarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txx_cerrarUsuario.Location = new System.Drawing.Point(380, 310);
            this.txx_cerrarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txx_cerrarUsuario.Name = "txx_cerrarUsuario";
            this.txx_cerrarUsuario.Size = new System.Drawing.Size(146, 40);
            this.txx_cerrarUsuario.TabIndex = 35;
            this.txx_cerrarUsuario.Text = "CERRAR";
            this.txx_cerrarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txx_cerrarUsuario.UseVisualStyleBackColor = false;
            this.txx_cerrarUsuario.Click += new System.EventHandler(this.txx_cerrarUsuario_Click);
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarUsuario.BackColor = System.Drawing.Color.LightBlue;
            this.btnGuardarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarUsuario.Image")));
            this.btnGuardarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(106, 307);
            this.btnGuardarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(141, 43);
            this.btnGuardarUsuario.TabIndex = 34;
            this.btnGuardarUsuario.Text = "GUARDAR";
            this.btnGuardarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarUsuario.UseVisualStyleBackColor = false;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // chk_ACTIVO
            // 
            this.chk_ACTIVO.AutoSize = true;
            this.chk_ACTIVO.Location = new System.Drawing.Point(225, 239);
            this.chk_ACTIVO.Name = "chk_ACTIVO";
            this.chk_ACTIVO.Size = new System.Drawing.Size(22, 21);
            this.chk_ACTIVO.TabIndex = 52;
            this.chk_ACTIVO.UseVisualStyleBackColor = true;
            // 
            // FRM_NEW_USUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(612, 386);
            this.Controls.Add(this.chk_ACTIVO);
            this.Controls.Add(this.txx_cerrarUsuario);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpasswork);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nameusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_NEW_USUARIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_NEW_USUARIO";
            this.Load += new System.EventHandler(this.FRM_NEW_USUARIO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtpasswork;
        public System.Windows.Forms.TextBox txt_Nameusuario;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button txx_cerrarUsuario;
        public System.Windows.Forms.Button btnGuardarUsuario;
        public System.Windows.Forms.CheckBox chk_ACTIVO;
    }
}
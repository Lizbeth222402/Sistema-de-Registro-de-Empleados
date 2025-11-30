namespace NCAPA
{
    partial class FRM_EDITAR_USUARIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_EDITAR_USUARIO));
            this.txx_cerrarUsuario = new System.Windows.Forms.Button();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Activo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpasswork = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nameusuario = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.txx_cerrarUsuario.Location = new System.Drawing.Point(617, 223);
            this.txx_cerrarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txx_cerrarUsuario.Name = "txx_cerrarUsuario";
            this.txx_cerrarUsuario.Size = new System.Drawing.Size(146, 40);
            this.txx_cerrarUsuario.TabIndex = 43;
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
            this.btnGuardarUsuario.Location = new System.Drawing.Point(622, 335);
            this.btnGuardarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(141, 43);
            this.btnGuardarUsuario.TabIndex = 42;
            this.btnGuardarUsuario.Text = "GUARDAR";
            this.btnGuardarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarUsuario.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(111, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Activo";
            // 
            // txt_Activo
            // 
            this.txt_Activo.Location = new System.Drawing.Point(228, 258);
            this.txt_Activo.Name = "txt_Activo";
            this.txt_Activo.Size = new System.Drawing.Size(50, 26);
            this.txt_Activo.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(83, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Contraseña";
            // 
            // txtpasswork
            // 
            this.txtpasswork.Location = new System.Drawing.Point(228, 182);
            this.txtpasswork.Name = "txtpasswork";
            this.txtpasswork.Size = new System.Drawing.Size(301, 26);
            this.txtpasswork.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(51, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre Usuario";
            // 
            // txt_Nameusuario
            // 
            this.txt_Nameusuario.Location = new System.Drawing.Point(228, 101);
            this.txt_Nameusuario.Name = "txt_Nameusuario";
            this.txt_Nameusuario.Size = new System.Drawing.Size(301, 26);
            this.txt_Nameusuario.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(-2, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(804, 39);
            this.textBox1.TabIndex = 44;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SlateBlue;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox2.Location = new System.Drawing.Point(-2, 435);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(804, 39);
            this.textBox2.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(131, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Id";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(228, 320);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(86, 26);
            this.txtid.TabIndex = 46;
            // 
            // FRM_EDITAR_USUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txx_cerrarUsuario);
            this.Controls.Add(this.btnGuardarUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Activo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpasswork);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nameusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_EDITAR_USUARIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_EDITAR_USUARIO";
            this.Load += new System.EventHandler(this.FRM_EDITAR_USUARIO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button txx_cerrarUsuario;
        public System.Windows.Forms.Button btnGuardarUsuario;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_Activo;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtpasswork;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_Nameusuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtid;
    }
}
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnNuevoEmpleado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre_usuario = new System.Windows.Forms.TextBox();
            this.txtpassUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuarioActivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(231, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 28);
            this.button1.TabIndex = 43;
            this.button1.Text = "CERRAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNuevoEmpleado
            // 
            this.btnNuevoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevoEmpleado.BackColor = System.Drawing.Color.LightBlue;
            this.btnNuevoEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoEmpleado.Image")));
            this.btnNuevoEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoEmpleado.Location = new System.Drawing.Point(61, 242);
            this.btnNuevoEmpleado.Name = "btnNuevoEmpleado";
            this.btnNuevoEmpleado.Size = new System.Drawing.Size(94, 28);
            this.btnNuevoEmpleado.TabIndex = 42;
            this.btnNuevoEmpleado.Text = "GUARDAR";
            this.btnNuevoEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoEmpleado.UseVisualStyleBackColor = false;
            this.btnNuevoEmpleado.Click += new System.EventHandler(this.btnNuevoEmpleado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(37, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "NOMBRE USUARIO";
            // 
            // txtNombre_usuario
            // 
            this.txtNombre_usuario.BackColor = System.Drawing.Color.Silver;
            this.txtNombre_usuario.Location = new System.Drawing.Point(191, 53);
            this.txtNombre_usuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre_usuario.Name = "txtNombre_usuario";
            this.txtNombre_usuario.Size = new System.Drawing.Size(186, 20);
            this.txtNombre_usuario.TabIndex = 45;
            // 
            // txtpassUsuario
            // 
            this.txtpassUsuario.BackColor = System.Drawing.Color.Silver;
            this.txtpassUsuario.Location = new System.Drawing.Point(149, 111);
            this.txtpassUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpassUsuario.Name = "txtpassUsuario";
            this.txtpassUsuario.Size = new System.Drawing.Size(186, 20);
            this.txtpassUsuario.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(37, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "CONTRASEÑA";
            // 
            // txtUsuarioActivo
            // 
            this.txtUsuarioActivo.BackColor = System.Drawing.Color.Silver;
            this.txtUsuarioActivo.Location = new System.Drawing.Point(110, 165);
            this.txtUsuarioActivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuarioActivo.Name = "txtUsuarioActivo";
            this.txtUsuarioActivo.Size = new System.Drawing.Size(97, 20);
            this.txtUsuarioActivo.TabIndex = 49;
            this.txtUsuarioActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuarioActivo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(37, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "ACTIVO";
            // 
            // FRM_NEW_USUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(425, 292);
            this.Controls.Add(this.txtUsuarioActivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpassUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre_usuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevoEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FRM_NEW_USUARIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_NEW_USUARIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnNuevoEmpleado;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNombre_usuario;
        public System.Windows.Forms.TextBox txtpassUsuario;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtUsuarioActivo;
        private System.Windows.Forms.Label label3;
    }
}
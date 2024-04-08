namespace CapaPrecentacion
{
    partial class Login
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
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlArriba = new System.Windows.Forms.Panel();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.pnlDerecha = new System.Windows.Forms.Panel();
            this.pnlIzquierda = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.pnlContraseña = new System.Windows.Forms.Panel();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblMensajeError = new System.Windows.Forms.Label();
            this.pbxPass = new System.Windows.Forms.PictureBox();
            this.pbxUser = new System.Windows.Forms.PictureBox();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlArriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.Crimson;
            this.pnlFondo.Controls.Add(this.lblNombre);
            this.pnlFondo.Controls.Add(this.pictureBox1);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(197, 297);
            this.pnlFondo.TabIndex = 0;
            this.pnlFondo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFondo_MouseDown);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(7, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(184, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Pasteleria Emiliana";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPrecentacion.Properties.Resources._100x100;
            this.pictureBox1.Location = new System.Drawing.Point(12, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlArriba
            // 
            this.pnlArriba.BackColor = System.Drawing.Color.Black;
            this.pnlArriba.Controls.Add(this.pbxMinimizar);
            this.pnlArriba.Controls.Add(this.pbxCerrar);
            this.pnlArriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlArriba.Location = new System.Drawing.Point(197, 0);
            this.pnlArriba.Name = "pnlArriba";
            this.pnlArriba.Size = new System.Drawing.Size(287, 28);
            this.pnlArriba.TabIndex = 1;
            this.pnlArriba.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlArriba_MouseDown);
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.Image = global::CapaPrecentacion.Properties.Resources.Minimize_Icon;
            this.pbxMinimizar.Location = new System.Drawing.Point(238, 0);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(20, 28);
            this.pbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizar.TabIndex = 15;
            this.pbxMinimizar.TabStop = false;
            this.pbxMinimizar.Click += new System.EventHandler(this.pbxMinimizar_Click);
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Image = global::CapaPrecentacion.Properties.Resources.Close_Icon;
            this.pbxCerrar.Location = new System.Drawing.Point(264, 2);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(20, 26);
            this.pbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCerrar.TabIndex = 14;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pbxCerrar_Click);
            // 
            // pnlDerecha
            // 
            this.pnlDerecha.BackColor = System.Drawing.Color.Crimson;
            this.pnlDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDerecha.Location = new System.Drawing.Point(480, 28);
            this.pnlDerecha.Name = "pnlDerecha";
            this.pnlDerecha.Size = new System.Drawing.Size(4, 269);
            this.pnlDerecha.TabIndex = 2;
            // 
            // pnlIzquierda
            // 
            this.pnlIzquierda.BackColor = System.Drawing.Color.Black;
            this.pnlIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlIzquierda.Location = new System.Drawing.Point(197, 28);
            this.pnlIzquierda.Name = "pnlIzquierda";
            this.pnlIzquierda.Size = new System.Drawing.Size(1, 269);
            this.pnlIzquierda.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(302, 45);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(60, 26);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "LOGIN";
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtUser.Location = new System.Drawing.Point(240, 102);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(208, 14);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "USUARIO";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.Location = new System.Drawing.Point(240, 143);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(208, 14);
            this.txtPass.TabIndex = 6;
            this.txtPass.Text = "CONTRASEÑA";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.Black;
            this.pnlUsuario.Location = new System.Drawing.Point(240, 118);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(208, 1);
            this.pnlUsuario.TabIndex = 7;
            // 
            // pnlContraseña
            // 
            this.pnlContraseña.BackColor = System.Drawing.Color.Black;
            this.pnlContraseña.Location = new System.Drawing.Point(240, 159);
            this.pnlContraseña.Name = "pnlContraseña";
            this.pnlContraseña.Size = new System.Drawing.Size(208, 1);
            this.pnlContraseña.TabIndex = 8;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.Location = new System.Drawing.Point(240, 225);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(208, 27);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(240, 166);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "ver contraseña";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(279, 266);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(134, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Olvidasde tu contraseña?";
            // 
            // lblMensajeError
            // 
            this.lblMensajeError.AutoSize = true;
            this.lblMensajeError.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeError.Image = global::CapaPrecentacion.Properties.Resources.icons8_error_15;
            this.lblMensajeError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMensajeError.Location = new System.Drawing.Point(237, 196);
            this.lblMensajeError.Name = "lblMensajeError";
            this.lblMensajeError.Size = new System.Drawing.Size(29, 13);
            this.lblMensajeError.TabIndex = 14;
            this.lblMensajeError.Text = "Error";
            this.lblMensajeError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMensajeError.Visible = false;
            // 
            // pbxPass
            // 
            this.pbxPass.Image = global::CapaPrecentacion.Properties.Resources.icons8_contraseña_30;
            this.pbxPass.Location = new System.Drawing.Point(219, 145);
            this.pbxPass.Name = "pbxPass";
            this.pbxPass.Size = new System.Drawing.Size(15, 15);
            this.pbxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPass.TabIndex = 13;
            this.pbxPass.TabStop = false;
            // 
            // pbxUser
            // 
            this.pbxUser.Image = global::CapaPrecentacion.Properties.Resources.icons8_usuario_30__1_;
            this.pbxUser.Location = new System.Drawing.Point(219, 104);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(15, 15);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxUser.TabIndex = 12;
            this.pbxUser.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 297);
            this.Controls.Add(this.lblMensajeError);
            this.Controls.Add(this.pbxPass);
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.pnlContraseña);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pnlIzquierda);
            this.Controls.Add(this.pnlDerecha);
            this.Controls.Add(this.pnlArriba);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlArriba.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Panel pnlArriba;
        private System.Windows.Forms.Panel pnlDerecha;
        private System.Windows.Forms.Panel pnlIzquierda;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Panel pnlContraseña;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pbxUser;
        private System.Windows.Forms.PictureBox pbxPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.PictureBox pbxMinimizar;
        private System.Windows.Forms.Label lblMensajeError;
    }
}
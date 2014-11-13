namespace UI.Desktop
{
    partial class UsuarioDesktop
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
            this.tlpUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblConfClave = new System.Windows.Forms.Label();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTipoPersona = new System.Windows.Forms.Label();
            this.cbxTipoPersona = new System.Windows.Forms.ComboBox();
            this.tlpUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUsuario
            // 
            this.tlpUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpUsuario.ColumnCount = 4;
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.40845F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.59155F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tlpUsuario.Controls.Add(this.lblNombre, 0, 1);
            this.tlpUsuario.Controls.Add(this.lblEmail, 0, 2);
            this.tlpUsuario.Controls.Add(this.lblConfClave, 2, 3);
            this.tlpUsuario.Controls.Add(this.chkHabilitado, 2, 0);
            this.tlpUsuario.Controls.Add(this.txtID, 1, 0);
            this.tlpUsuario.Controls.Add(this.txtNombre, 1, 1);
            this.tlpUsuario.Controls.Add(this.txtEmail, 1, 2);
            this.tlpUsuario.Controls.Add(this.txtUsuario, 3, 2);
            this.tlpUsuario.Controls.Add(this.txtConfirmarClave, 3, 3);
            this.tlpUsuario.Controls.Add(this.lblUsuario, 2, 2);
            this.tlpUsuario.Controls.Add(this.lblClave, 0, 3);
            this.tlpUsuario.Controls.Add(this.lblID, 0, 0);
            this.tlpUsuario.Controls.Add(this.lblApellido, 2, 1);
            this.tlpUsuario.Controls.Add(this.btnAceptar, 2, 5);
            this.tlpUsuario.Controls.Add(this.btnCancelar, 3, 5);
            this.tlpUsuario.Controls.Add(this.lblTipoPersona, 0, 4);
            this.tlpUsuario.Controls.Add(this.cbxTipoPersona, 1, 4);
            this.tlpUsuario.Controls.Add(this.txtClave, 1, 3);
            this.tlpUsuario.Controls.Add(this.txtApellido, 3, 1);
            this.tlpUsuario.Location = new System.Drawing.Point(0, 0);
            this.tlpUsuario.Name = "tlpUsuario";
            this.tlpUsuario.RowCount = 6;
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.11765F));
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.88235F));
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlpUsuario.Size = new System.Drawing.Size(672, 329);
            this.tlpUsuario.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(3, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 125);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblConfClave
            // 
            this.lblConfClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConfClave.AutoSize = true;
            this.lblConfClave.Location = new System.Drawing.Point(331, 185);
            this.lblConfClave.Name = "lblConfClave";
            this.lblConfClave.Size = new System.Drawing.Size(81, 13);
            this.lblConfClave.TabIndex = 6;
            this.lblConfClave.Text = "Confirmar Clave";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(331, 14);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 7;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(73, 12);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(190, 20);
            this.txtID.TabIndex = 10;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNombre.Location = new System.Drawing.Point(73, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.Location = new System.Drawing.Point(73, 122);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsuario.Location = new System.Drawing.Point(430, 122);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(190, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtConfirmarClave.Location = new System.Drawing.Point(430, 181);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(190, 20);
            this.txtConfirmarClave.TabIndex = 6;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(331, 125);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtClave.Location = new System.Drawing.Point(73, 181);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(190, 20);
            this.txtClave.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtApellido.Location = new System.Drawing.Point(430, 63);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(190, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // lblClave
            // 
            this.lblClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(3, 185);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Clave";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 16);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(331, 67);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAceptar.Location = new System.Drawing.Point(331, 290);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Location = new System.Drawing.Point(430, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.Location = new System.Drawing.Point(3, 235);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(48, 26);
            this.lblTipoPersona.TabIndex = 11;
            this.lblTipoPersona.Text = "Tipo de persona:";
            // 
            // cbxTipoPersona
            // 
            this.cbxTipoPersona.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxTipoPersona.FormattingEnabled = true;
            this.cbxTipoPersona.Location = new System.Drawing.Point(73, 237);
            this.cbxTipoPersona.Name = "cbxTipoPersona";
            this.cbxTipoPersona.Size = new System.Drawing.Size(190, 21);
            this.cbxTipoPersona.TabIndex = 12;
            // 
            // UsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 329);
            this.Controls.Add(this.tlpUsuario);
            this.Name = "UsuarioDesktop";
            this.Text = "UsuarioDesktop";
            this.tlpUsuario.ResumeLayout(false);
            this.tlpUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUsuario;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConfClave;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblTipoPersona;
        private System.Windows.Forms.ComboBox cbxTipoPersona;
    }
}
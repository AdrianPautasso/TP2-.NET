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
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblPersona = new System.Windows.Forms.Label();
            this.cbxPersona = new System.Windows.Forms.ComboBox();
            this.lblConfClave = new System.Windows.Forms.Label();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpUsuario.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUsuario
            // 
            this.tlpUsuario.ColumnCount = 4;
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.40845F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.59155F));
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tlpUsuario.Controls.Add(this.chkHabilitado, 2, 0);
            this.tlpUsuario.Controls.Add(this.txtID, 1, 0);
            this.tlpUsuario.Controls.Add(this.lblID, 0, 0);
            this.tlpUsuario.Controls.Add(this.lblUsuario, 0, 1);
            this.tlpUsuario.Controls.Add(this.txtUsuario, 1, 1);
            this.tlpUsuario.Controls.Add(this.lblClave, 0, 2);
            this.tlpUsuario.Controls.Add(this.txtClave, 1, 2);
            this.tlpUsuario.Controls.Add(this.lblPersona, 2, 1);
            this.tlpUsuario.Controls.Add(this.cbxPersona, 3, 1);
            this.tlpUsuario.Controls.Add(this.lblConfClave, 2, 2);
            this.tlpUsuario.Controls.Add(this.txtConfirmarClave, 3, 2);
            this.tlpUsuario.Controls.Add(this.tableLayoutPanel1, 3, 3);
            this.tlpUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsuario.Location = new System.Drawing.Point(0, 0);
            this.tlpUsuario.Name = "tlpUsuario";
            this.tlpUsuario.RowCount = 4;
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.88235F));
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpUsuario.Size = new System.Drawing.Size(681, 162);
            this.tlpUsuario.TabIndex = 0;
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(346, 11);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 7;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(76, 9);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(190, 20);
            this.txtID.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(3, 54);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUsuario.Location = new System.Drawing.Point(76, 50);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(190, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // lblClave
            // 
            this.lblClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(3, 95);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(34, 13);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Clave";
            // 
            // txtClave
            // 
            this.txtClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtClave.Location = new System.Drawing.Point(76, 91);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(190, 20);
            this.txtClave.TabIndex = 5;
            // 
            // lblPersona
            // 
            this.lblPersona.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPersona.AutoSize = true;
            this.lblPersona.Location = new System.Drawing.Point(346, 54);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(46, 13);
            this.lblPersona.TabIndex = 11;
            this.lblPersona.Text = "Persona";
            // 
            // cbxPersona
            // 
            this.cbxPersona.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxPersona.FormattingEnabled = true;
            this.cbxPersona.Location = new System.Drawing.Point(433, 50);
            this.cbxPersona.Name = "cbxPersona";
            this.cbxPersona.Size = new System.Drawing.Size(190, 21);
            this.cbxPersona.TabIndex = 12;
            // 
            // lblConfClave
            // 
            this.lblConfClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblConfClave.AutoSize = true;
            this.lblConfClave.Location = new System.Drawing.Point(346, 95);
            this.lblConfClave.Name = "lblConfClave";
            this.lblConfClave.Size = new System.Drawing.Size(81, 13);
            this.lblConfClave.TabIndex = 6;
            this.lblConfClave.Text = "Confirmar Clave";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtConfirmarClave.Location = new System.Drawing.Point(433, 91);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(190, 20);
            this.txtConfirmarClave.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(23, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(146, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(433, 124);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 35);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // UsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 162);
            this.Controls.Add(this.tlpUsuario);
            this.Name = "UsuarioDesktop";
            this.Text = "Usuario";
            this.tlpUsuario.ResumeLayout(false);
            this.tlpUsuario.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUsuario;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConfClave;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.ComboBox cbxPersona;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
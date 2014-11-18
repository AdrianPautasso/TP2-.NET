namespace UI.Desktop
{
    partial class CursoDesktop
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
            this.tlpCursos = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblAnioAcademico = new System.Windows.Forms.Label();
            this.lblCupo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbxMateria = new System.Windows.Forms.ComboBox();
            this.cbxComision = new System.Windows.Forms.ComboBox();
            this.txtAnioAcademico = new System.Windows.Forms.TextBox();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpCursos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCursos
            // 
            this.tlpCursos.ColumnCount = 4;
            this.tlpCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCursos.Controls.Add(this.lblID, 0, 0);
            this.tlpCursos.Controls.Add(this.lblMateria, 2, 0);
            this.tlpCursos.Controls.Add(this.lblComision, 0, 1);
            this.tlpCursos.Controls.Add(this.lblAnioAcademico, 2, 1);
            this.tlpCursos.Controls.Add(this.lblCupo, 0, 2);
            this.tlpCursos.Controls.Add(this.txtID, 1, 0);
            this.tlpCursos.Controls.Add(this.cbxMateria, 3, 0);
            this.tlpCursos.Controls.Add(this.cbxComision, 1, 1);
            this.tlpCursos.Controls.Add(this.txtAnioAcademico, 3, 1);
            this.tlpCursos.Controls.Add(this.txtCupo, 1, 2);
            this.tlpCursos.Controls.Add(this.tableLayoutPanel1, 3, 3);
            this.tlpCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCursos.Location = new System.Drawing.Point(0, 0);
            this.tlpCursos.Name = "tlpCursos";
            this.tlpCursos.RowCount = 4;
            this.tlpCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCursos.Size = new System.Drawing.Size(624, 151);
            this.tlpCursos.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblMateria
            // 
            this.lblMateria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(298, 12);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Materia";
            // 
            // lblComision
            // 
            this.lblComision.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(3, 49);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(49, 13);
            this.lblComision.TabIndex = 2;
            this.lblComision.Text = "Comisión";
            // 
            // lblAnioAcademico
            // 
            this.lblAnioAcademico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAnioAcademico.AutoSize = true;
            this.lblAnioAcademico.Location = new System.Drawing.Point(298, 49);
            this.lblAnioAcademico.Name = "lblAnioAcademico";
            this.lblAnioAcademico.Size = new System.Drawing.Size(82, 13);
            this.lblAnioAcademico.TabIndex = 3;
            this.lblAnioAcademico.Text = "Año Académico";
            // 
            // lblCupo
            // 
            this.lblCupo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCupo.AutoSize = true;
            this.lblCupo.Location = new System.Drawing.Point(3, 86);
            this.lblCupo.Name = "lblCupo";
            this.lblCupo.Size = new System.Drawing.Size(32, 13);
            this.lblCupo.TabIndex = 4;
            this.lblCupo.Text = "Cupo";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(58, 8);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(161, 20);
            this.txtID.TabIndex = 5;
            // 
            // cbxMateria
            // 
            this.cbxMateria.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxMateria.FormattingEnabled = true;
            this.cbxMateria.Location = new System.Drawing.Point(386, 8);
            this.cbxMateria.Name = "cbxMateria";
            this.cbxMateria.Size = new System.Drawing.Size(161, 21);
            this.cbxMateria.TabIndex = 6;
            // 
            // cbxComision
            // 
            this.cbxComision.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxComision.FormattingEnabled = true;
            this.cbxComision.Location = new System.Drawing.Point(58, 45);
            this.cbxComision.Name = "cbxComision";
            this.cbxComision.Size = new System.Drawing.Size(161, 21);
            this.cbxComision.TabIndex = 7;
            // 
            // txtAnioAcademico
            // 
            this.txtAnioAcademico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAnioAcademico.Location = new System.Drawing.Point(386, 45);
            this.txtAnioAcademico.Name = "txtAnioAcademico";
            this.txtAnioAcademico.Size = new System.Drawing.Size(161, 20);
            this.txtAnioAcademico.TabIndex = 8;
            // 
            // txtCupo
            // 
            this.txtCupo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCupo.Location = new System.Drawing.Point(58, 82);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(161, 20);
            this.txtCupo.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(386, 114);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 34);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(21, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(138, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 151);
            this.Controls.Add(this.tlpCursos);
            this.Name = "CursoDesktop";
            this.Text = "CursoDesktop";
            this.tlpCursos.ResumeLayout(false);
            this.tlpCursos.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCursos;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblAnioAcademico;
        private System.Windows.Forms.Label lblCupo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbxMateria;
        private System.Windows.Forms.ComboBox cbxComision;
        private System.Windows.Forms.TextBox txtAnioAcademico;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
namespace UI.Desktop
{
    partial class DocenteCursoDesktop
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
            this.tldDocenteCurso = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbxDocentes = new System.Windows.Forms.ComboBox();
            this.cbxCursos = new System.Windows.Forms.ComboBox();
            this.cbxCargos = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tldDocenteCurso.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tldDocenteCurso
            // 
            this.tldDocenteCurso.ColumnCount = 4;
            this.tldDocenteCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tldDocenteCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tldDocenteCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tldDocenteCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tldDocenteCurso.Controls.Add(this.lblID, 0, 0);
            this.tldDocenteCurso.Controls.Add(this.lblDocente, 2, 0);
            this.tldDocenteCurso.Controls.Add(this.lblCurso, 0, 1);
            this.tldDocenteCurso.Controls.Add(this.lblCargo, 2, 1);
            this.tldDocenteCurso.Controls.Add(this.txtID, 1, 0);
            this.tldDocenteCurso.Controls.Add(this.cbxDocentes, 3, 0);
            this.tldDocenteCurso.Controls.Add(this.cbxCursos, 1, 1);
            this.tldDocenteCurso.Controls.Add(this.cbxCargos, 3, 1);
            this.tldDocenteCurso.Controls.Add(this.tableLayoutPanel1, 3, 2);
            this.tldDocenteCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tldDocenteCurso.Location = new System.Drawing.Point(0, 0);
            this.tldDocenteCurso.Name = "tldDocenteCurso";
            this.tldDocenteCurso.RowCount = 3;
            this.tldDocenteCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tldDocenteCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tldDocenteCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tldDocenteCurso.Size = new System.Drawing.Size(473, 124);
            this.tldDocenteCurso.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblDocente
            // 
            this.lblDocente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(232, 14);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(48, 13);
            this.lblDocente.TabIndex = 1;
            this.lblDocente.Text = "Docente";
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(3, 55);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso";
            // 
            // lblCargo
            // 
            this.lblCargo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(232, 55);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 3;
            this.lblCargo.Text = "Cargo";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(43, 10);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(162, 20);
            this.txtID.TabIndex = 4;
            // 
            // cbxDocentes
            // 
            this.cbxDocentes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxDocentes.FormattingEnabled = true;
            this.cbxDocentes.Location = new System.Drawing.Point(286, 10);
            this.cbxDocentes.Name = "cbxDocentes";
            this.cbxDocentes.Size = new System.Drawing.Size(162, 21);
            this.cbxDocentes.TabIndex = 5;
            // 
            // cbxCursos
            // 
            this.cbxCursos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxCursos.FormattingEnabled = true;
            this.cbxCursos.Location = new System.Drawing.Point(43, 51);
            this.cbxCursos.Name = "cbxCursos";
            this.cbxCursos.Size = new System.Drawing.Size(162, 21);
            this.cbxCursos.TabIndex = 6;
            // 
            // cbxCargos
            // 
            this.cbxCargos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxCargos.FormattingEnabled = true;
            this.cbxCargos.Location = new System.Drawing.Point(286, 51);
            this.cbxCargos.Name = "cbxCargos";
            this.cbxCargos.Size = new System.Drawing.Size(162, 21);
            this.cbxCargos.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(286, 85);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(184, 36);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(8, 6);
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
            this.btnCancelar.Location = new System.Drawing.Point(100, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // DocenteCursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 124);
            this.Controls.Add(this.tldDocenteCurso);
            this.Name = "DocenteCursoDesktop";
            this.Text = "DocenteCursoDesktop";
            this.tldDocenteCurso.ResumeLayout(false);
            this.tldDocenteCurso.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tldDocenteCurso;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbxDocentes;
        private System.Windows.Forms.ComboBox cbxCursos;
        private System.Windows.Forms.ComboBox cbxCargos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
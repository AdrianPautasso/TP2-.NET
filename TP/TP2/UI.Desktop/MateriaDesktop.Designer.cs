namespace UI.Desktop
{
    partial class MateriaDesktop
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
            this.tlpMateria = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblHsSemanales = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblHsTotales = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtHsSemanales = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtHsTotales = new System.Windows.Forms.TextBox();
            this.cbxPlanes = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tlpMateria.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMateria
            // 
            this.tlpMateria.ColumnCount = 4;
            this.tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.69215F));
            this.tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMateria.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.30785F));
            this.tlpMateria.Controls.Add(this.lblID, 0, 0);
            this.tlpMateria.Controls.Add(this.lblHsSemanales, 0, 1);
            this.tlpMateria.Controls.Add(this.lblPlan, 0, 2);
            this.tlpMateria.Controls.Add(this.lblHsTotales, 2, 1);
            this.tlpMateria.Controls.Add(this.lblDescripcion, 2, 0);
            this.tlpMateria.Controls.Add(this.txtID, 1, 0);
            this.tlpMateria.Controls.Add(this.txtHsSemanales, 1, 1);
            this.tlpMateria.Controls.Add(this.txtDescripcion, 3, 0);
            this.tlpMateria.Controls.Add(this.txtHsTotales, 3, 1);
            this.tlpMateria.Controls.Add(this.cbxPlanes, 1, 2);
            this.tlpMateria.Controls.Add(this.tableLayoutPanel1, 3, 3);
            this.tlpMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMateria.Location = new System.Drawing.Point(0, 0);
            this.tlpMateria.Name = "tlpMateria";
            this.tlpMateria.RowCount = 4;
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMateria.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMateria.Size = new System.Drawing.Size(672, 136);
            this.tlpMateria.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 11);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblHsSemanales
            // 
            this.lblHsSemanales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHsSemanales.AutoSize = true;
            this.lblHsSemanales.Location = new System.Drawing.Point(3, 46);
            this.lblHsSemanales.Name = "lblHsSemanales";
            this.lblHsSemanales.Size = new System.Drawing.Size(90, 13);
            this.lblHsSemanales.TabIndex = 2;
            this.lblHsSemanales.Text = "Horas Semanales";
            // 
            // lblPlan
            // 
            this.lblPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(3, 78);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(28, 13);
            this.lblPlan.TabIndex = 4;
            this.lblPlan.Text = "Plan";
            // 
            // lblHsTotales
            // 
            this.lblHsTotales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHsTotales.AutoSize = true;
            this.lblHsTotales.Location = new System.Drawing.Point(340, 46);
            this.lblHsTotales.Name = "lblHsTotales";
            this.lblHsTotales.Size = new System.Drawing.Size(73, 13);
            this.lblHsTotales.TabIndex = 3;
            this.lblHsTotales.Text = "Horas Totales";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(340, 11);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(99, 7);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(161, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtHsSemanales
            // 
            this.txtHsSemanales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHsSemanales.Location = new System.Drawing.Point(99, 42);
            this.txtHsSemanales.Name = "txtHsSemanales";
            this.txtHsSemanales.Size = new System.Drawing.Size(161, 20);
            this.txtHsSemanales.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescripcion.Location = new System.Drawing.Point(419, 7);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(162, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // txtHsTotales
            // 
            this.txtHsTotales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtHsTotales.Location = new System.Drawing.Point(419, 42);
            this.txtHsTotales.Name = "txtHsTotales";
            this.txtHsTotales.Size = new System.Drawing.Size(162, 20);
            this.txtHsTotales.TabIndex = 8;
            // 
            // cbxPlanes
            // 
            this.cbxPlanes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxPlanes.FormattingEnabled = true;
            this.cbxPlanes.Location = new System.Drawing.Point(99, 74);
            this.cbxPlanes.Name = "cbxPlanes";
            this.cbxPlanes.Size = new System.Drawing.Size(161, 21);
            this.cbxPlanes.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(419, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 30);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(25, 3);
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
            this.btnCancelar.Location = new System.Drawing.Point(150, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // MateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 136);
            this.Controls.Add(this.tlpMateria);
            this.Name = "MateriaDesktop";
            this.Text = "MateriaDesktop";
            this.tlpMateria.ResumeLayout(false);
            this.tlpMateria.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMateria;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblHsSemanales;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblHsTotales;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtHsSemanales;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtHsTotales;
        private System.Windows.Forms.ComboBox cbxPlanes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
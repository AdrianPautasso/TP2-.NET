namespace UI.Desktop
{
    partial class ComisionDesktop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAnioEspecialidad = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAnioEspecialidad = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbxPlanes = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66337F));
            this.tableLayoutPanel1.Controls.Add(this.lblId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAnioEspecialidad, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPlan, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDescripcion, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAnioEspecialidad, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxPlanes, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.50958F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.49042F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 123);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 12);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblAnioEspecialidad
            // 
            this.lblAnioEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAnioEspecialidad.AutoSize = true;
            this.lblAnioEspecialidad.Location = new System.Drawing.Point(3, 53);
            this.lblAnioEspecialidad.Name = "lblAnioEspecialidad";
            this.lblAnioEspecialidad.Size = new System.Drawing.Size(89, 13);
            this.lblAnioEspecialidad.TabIndex = 1;
            this.lblAnioEspecialidad.Text = "Año Especialidad";
            // 
            // lblPlan
            // 
            this.lblPlan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPlan.AutoSize = true;
            this.lblPlan.Location = new System.Drawing.Point(340, 53);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(28, 13);
            this.lblPlan.TabIndex = 4;
            this.lblPlan.Text = "Plan";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(340, 12);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(100, 3);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(162, 20);
            this.txtId.TabIndex = 7;
            // 
            // txtAnioEspecialidad
            // 
            this.txtAnioEspecialidad.Location = new System.Drawing.Point(100, 41);
            this.txtAnioEspecialidad.Name = "txtAnioEspecialidad";
            this.txtAnioEspecialidad.Size = new System.Drawing.Size(162, 20);
            this.txtAnioEspecialidad.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(443, 3);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(162, 20);
            this.txtDescripcion.TabIndex = 9;
            // 
            // cbxPlanes
            // 
            this.cbxPlanes.FormattingEnabled = true;
            this.cbxPlanes.Location = new System.Drawing.Point(443, 41);
            this.cbxPlanes.Name = "cbxPlanes";
            this.cbxPlanes.Size = new System.Drawing.Size(162, 21);
            this.cbxPlanes.TabIndex = 10;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(351, 90);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(517, 90);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ComisionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 123);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ComisionDesktop";
            this.Text = "Comision";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAnioEspecialidad;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAnioEspecialidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbxPlanes;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
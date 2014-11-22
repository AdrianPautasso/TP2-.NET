namespace UI.Desktop
{
    partial class Materias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materias));
            this.tscMaterias = new System.Windows.Forms.ToolStripContainer();
            this.tlpMaterias = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSSemanales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMaterias = new System.Windows.Forms.ToolStrip();
            this.tsbNueva = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tscMaterias.ContentPanel.SuspendLayout();
            this.tscMaterias.TopToolStripPanel.SuspendLayout();
            this.tscMaterias.SuspendLayout();
            this.tlpMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            this.tsMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscMaterias
            // 
            // 
            // tscMaterias.ContentPanel
            // 
            this.tscMaterias.ContentPanel.Controls.Add(this.tlpMaterias);
            this.tscMaterias.ContentPanel.Size = new System.Drawing.Size(759, 322);
            this.tscMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscMaterias.Location = new System.Drawing.Point(0, 0);
            this.tscMaterias.Name = "tscMaterias";
            this.tscMaterias.Size = new System.Drawing.Size(759, 347);
            this.tscMaterias.TabIndex = 0;
            this.tscMaterias.Text = "toolStripContainer1";
            // 
            // tscMaterias.TopToolStripPanel
            // 
            this.tscMaterias.TopToolStripPanel.Controls.Add(this.tsMaterias);
            // 
            // tlpMaterias
            // 
            this.tlpMaterias.ColumnCount = 2;
            this.tlpMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMaterias.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMaterias.Controls.Add(this.btnActualizar, 0, 1);
            this.tlpMaterias.Controls.Add(this.btnSalir, 1, 1);
            this.tlpMaterias.Controls.Add(this.dgvMaterias, 0, 0);
            this.tlpMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMaterias.Location = new System.Drawing.Point(0, 0);
            this.tlpMaterias.Name = "tlpMaterias";
            this.tlpMaterias.RowCount = 2;
            this.tlpMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMaterias.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMaterias.Size = new System.Drawing.Size(759, 322);
            this.tlpMaterias.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(600, 296);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(681, 296);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Materia,
            this.HSSemanales,
            this.HSTotales,
            this.Plan});
            this.tlpMaterias.SetColumnSpan(this.dgvMaterias, 2);
            this.dgvMaterias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterias.Location = new System.Drawing.Point(3, 3);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(753, 287);
            this.dgvMaterias.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "Descripcion";
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // HSSemanales
            // 
            this.HSSemanales.DataPropertyName = "HSSemanales";
            this.HSSemanales.HeaderText = "Horas Semanales";
            this.HSSemanales.Name = "HSSemanales";
            this.HSSemanales.ReadOnly = true;
            // 
            // HSTotales
            // 
            this.HSTotales.DataPropertyName = "HSTotales";
            this.HSTotales.HeaderText = "Horas Totales";
            this.HSTotales.Name = "HSTotales";
            this.HSTotales.ReadOnly = true;
            // 
            // Plan
            // 
            this.Plan.DataPropertyName = "DescPlan";
            this.Plan.HeaderText = "Plan";
            this.Plan.Name = "Plan";
            this.Plan.ReadOnly = true;
            // 
            // tsMaterias
            // 
            this.tsMaterias.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMaterias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNueva,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsMaterias.Location = new System.Drawing.Point(3, 0);
            this.tsMaterias.Name = "tsMaterias";
            this.tsMaterias.Size = new System.Drawing.Size(112, 25);
            this.tsMaterias.TabIndex = 0;
            // 
            // tsbNueva
            // 
            this.tsbNueva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNueva.Image = ((System.Drawing.Image)(resources.GetObject("tsbNueva.Image")));
            this.tsbNueva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNueva.Name = "tsbNueva";
            this.tsbNueva.Size = new System.Drawing.Size(23, 22);
            this.tsbNueva.Text = "Nueva";
            this.tsbNueva.Click += new System.EventHandler(this.tsbNueva_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 347);
            this.Controls.Add(this.tscMaterias);
            this.Name = "Materias";
            this.Text = "Materias";
            this.tscMaterias.ContentPanel.ResumeLayout(false);
            this.tscMaterias.TopToolStripPanel.ResumeLayout(false);
            this.tscMaterias.TopToolStripPanel.PerformLayout();
            this.tscMaterias.ResumeLayout(false);
            this.tscMaterias.PerformLayout();
            this.tlpMaterias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            this.tsMaterias.ResumeLayout(false);
            this.tsMaterias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscMaterias;
        private System.Windows.Forms.TableLayoutPanel tlpMaterias;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.ToolStrip tsMaterias;
        private System.Windows.Forms.ToolStripButton tsbNueva;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSSemanales;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSTotales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plan;
    }
}
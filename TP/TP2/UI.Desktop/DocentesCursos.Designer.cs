namespace UI.Desktop
{
    partial class DocentesCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocentesCursos));
            this.tscDocentesCursos = new System.Windows.Forms.ToolStripContainer();
            this.tlpDocentesCursos = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvDocentesCursos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsDocentesCursos = new System.Windows.Forms.ToolStrip();
            this.tsbNueva = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tscDocentesCursos.ContentPanel.SuspendLayout();
            this.tscDocentesCursos.TopToolStripPanel.SuspendLayout();
            this.tscDocentesCursos.SuspendLayout();
            this.tlpDocentesCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentesCursos)).BeginInit();
            this.tsDocentesCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscDocentesCursos
            // 
            // 
            // tscDocentesCursos.ContentPanel
            // 
            this.tscDocentesCursos.ContentPanel.Controls.Add(this.tlpDocentesCursos);
            this.tscDocentesCursos.ContentPanel.Size = new System.Drawing.Size(759, 322);
            this.tscDocentesCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscDocentesCursos.Location = new System.Drawing.Point(0, 0);
            this.tscDocentesCursos.Name = "tscDocentesCursos";
            this.tscDocentesCursos.Size = new System.Drawing.Size(759, 347);
            this.tscDocentesCursos.TabIndex = 0;
            this.tscDocentesCursos.Text = "toolStripContainer1";
            // 
            // tscDocentesCursos.TopToolStripPanel
            // 
            this.tscDocentesCursos.TopToolStripPanel.Controls.Add(this.tsDocentesCursos);
            // 
            // tlpDocentesCursos
            // 
            this.tlpDocentesCursos.ColumnCount = 2;
            this.tlpDocentesCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDocentesCursos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpDocentesCursos.Controls.Add(this.btnActualizar, 0, 1);
            this.tlpDocentesCursos.Controls.Add(this.btnSalir, 1, 1);
            this.tlpDocentesCursos.Controls.Add(this.dgvDocentesCursos, 0, 0);
            this.tlpDocentesCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDocentesCursos.Location = new System.Drawing.Point(0, 0);
            this.tlpDocentesCursos.Name = "tlpDocentesCursos";
            this.tlpDocentesCursos.RowCount = 2;
            this.tlpDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDocentesCursos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpDocentesCursos.Size = new System.Drawing.Size(759, 322);
            this.tlpDocentesCursos.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
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
            // dgvDocentesCursos
            // 
            this.dgvDocentesCursos.AllowUserToAddRows = false;
            this.dgvDocentesCursos.AllowUserToDeleteRows = false;
            this.dgvDocentesCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocentesCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentesCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Materia,
            this.Comision,
            this.Cargo});
            this.tlpDocentesCursos.SetColumnSpan(this.dgvDocentesCursos, 2);
            this.dgvDocentesCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocentesCursos.Location = new System.Drawing.Point(3, 3);
            this.dgvDocentesCursos.Name = "dgvDocentesCursos";
            this.dgvDocentesCursos.ReadOnly = true;
            this.dgvDocentesCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentesCursos.Size = new System.Drawing.Size(753, 287);
            this.dgvDocentesCursos.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreDocente";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "ApellidoDocente";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "DescMateria";
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // Comision
            // 
            this.Comision.DataPropertyName = "DescComision";
            this.Comision.HeaderText = "Comisión";
            this.Comision.Name = "Comision";
            this.Comision.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // tsDocentesCursos
            // 
            this.tsDocentesCursos.Dock = System.Windows.Forms.DockStyle.None;
            this.tsDocentesCursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNueva,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsDocentesCursos.Location = new System.Drawing.Point(3, 0);
            this.tsDocentesCursos.Name = "tsDocentesCursos";
            this.tsDocentesCursos.Size = new System.Drawing.Size(112, 25);
            this.tsDocentesCursos.TabIndex = 0;
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
            // DocentesCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 347);
            this.Controls.Add(this.tscDocentesCursos);
            this.Name = "DocentesCursos";
            this.Text = "DocentesCursos";
            this.tscDocentesCursos.ContentPanel.ResumeLayout(false);
            this.tscDocentesCursos.TopToolStripPanel.ResumeLayout(false);
            this.tscDocentesCursos.TopToolStripPanel.PerformLayout();
            this.tscDocentesCursos.ResumeLayout(false);
            this.tscDocentesCursos.PerformLayout();
            this.tlpDocentesCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentesCursos)).EndInit();
            this.tsDocentesCursos.ResumeLayout(false);
            this.tsDocentesCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscDocentesCursos;
        private System.Windows.Forms.TableLayoutPanel tlpDocentesCursos;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvDocentesCursos;
        private System.Windows.Forms.ToolStrip tsDocentesCursos;
        private System.Windows.Forms.ToolStripButton tsbNueva;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
    }
}
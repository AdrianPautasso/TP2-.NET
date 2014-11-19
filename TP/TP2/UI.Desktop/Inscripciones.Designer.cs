namespace UI.Desktop
{
    partial class Inscripciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscripciones));
            this.tscInscripciones = new System.Windows.Forms.ToolStripContainer();
            this.tlpInscripciones = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvInscripciones = new System.Windows.Forms.DataGridView();
            this.tsInscripciones = new System.Windows.Forms.ToolStrip();
            this.tscNueva = new System.Windows.Forms.ToolStripButton();
            this.tscEditar = new System.Windows.Forms.ToolStripButton();
            this.tscEliminar = new System.Windows.Forms.ToolStripButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comisión = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condición = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tscInscripciones.ContentPanel.SuspendLayout();
            this.tscInscripciones.TopToolStripPanel.SuspendLayout();
            this.tscInscripciones.SuspendLayout();
            this.tlpInscripciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).BeginInit();
            this.tsInscripciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscInscripciones
            // 
            // 
            // tscInscripciones.ContentPanel
            // 
            this.tscInscripciones.ContentPanel.Controls.Add(this.tlpInscripciones);
            this.tscInscripciones.ContentPanel.Size = new System.Drawing.Size(759, 322);
            this.tscInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscInscripciones.Location = new System.Drawing.Point(0, 0);
            this.tscInscripciones.Name = "tscInscripciones";
            this.tscInscripciones.Size = new System.Drawing.Size(759, 347);
            this.tscInscripciones.TabIndex = 0;
            this.tscInscripciones.Text = "toolStripContainer1";
            // 
            // tscInscripciones.TopToolStripPanel
            // 
            this.tscInscripciones.TopToolStripPanel.Controls.Add(this.tsInscripciones);
            // 
            // tlpInscripciones
            // 
            this.tlpInscripciones.ColumnCount = 2;
            this.tlpInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInscripciones.Controls.Add(this.btnActualizar, 0, 1);
            this.tlpInscripciones.Controls.Add(this.btnSalir, 1, 1);
            this.tlpInscripciones.Controls.Add(this.dgvInscripciones, 0, 0);
            this.tlpInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInscripciones.Location = new System.Drawing.Point(0, 0);
            this.tlpInscripciones.Name = "tlpInscripciones";
            this.tlpInscripciones.RowCount = 2;
            this.tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpInscripciones.Size = new System.Drawing.Size(759, 322);
            this.tlpInscripciones.TabIndex = 0;
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
            // dgvInscripciones
            // 
            this.dgvInscripciones.AllowUserToAddRows = false;
            this.dgvInscripciones.AllowUserToDeleteRows = false;
            this.dgvInscripciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Legajo,
            this.Materia,
            this.Comisión,
            this.Condición,
            this.Nota});
            this.tlpInscripciones.SetColumnSpan(this.dgvInscripciones, 2);
            this.dgvInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInscripciones.Location = new System.Drawing.Point(3, 3);
            this.dgvInscripciones.Name = "dgvInscripciones";
            this.dgvInscripciones.ReadOnly = true;
            this.dgvInscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscripciones.Size = new System.Drawing.Size(753, 287);
            this.dgvInscripciones.TabIndex = 2;
            // 
            // tsInscripciones
            // 
            this.tsInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsInscripciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscNueva,
            this.tscEditar,
            this.tscEliminar});
            this.tsInscripciones.Location = new System.Drawing.Point(3, 0);
            this.tsInscripciones.Name = "tsInscripciones";
            this.tsInscripciones.Size = new System.Drawing.Size(81, 25);
            this.tsInscripciones.TabIndex = 0;
            // 
            // tscNueva
            // 
            this.tscNueva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tscNueva.Image = ((System.Drawing.Image)(resources.GetObject("tscNueva.Image")));
            this.tscNueva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tscNueva.Name = "tscNueva";
            this.tscNueva.Size = new System.Drawing.Size(23, 22);
            this.tscNueva.Text = "Nueva";
            // 
            // tscEditar
            // 
            this.tscEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tscEditar.Image = ((System.Drawing.Image)(resources.GetObject("tscEditar.Image")));
            this.tscEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tscEditar.Name = "tscEditar";
            this.tscEditar.Size = new System.Drawing.Size(23, 22);
            this.tscEditar.Text = "Editar";
            // 
            // tscEliminar
            // 
            this.tscEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tscEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tscEliminar.Image")));
            this.tscEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tscEliminar.Name = "tscEliminar";
            this.tscEliminar.Size = new System.Drawing.Size(23, 22);
            this.tscEliminar.Text = "Eliminar";
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
            this.Nombre.DataPropertyName = "NombreAlumno";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "ApellidoAlumno";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "LegajoAlumno";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "DescMateria";
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            this.Materia.ReadOnly = true;
            // 
            // Comisión
            // 
            this.Comisión.DataPropertyName = "DescComision";
            this.Comisión.HeaderText = "Comision";
            this.Comisión.Name = "Comisión";
            this.Comisión.ReadOnly = true;
            // 
            // Condición
            // 
            this.Condición.DataPropertyName = "Condicion";
            this.Condición.HeaderText = "Condición";
            this.Condición.Name = "Condición";
            this.Condición.ReadOnly = true;
            // 
            // Nota
            // 
            this.Nota.DataPropertyName = "Nota";
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            // 
            // Inscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 347);
            this.Controls.Add(this.tscInscripciones);
            this.Name = "Inscripciones";
            this.Text = "Inscripciones";
            this.tscInscripciones.ContentPanel.ResumeLayout(false);
            this.tscInscripciones.TopToolStripPanel.ResumeLayout(false);
            this.tscInscripciones.TopToolStripPanel.PerformLayout();
            this.tscInscripciones.ResumeLayout(false);
            this.tscInscripciones.PerformLayout();
            this.tlpInscripciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).EndInit();
            this.tsInscripciones.ResumeLayout(false);
            this.tsInscripciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscInscripciones;
        private System.Windows.Forms.TableLayoutPanel tlpInscripciones;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvInscripciones;
        private System.Windows.Forms.ToolStrip tsInscripciones;
        private System.Windows.Forms.ToolStripButton tscNueva;
        private System.Windows.Forms.ToolStripButton tscEditar;
        private System.Windows.Forms.ToolStripButton tscEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comisión;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condición;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
    }
}
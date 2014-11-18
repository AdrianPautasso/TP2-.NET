namespace UI.Desktop
{
    partial class PlanDesktop
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
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbxEsp = new System.Windows.Forms.ComboBox();
            this.lblEsp = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtDesc, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDesc, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbxEsp, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEsp, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(572, 133);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDesc.Location = new System.Drawing.Point(374, 12);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(162, 20);
            this.txtDesc.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(274, 15);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Descripcion";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(74, 12);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(162, 20);
            this.txtID.TabIndex = 2;
            // 
            // cbxEsp
            // 
            this.cbxEsp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxEsp.FormattingEnabled = true;
            this.cbxEsp.Location = new System.Drawing.Point(374, 55);
            this.cbxEsp.Name = "cbxEsp";
            this.cbxEsp.Size = new System.Drawing.Size(162, 21);
            this.cbxEsp.TabIndex = 6;
            // 
            // lblEsp
            // 
            this.lblEsp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEsp.AutoSize = true;
            this.lblEsp.Location = new System.Drawing.Point(274, 59);
            this.lblEsp.Name = "lblEsp";
            this.lblEsp.Size = new System.Drawing.Size(67, 13);
            this.lblEsp.TabIndex = 7;
            this.lblEsp.Text = "Especialidad";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAceptar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(374, 91);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(195, 39);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAceptar.Location = new System.Drawing.Point(11, 8);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(108, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // PlanDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 133);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PlanDesktop";
            this.Text = "PlanDesktop";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxEsp;
        private System.Windows.Forms.Label lblEsp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
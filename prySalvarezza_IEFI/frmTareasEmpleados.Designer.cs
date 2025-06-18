namespace prySalvarezza_IEFI
{
    partial class frmTareasEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTareasEmpleados));
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbTareas = new System.Windows.Forms.ComboBox();
            this.btnAgregrar = new System.Windows.Forms.Button();
            this.cmbLugares = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblTareas = new System.Windows.Forms.Label();
            this.mrcDetalle = new System.Windows.Forms.GroupBox();
            this.lblLicencias = new System.Windows.Forms.Label();
            this.lblReclamos = new System.Windows.Forms.Label();
            this.lblUniforme = new System.Windows.Forms.Label();
            this.chkEstudio = new System.Windows.Forms.CheckBox();
            this.chkRecibo = new System.Windows.Forms.CheckBox();
            this.chkSalario = new System.Windows.Forms.CheckBox();
            this.chkVacaciones = new System.Windows.Forms.CheckBox();
            this.chkInsumo = new System.Windows.Forms.CheckBox();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnDeshacer = new System.Windows.Forms.Button();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.mrcDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(16, 43);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(264, 22);
            this.dtpFecha.TabIndex = 0;
            // 
            // cmbTareas
            // 
            this.cmbTareas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTareas.FormattingEnabled = true;
            this.cmbTareas.Location = new System.Drawing.Point(16, 111);
            this.cmbTareas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTareas.Name = "cmbTareas";
            this.cmbTareas.Size = new System.Drawing.Size(160, 24);
            this.cmbTareas.TabIndex = 1;
            // 
            // btnAgregrar
            // 
            this.btnAgregrar.Location = new System.Drawing.Point(20, 153);
            this.btnAgregrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregrar.Name = "btnAgregrar";
            this.btnAgregrar.Size = new System.Drawing.Size(139, 39);
            this.btnAgregrar.TabIndex = 3;
            this.btnAgregrar.Text = "Agregar";
            this.btnAgregrar.UseVisualStyleBackColor = true;
            this.btnAgregrar.Click += new System.EventHandler(this.btnAgregrar_Click);
            // 
            // cmbLugares
            // 
            this.cmbLugares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugares.FormattingEnabled = true;
            this.cmbLugares.Location = new System.Drawing.Point(199, 111);
            this.cmbLugares.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLugares.Name = "cmbLugares";
            this.cmbLugares.Size = new System.Drawing.Size(160, 24);
            this.cmbLugares.TabIndex = 2;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(16, 16);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 16);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.BackColor = System.Drawing.Color.Transparent;
            this.lblLugar.Location = new System.Drawing.Point(207, 91);
            this.lblLugar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(44, 16);
            this.lblLugar.TabIndex = 6;
            this.lblLugar.Text = "Lugar:";
            // 
            // lblTareas
            // 
            this.lblTareas.AutoSize = true;
            this.lblTareas.BackColor = System.Drawing.Color.Transparent;
            this.lblTareas.Location = new System.Drawing.Point(12, 91);
            this.lblTareas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTareas.Name = "lblTareas";
            this.lblTareas.Size = new System.Drawing.Size(54, 16);
            this.lblTareas.TabIndex = 7;
            this.lblTareas.Text = "Tareas:";
            // 
            // mrcDetalle
            // 
            this.mrcDetalle.BackColor = System.Drawing.Color.Transparent;
            this.mrcDetalle.Controls.Add(this.lblLicencias);
            this.mrcDetalle.Controls.Add(this.lblReclamos);
            this.mrcDetalle.Controls.Add(this.lblUniforme);
            this.mrcDetalle.Controls.Add(this.chkEstudio);
            this.mrcDetalle.Controls.Add(this.chkRecibo);
            this.mrcDetalle.Controls.Add(this.chkSalario);
            this.mrcDetalle.Controls.Add(this.chkVacaciones);
            this.mrcDetalle.Controls.Add(this.chkInsumo);
            this.mrcDetalle.Location = new System.Drawing.Point(19, 705);
            this.mrcDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.mrcDetalle.Name = "mrcDetalle";
            this.mrcDetalle.Padding = new System.Windows.Forms.Padding(4);
            this.mrcDetalle.Size = new System.Drawing.Size(244, 177);
            this.mrcDetalle.TabIndex = 5;
            this.mrcDetalle.TabStop = false;
            this.mrcDetalle.Text = "Detalle";
            // 
            // lblLicencias
            // 
            this.lblLicencias.AutoSize = true;
            this.lblLicencias.Location = new System.Drawing.Point(27, 67);
            this.lblLicencias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicencias.Name = "lblLicencias";
            this.lblLicencias.Size = new System.Drawing.Size(67, 16);
            this.lblLicencias.TabIndex = 16;
            this.lblLicencias.Text = "Licencias:";
            // 
            // lblReclamos
            // 
            this.lblReclamos.AutoSize = true;
            this.lblReclamos.Location = new System.Drawing.Point(27, 124);
            this.lblReclamos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReclamos.Name = "lblReclamos";
            this.lblReclamos.Size = new System.Drawing.Size(72, 16);
            this.lblReclamos.TabIndex = 15;
            this.lblReclamos.Text = "Reclamos:";
            // 
            // lblUniforme
            // 
            this.lblUniforme.AutoSize = true;
            this.lblUniforme.Location = new System.Drawing.Point(27, 19);
            this.lblUniforme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUniforme.Name = "lblUniforme";
            this.lblUniforme.Size = new System.Drawing.Size(71, 16);
            this.lblUniforme.TabIndex = 14;
            this.lblUniforme.Text = "Uniformes:";
            // 
            // chkEstudio
            // 
            this.chkEstudio.AutoSize = true;
            this.chkEstudio.Location = new System.Drawing.Point(30, 95);
            this.chkEstudio.Margin = new System.Windows.Forms.Padding(4);
            this.chkEstudio.Name = "chkEstudio";
            this.chkEstudio.Size = new System.Drawing.Size(74, 20);
            this.chkEstudio.TabIndex = 2;
            this.chkEstudio.Text = "Estudio";
            this.chkEstudio.UseVisualStyleBackColor = true;
            // 
            // chkRecibo
            // 
            this.chkRecibo.AutoSize = true;
            this.chkRecibo.Location = new System.Drawing.Point(121, 148);
            this.chkRecibo.Margin = new System.Windows.Forms.Padding(4);
            this.chkRecibo.Name = "chkRecibo";
            this.chkRecibo.Size = new System.Drawing.Size(73, 20);
            this.chkRecibo.TabIndex = 5;
            this.chkRecibo.Text = "Recibo";
            this.chkRecibo.UseVisualStyleBackColor = true;
            // 
            // chkSalario
            // 
            this.chkSalario.AutoSize = true;
            this.chkSalario.Location = new System.Drawing.Point(30, 148);
            this.chkSalario.Margin = new System.Windows.Forms.Padding(4);
            this.chkSalario.Name = "chkSalario";
            this.chkSalario.Size = new System.Drawing.Size(72, 20);
            this.chkSalario.TabIndex = 4;
            this.chkSalario.Text = "Salario";
            this.chkSalario.UseVisualStyleBackColor = true;
            // 
            // chkVacaciones
            // 
            this.chkVacaciones.AutoSize = true;
            this.chkVacaciones.Location = new System.Drawing.Point(121, 95);
            this.chkVacaciones.Margin = new System.Windows.Forms.Padding(4);
            this.chkVacaciones.Name = "chkVacaciones";
            this.chkVacaciones.Size = new System.Drawing.Size(101, 20);
            this.chkVacaciones.TabIndex = 3;
            this.chkVacaciones.Text = "Vacaciones";
            this.chkVacaciones.UseVisualStyleBackColor = true;
            // 
            // chkInsumo
            // 
            this.chkInsumo.AutoSize = true;
            this.chkInsumo.Location = new System.Drawing.Point(30, 39);
            this.chkInsumo.Margin = new System.Windows.Forms.Padding(4);
            this.chkInsumo.Name = "chkInsumo";
            this.chkInsumo.Size = new System.Drawing.Size(79, 20);
            this.chkInsumo.TabIndex = 1;
            this.chkInsumo.Text = "Insumos";
            this.chkInsumo.UseVisualStyleBackColor = true;
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.AllowUserToResizeColumns = false;
            this.dgvTareas.AllowUserToResizeRows = false;
            this.dgvTareas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(16, 199);
            this.dgvTareas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersVisible = false;
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(464, 308);
            this.dgvTareas.TabIndex = 9;
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(16, 553);
            this.txtComentarios.Margin = new System.Windows.Forms.Padding(4);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(463, 144);
            this.txtComentarios.TabIndex = 4;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(290, 774);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(189, 46);
            this.btnGrabar.TabIndex = 7;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnDeshacer
            // 
            this.btnDeshacer.Location = new System.Drawing.Point(290, 709);
            this.btnDeshacer.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeshacer.Name = "btnDeshacer";
            this.btnDeshacer.Size = new System.Drawing.Size(189, 46);
            this.btnDeshacer.TabIndex = 6;
            this.btnDeshacer.Text = "Deshacer";
            this.btnDeshacer.UseVisualStyleBackColor = true;
            this.btnDeshacer.Click += new System.EventHandler(this.btnDeshacer_Click);
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.BackColor = System.Drawing.Color.Transparent;
            this.lblComentarios.Location = new System.Drawing.Point(16, 533);
            this.lblComentarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(86, 16);
            this.lblComentarios.TabIndex = 13;
            this.lblComentarios.Text = "Comentarios:";
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AllowUserToAddRows = false;
            this.dgvMostrar.AllowUserToDeleteRows = false;
            this.dgvMostrar.AllowUserToResizeColumns = false;
            this.dgvMostrar.AllowUserToResizeRows = false;
            this.dgvMostrar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(487, 16);
            this.dgvMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMostrar.MultiSelect = false;
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            this.dgvMostrar.RowHeadersVisible = false;
            this.dgvMostrar.RowHeadersWidth = 51;
            this.dgvMostrar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMostrar.Size = new System.Drawing.Size(1335, 682);
            this.dgvMostrar.TabIndex = 14;
            // 
            // frmTareasEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prySalvarezza_IEFI.Properties.Resources._3;
            this.ClientSize = new System.Drawing.Size(1858, 905);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.btnDeshacer);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.mrcDetalle);
            this.Controls.Add(this.lblTareas);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbLugares);
            this.Controls.Add(this.btnAgregrar);
            this.Controls.Add(this.cmbTareas);
            this.Controls.Add(this.dtpFecha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTareasEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Tareas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTareasEmpleados_Load);
            this.mrcDetalle.ResumeLayout(false);
            this.mrcDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbTareas;
        private System.Windows.Forms.Button btnAgregrar;
        private System.Windows.Forms.ComboBox cmbLugares;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblTareas;
        private System.Windows.Forms.GroupBox mrcDetalle;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnDeshacer;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.CheckBox chkEstudio;
        private System.Windows.Forms.CheckBox chkRecibo;
        private System.Windows.Forms.CheckBox chkSalario;
        private System.Windows.Forms.CheckBox chkVacaciones;
        private System.Windows.Forms.CheckBox chkInsumo;
        private System.Windows.Forms.Label lblLicencias;
        private System.Windows.Forms.Label lblReclamos;
        private System.Windows.Forms.Label lblUniforme;
        private System.Windows.Forms.DataGridView dgvMostrar;
    }
}
namespace prySalvarezza_IEFI
{
    partial class frmTareasAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTareasAdmin));
            this.mrcLugares = new System.Windows.Forms.GroupBox();
            this.btnEliminarLugar = new System.Windows.Forms.Button();
            this.dgvLugares = new System.Windows.Forms.DataGridView();
            this.btnAgregarLugar = new System.Windows.Forms.Button();
            this.txtLugares = new System.Windows.Forms.TextBox();
            this.mrcTareas = new System.Windows.Forms.GroupBox();
            this.btnEliminarTarea = new System.Windows.Forms.Button();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.txtTareas = new System.Windows.Forms.TextBox();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.mrcLugares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLugares)).BeginInit();
            this.mrcTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcLugares
            // 
            this.mrcLugares.BackColor = System.Drawing.Color.Transparent;
            this.mrcLugares.Controls.Add(this.btnEliminarLugar);
            this.mrcLugares.Controls.Add(this.dgvLugares);
            this.mrcLugares.Controls.Add(this.btnAgregarLugar);
            this.mrcLugares.Controls.Add(this.txtLugares);
            this.mrcLugares.Cursor = System.Windows.Forms.Cursors.Default;
            this.mrcLugares.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mrcLugares.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mrcLugares.Location = new System.Drawing.Point(313, 13);
            this.mrcLugares.Margin = new System.Windows.Forms.Padding(4);
            this.mrcLugares.Name = "mrcLugares";
            this.mrcLugares.Padding = new System.Windows.Forms.Padding(4);
            this.mrcLugares.Size = new System.Drawing.Size(287, 436);
            this.mrcLugares.TabIndex = 9;
            this.mrcLugares.TabStop = false;
            this.mrcLugares.Text = "Agregar Lugar:";
            // 
            // btnEliminarLugar
            // 
            this.btnEliminarLugar.Location = new System.Drawing.Point(173, 66);
            this.btnEliminarLugar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarLugar.Name = "btnEliminarLugar";
            this.btnEliminarLugar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarLugar.TabIndex = 3;
            this.btnEliminarLugar.Text = "Eliminar";
            this.btnEliminarLugar.UseVisualStyleBackColor = true;
            this.btnEliminarLugar.Click += new System.EventHandler(this.btnEliminarLugar_Click);
            // 
            // dgvLugares
            // 
            this.dgvLugares.AllowUserToAddRows = false;
            this.dgvLugares.AllowUserToDeleteRows = false;
            this.dgvLugares.AllowUserToResizeColumns = false;
            this.dgvLugares.AllowUserToResizeRows = false;
            this.dgvLugares.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLugares.Location = new System.Drawing.Point(8, 63);
            this.dgvLugares.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLugares.MultiSelect = false;
            this.dgvLugares.Name = "dgvLugares";
            this.dgvLugares.ReadOnly = true;
            this.dgvLugares.RowHeadersVisible = false;
            this.dgvLugares.RowHeadersWidth = 51;
            this.dgvLugares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLugares.Size = new System.Drawing.Size(157, 334);
            this.dgvLugares.TabIndex = 6;
            this.dgvLugares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLugares_CellClick);
            // 
            // btnAgregarLugar
            // 
            this.btnAgregarLugar.Location = new System.Drawing.Point(173, 31);
            this.btnAgregarLugar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarLugar.Name = "btnAgregarLugar";
            this.btnAgregarLugar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarLugar.TabIndex = 2;
            this.btnAgregarLugar.Text = "Agregar";
            this.btnAgregarLugar.UseVisualStyleBackColor = true;
            this.btnAgregarLugar.Click += new System.EventHandler(this.btnAgregarLugar_Click);
            // 
            // txtLugares
            // 
            this.txtLugares.Location = new System.Drawing.Point(8, 31);
            this.txtLugares.Margin = new System.Windows.Forms.Padding(4);
            this.txtLugares.Name = "txtLugares";
            this.txtLugares.Size = new System.Drawing.Size(157, 22);
            this.txtLugares.TabIndex = 1;
            this.txtLugares.TextChanged += new System.EventHandler(this.txtLugares_TextChanged_1);
            // 
            // mrcTareas
            // 
            this.mrcTareas.BackColor = System.Drawing.Color.Transparent;
            this.mrcTareas.Controls.Add(this.btnEliminarTarea);
            this.mrcTareas.Controls.Add(this.dgvTareas);
            this.mrcTareas.Controls.Add(this.txtTareas);
            this.mrcTareas.Controls.Add(this.btnAgregarTarea);
            this.mrcTareas.Cursor = System.Windows.Forms.Cursors.Default;
            this.mrcTareas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mrcTareas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mrcTareas.Location = new System.Drawing.Point(13, 13);
            this.mrcTareas.Margin = new System.Windows.Forms.Padding(4);
            this.mrcTareas.Name = "mrcTareas";
            this.mrcTareas.Padding = new System.Windows.Forms.Padding(4);
            this.mrcTareas.Size = new System.Drawing.Size(292, 436);
            this.mrcTareas.TabIndex = 10;
            this.mrcTareas.TabStop = false;
            this.mrcTareas.Text = "Agregar Tarea:";
            // 
            // btnEliminarTarea
            // 
            this.btnEliminarTarea.Location = new System.Drawing.Point(181, 60);
            this.btnEliminarTarea.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarTarea.Name = "btnEliminarTarea";
            this.btnEliminarTarea.Size = new System.Drawing.Size(100, 28);
            this.btnEliminarTarea.TabIndex = 3;
            this.btnEliminarTarea.Text = "Eliminar";
            this.btnEliminarTarea.UseVisualStyleBackColor = true;
            this.btnEliminarTarea.Click += new System.EventHandler(this.btnEliminarTarea_Click);
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.AllowUserToResizeColumns = false;
            this.dgvTareas.AllowUserToResizeRows = false;
            this.dgvTareas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(8, 59);
            this.dgvTareas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersVisible = false;
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(164, 334);
            this.dgvTareas.TabIndex = 5;
            this.dgvTareas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellClick);
            // 
            // txtTareas
            // 
            this.txtTareas.Location = new System.Drawing.Point(8, 27);
            this.txtTareas.Margin = new System.Windows.Forms.Padding(4);
            this.txtTareas.Name = "txtTareas";
            this.txtTareas.Size = new System.Drawing.Size(164, 22);
            this.txtTareas.TabIndex = 1;
            this.txtTareas.TextChanged += new System.EventHandler(this.txtTareas_TextChanged_1);
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.Location = new System.Drawing.Point(180, 23);
            this.btnAgregarTarea.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(100, 28);
            this.btnAgregarTarea.TabIndex = 2;
            this.btnAgregarTarea.Text = "Agregar";
            this.btnAgregarTarea.UseVisualStyleBackColor = true;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // frmTareasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prySalvarezza_IEFI.Properties.Resources._4;
            this.ClientSize = new System.Drawing.Size(619, 459);
            this.Controls.Add(this.mrcLugares);
            this.Controls.Add(this.mrcTareas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTareasAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar tareas y lugares";
            this.Load += new System.EventHandler(this.frmTareasAdmin_Load);
            this.mrcLugares.ResumeLayout(false);
            this.mrcLugares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLugares)).EndInit();
            this.mrcTareas.ResumeLayout(false);
            this.mrcTareas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcLugares;
        private System.Windows.Forms.Button btnEliminarLugar;
        private System.Windows.Forms.DataGridView dgvLugares;
        private System.Windows.Forms.Button btnAgregarLugar;
        private System.Windows.Forms.TextBox txtLugares;
        private System.Windows.Forms.GroupBox mrcTareas;
        private System.Windows.Forms.Button btnEliminarTarea;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.TextBox txtTareas;
        private System.Windows.Forms.Button btnAgregarTarea;
    }
}
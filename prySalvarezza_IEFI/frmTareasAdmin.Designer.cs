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
            this.txtTareas = new System.Windows.Forms.TextBox();
            this.txtLugares = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregrar = new System.Windows.Forms.Button();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.dgvLugares = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLugares)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTareas
            // 
            this.txtTareas.Location = new System.Drawing.Point(13, 34);
            this.txtTareas.Name = "txtTareas";
            this.txtTareas.Size = new System.Drawing.Size(192, 20);
            this.txtTareas.TabIndex = 0;
            this.txtTareas.TextChanged += new System.EventHandler(this.txtTareas_TextChanged);
            // 
            // txtLugares
            // 
            this.txtLugares.Location = new System.Drawing.Point(214, 34);
            this.txtLugares.Name = "txtLugares";
            this.txtLugares.Size = new System.Drawing.Size(192, 20);
            this.txtLugares.TabIndex = 1;
            this.txtLugares.TextChanged += new System.EventHandler(this.txtLugares_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregar Tarea:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Agregrar Lugar:";
            // 
            // btnAgregrar
            // 
            this.btnAgregrar.Location = new System.Drawing.Point(173, 337);
            this.btnAgregrar.Name = "btnAgregrar";
            this.btnAgregrar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregrar.TabIndex = 4;
            this.btnAgregrar.Text = "Agregar";
            this.btnAgregrar.UseVisualStyleBackColor = true;
            this.btnAgregrar.Click += new System.EventHandler(this.btnAgregrar_Click);
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.AllowUserToResizeColumns = false;
            this.dgvTareas.AllowUserToResizeRows = false;
            this.dgvTareas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(13, 60);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersVisible = false;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(192, 271);
            this.dgvTareas.TabIndex = 5;
            // 
            // dgvLugares
            // 
            this.dgvLugares.AllowUserToAddRows = false;
            this.dgvLugares.AllowUserToDeleteRows = false;
            this.dgvLugares.AllowUserToResizeColumns = false;
            this.dgvLugares.AllowUserToResizeRows = false;
            this.dgvLugares.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLugares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLugares.Location = new System.Drawing.Point(214, 60);
            this.dgvLugares.MultiSelect = false;
            this.dgvLugares.Name = "dgvLugares";
            this.dgvLugares.ReadOnly = true;
            this.dgvLugares.RowHeadersVisible = false;
            this.dgvLugares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLugares.Size = new System.Drawing.Size(192, 271);
            this.dgvLugares.TabIndex = 6;
            // 
            // frmTareasAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 378);
            this.Controls.Add(this.dgvLugares);
            this.Controls.Add(this.dgvTareas);
            this.Controls.Add(this.btnAgregrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLugares);
            this.Controls.Add(this.txtTareas);
            this.Name = "frmTareasAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTareasAdmin";
            this.Load += new System.EventHandler(this.frmTareasAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLugares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTareas;
        private System.Windows.Forms.TextBox txtLugares;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregrar;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.DataGridView dgvLugares;
    }
}
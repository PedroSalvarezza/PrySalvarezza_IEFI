namespace prySalvarezza_IEFI
{
    partial class frmPrincipalAdmin
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
            this.components = new System.ComponentModel.Container();
            this.menPrinncipal = new System.Windows.Forms.MenuStrip();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuarioIngreso = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaYHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.menPrinncipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menPrinncipal
            // 
            this.menPrinncipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareasToolStripMenuItem,
            this.administraciónToolStripMenuItem});
            this.menPrinncipal.Location = new System.Drawing.Point(0, 0);
            this.menPrinncipal.Name = "menPrinncipal";
            this.menPrinncipal.Size = new System.Drawing.Size(842, 24);
            this.menPrinncipal.TabIndex = 0;
            this.menPrinncipal.Text = "menuStrip1";
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.tareasToolStripMenuItem.Text = "Tareas";
            this.tareasToolStripMenuItem.Click += new System.EventHandler(this.tareasToolStripMenuItem_Click);
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.auditoriasToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios...";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // auditoriasToolStripMenuItem
            // 
            this.auditoriasToolStripMenuItem.Name = "auditoriasToolStripMenuItem";
            this.auditoriasToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.auditoriasToolStripMenuItem.Text = "Auditorias...";
            this.auditoriasToolStripMenuItem.Click += new System.EventHandler(this.auditoriasToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuarioIngreso,
            this.lblFechaYHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(842, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // lblUsuarioIngreso
            // 
            this.lblUsuarioIngreso.Name = "lblUsuarioIngreso";
            this.lblUsuarioIngreso.Size = new System.Drawing.Size(0, 17);
            // 
            // lblFechaYHora
            // 
            this.lblFechaYHora.Name = "lblFechaYHora";
            this.lblFechaYHora.Size = new System.Drawing.Size(0, 17);
            // 
            // Temporizador
            // 
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // frmPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 468);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menPrinncipal);
            this.MainMenuStrip = this.menPrinncipal;
            this.Name = "frmPrincipalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipalAdmin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipalAdmin_FormClosed);
            this.Load += new System.EventHandler(this.frmPricipalAdmin_Load);
            this.menPrinncipal.ResumeLayout(false);
            this.menPrinncipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menPrinncipal;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioIngreso;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaYHora;
        private System.Windows.Forms.Timer Temporizador;
    }
}
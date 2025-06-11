namespace pryOrellano_IEFI
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.ssUsuario = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblContador = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmContador = new System.Windows.Forms.Timer(this.components);
            this.tmFecha = new System.Windows.Forms.Timer(this.components);
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.msTareas = new System.Windows.Forms.ToolStripMenuItem();
            this.msAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.msUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.msAuditoria = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            this.ssUsuario.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picFondo
            // 
            this.picFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFondo.BackgroundImage")));
            this.picFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFondo.Location = new System.Drawing.Point(0, 0);
            this.picFondo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(891, 604);
            this.picFondo.TabIndex = 0;
            this.picFondo.TabStop = false;
            // 
            // ssUsuario
            // 
            this.ssUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ssUsuario.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssUsuario.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblFecha,
            this.lblContador});
            this.ssUsuario.Location = new System.Drawing.Point(0, 574);
            this.ssUsuario.Name = "ssUsuario";
            this.ssUsuario.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.ssUsuario.Size = new System.Drawing.Size(891, 30);
            this.ssUsuario.TabIndex = 1;
            this.ssUsuario.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(19, 24);
            this.lblUsuario.Text = "...";
            // 
            // lblFecha
            // 
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(19, 24);
            this.lblFecha.Text = "...";
            // 
            // lblContador
            // 
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(19, 24);
            this.lblContador.Text = "...";
            // 
            // tmContador
            // 
            this.tmContador.Interval = 1000;
            this.tmContador.Tick += new System.EventHandler(this.tmContador_Tick);
            // 
            // tmFecha
            // 
            this.tmFecha.Tick += new System.EventHandler(this.tmFecha_Tick);
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.msMenu.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msTareas,
            this.msAdministracion});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msMenu.Size = new System.Drawing.Size(891, 32);
            this.msMenu.TabIndex = 2;
            this.msMenu.Text = "menuStrip1";
            // 
            // msTareas
            // 
            this.msTareas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarTareaToolStripMenuItem,
            this.historialTareaToolStripMenuItem});
            this.msTareas.Name = "msTareas";
            this.msTareas.Size = new System.Drawing.Size(67, 28);
            this.msTareas.Text = "Tareas";
            // 
            // msAdministracion
            // 
            this.msAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msUsuario,
            this.toolStripMenuItem1,
            this.msAuditoria});
            this.msAdministracion.Name = "msAdministracion";
            this.msAdministracion.Size = new System.Drawing.Size(124, 28);
            this.msAdministracion.Text = "Administración";
            // 
            // msUsuario
            // 
            this.msUsuario.Name = "msUsuario";
            this.msUsuario.Size = new System.Drawing.Size(154, 28);
            this.msUsuario.Text = "Usuario";
            this.msUsuario.Click += new System.EventHandler(this.msUsuario_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            // 
            // msAuditoria
            // 
            this.msAuditoria.Name = "msAuditoria";
            this.msAuditoria.Size = new System.Drawing.Size(154, 28);
            this.msAuditoria.Text = "Auditoría";
            this.msAuditoria.Click += new System.EventHandler(this.msAuditoria_Click);
            // 
            // registrarTareaToolStripMenuItem
            // 
            this.registrarTareaToolStripMenuItem.Name = "registrarTareaToolStripMenuItem";
            this.registrarTareaToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.registrarTareaToolStripMenuItem.Text = "Registrar Tarea";
            this.registrarTareaToolStripMenuItem.Click += new System.EventHandler(this.registrarTareaToolStripMenuItem_Click);
            // 
            // historialTareaToolStripMenuItem
            // 
            this.historialTareaToolStripMenuItem.Name = "historialTareaToolStripMenuItem";
            this.historialTareaToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.historialTareaToolStripMenuItem.Text = "Historial Tarea";
            this.historialTareaToolStripMenuItem.Click += new System.EventHandler(this.historialTareaToolStripMenuItem_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 604);
            this.Controls.Add(this.ssUsuario);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.picFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInicio_FormClosing);
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            this.ssUsuario.ResumeLayout(false);
            this.ssUsuario.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.StatusStrip ssUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblFecha;
        private System.Windows.Forms.ToolStripStatusLabel lblContador;
        private System.Windows.Forms.Timer tmContador;
        private System.Windows.Forms.Timer tmFecha;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem msTareas;
        private System.Windows.Forms.ToolStripMenuItem msAdministracion;
        private System.Windows.Forms.ToolStripMenuItem msUsuario;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem msAuditoria;
        private System.Windows.Forms.ToolStripMenuItem registrarTareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialTareaToolStripMenuItem;
    }
}

